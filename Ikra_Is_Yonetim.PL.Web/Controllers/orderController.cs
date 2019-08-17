using Ikra_Is_Yonetim._3rdApp.IyzicoManager;
using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.KasaManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.OdemeManager;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ikra_Is_Yonetim.BL.YemekManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ikra_Is_Yonetim.PL.Web.Controllers
{
    [Authorize]
    public class orderController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;

        private ISiparisManager _siparis;
        private IYemekManager _yemek;
        private static readonly object _yemekLock = new object();
        private ICarilerManager _cari;
        private static readonly object _cariLock = new object();
        private IOdemeManager _odeme;
        private static readonly object _odemeLock = new object();
        private IKasaManager _kasa;
        private static readonly object _kasaLock = new object();

        private IIyzicoPaymentManager _iyzico;
        // GET: order
        public orderController()
        {
            lock (_yemekLock)
            {
                if (_yemek == null) _yemek = kernel.Get<IYemekManager>();
            }
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
            }
            lock (_odemeLock)
            {
                if (_odeme == null) _odeme = kernel.Get<IOdemeManager>();
            }
            lock (_kasaLock)
            {
                if (_kasa == null) _kasa = kernel.Get<IKasaManager>();
            }
            _siparis = kernel.Get<ISiparisManager>();
            _iyzico = kernel.Get<IIyzicoPaymentManager>();
        }
        private bool isLoginUser()
        {
            return HttpContext.User.Identity.IsAuthenticated;
        }
        public Guid getLoginUserId()
        {
            if (isLoginUser() == false) return Guid.Empty;
            else return Guid.Parse(HttpContext.User.Identity.Name.ToString());
        }
        public PartialViewResult _yemekBilgiView(Guid yemekid)
        {
            Yemekler result = _yemek.Find(yemekid);
            return PartialView(result);
        }
        public ActionResult create(Guid yemekid)
        {
            Siparisler model = new Siparisler();
            model.YemekId = yemekid;
            model.Yemek = _yemek.Find(yemekid);
            model.Id = Guid.NewGuid();
            Guid musteriId = getLoginUserId();
            if (musteriId == Guid.Empty) return null;
            model.MusteriId = musteriId;
            model.Musteri = _cari.Find(musteriId);
            model.SiparisDurum = SiparisDurumu.Onay;
            model.SiparisTarihi = DateTime.Now;
            model.YemekSayisi = model.Musteri.GunlukYemekSayisi;
            return View(model);
        }
        [HttpPost]
        public ActionResult create(Siparisler model)
        {
            if (model == null) return null;
            _siparis.Insert(model);
            return RedirectToAction("index", "home");
        }

        public ActionResult index(string type)
        {
            
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return null;
            IEnumerable<Siparisler> result = _siparis.AllMyOrder(_id);
            if (type=="1")
            {
                result = result.Where(s => (s.OdemeId == null || s.OdemeId == Guid.Empty)
                  &&
                  s.SiparisDurum == SiparisDurumu.İletildi
                );
            }
            else if (type=="2")
            {
                result = result.Where(s => (s.OdemeId != null &&s.OdemeId != Guid.Empty)
                  &&
                  s.SiparisDurum == SiparisDurumu.İletildi
                );
            }
            return View(result);
        }
        [HttpPost]
        public ActionResult multipayment(List<string> selected)
        {

            List<Siparisler> result = new List<Siparisler>();
            foreach (var item in selected)
            {
                result.Add(_siparis.Find(Guid.Parse(item.ToString())));
            }
            Iyzipay.Model.CheckoutFormInitialize
                form = _iyzico.GetPaymentForm(result);
            if (form.Status == "success")
            {
                TempData["cid"] = form.ConversationId.ToString();
                return View(form);
            }
            else return null;
            
        }
        //MerchantPayoutAmount = "788.4875" net fiyat
        //PaidPrice = "810" ÖDenen fiyat
        public ActionResult paymentForm(string token,string conversationId)
        {
            string cid = TempData["cid"] as string;
            var result = _iyzico.ContolPayment(token, cid);
            if (result.Status== "success")
            {
                foreach (var item in result.PaymentItems)
                {
                    Guid siparisId = Guid.Parse(item.ItemId);
                    //Ödemeyi kaydet.
                    //Siparişi Güncelle.
                    //Kasaya Giriş yap.
                    SiparisOdeme odeme = new SiparisOdeme()
                    {
                        KartTip = result.CardType,
                        KartBinNumber = result.BinNumber,
                        KartAile = result.CardFamily,
                        NetOdemeTutari = item.MerchantPayoutAmount,
                        OdemeTarihi = DateTime.Now,
                        OdemeTutari = item.PaidPrice,
                        SonDortHane = result.LastFourDigits,
                    };

                    _odeme.Insert(odeme);

                    Siparisler siparis = _siparis.Find(siparisId);
                    siparis.OdemeId = odeme.OdemeId;
                    //siparis.Odeme = odeme;
                    _siparis.Update(siparis);
                  
                    
                    _kasa.InsertSiparisOdeme(siparis);
                }
                return RedirectToAction("index", "order");
            }
            else
            {
                return View(result);
            }
        }
    }
}