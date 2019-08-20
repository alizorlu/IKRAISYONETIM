using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.MusteriHareketlerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ikra_Is_Yonetim.BL.SirketManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.Utilities.ClientManager;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Invoicer.Models;
using Invoicer.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ikra_Is_Yonetim.PL.Web.Controllers
{
    [Authorize]
    public class profileController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private ICarilerManager _cari;
        private static readonly object _cariLock = new object();
        private IHashManager _hash;
        private static readonly object _hashLock = new object();
        private ISiparisManager _siparis;
        private static readonly object _siparisLock = new object();
        private ISirketManager _sirket;
        private static readonly object _sirketLock = new object();
        private IMusteriHareketManager _hareket;
        private static readonly object _hareketLock = new object();
        private IClientManager _client;
        private static readonly object _clientLock = new object();
        
        // GET: profile
        public profileController()
        {
            #region Cihaz Hareketleri İçin Kullanılan Modüller
            lock (_hareketLock)
            {
                if (_hareket == null) _hareket = kernel.Get<IMusteriHareketManager>();
            }
            lock (_clientLock)
            {
                if (_client == null) _client = kernel.Get<IClientManager>();
            }
            #endregion
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
            }
            lock (_hashLock)
            {
                if (_hash == null) _hash = kernel.Get<IHashManager>();
            }
            lock (_siparisLock)
            {
                if (_siparis == null) _siparis = kernel.Get<ISiparisManager>();
            }
            lock (_sirketLock)
            {
                if (_sirket == null) _sirket = kernel.Get<ISirketManager>();
            }
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
        public PartialViewResult profile_layout()
        {
            return PartialView();
        }
        public ActionResult index()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            Musteriler result = _cari.Find(_id);
            return View(result);
        }
        public ActionResult edit()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            Musteriler result = _cari.Find(_id);
            return View(result);
        }
        [HttpPost]
        public ActionResult edit(Musteriler model)
        {
            if (ModelState.IsValid)
            {
                _cari.Update(model);
                TempData["ok"] = "1";
            }
            else
            {
                TempData["ok"] = "0";
            }
            return View(model);
        }
        public ActionResult repassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult repassword(string nowpassword, string newpassword, string newpassword2)
        {
            if (string.IsNullOrWhiteSpace(newpassword))
            {
                TempData["ok"] = "0";
                return View();
            }
            if(string.IsNullOrWhiteSpace(newpassword2))
            {
                TempData["ok"] = "0";
                return View();
            }
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            Musteriler result = _cari.Find(_id);
            string nowPassHash = _hash.Create(nowpassword);
            if(result.GeciciPassword.Equals(nowPassHash))
            {
                string passHash1 = _hash.Create(newpassword);
                string passHash2 = _hash.Create(newpassword2);
                if (passHash1.Equals(passHash2))
                {
                    result.GeciciPassword
                        = passHash1;
                    _cari.Update(result);
                    TempData["ok"] = "1";
                    _hareket.Insert(new MusteriGirisHareketleri()
                    {
                        IslemTarihi = DateTime.Now,
                        Islem = HareketTipleri.Sifre_Degistirme,
                        IslemAciklama = "Profilinizden şifrenizi değiştirdiniz.",
                        MusteriId = result.Id,
                        CihazIp = _client.GetClientIp(),
                        CihazBrowserAnonId = _client.GetClientAnonId(),
                        CihazBrowser = _client.GetBrowser(_client.GetUserAgent(), _client.GetVersion())
                    });
                }
                else TempData["ok"] = "2";
            }
            else { TempData["ok"] = "3"; }
            return View();
        }
        public ActionResult history()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            IEnumerable<MusteriGirisHareketleri>
                result 
                = _hareket.All(_id);
            return View(result);
        }
        public ActionResult invoice()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            IEnumerable<Siparisler> result = _siparis.OdemesiYapilanSiparisler(_id);
            return View(result);
        }
        public ActionResult createinvoice(Guid id)
        {
            if (id == null) return new HttpNotFoundResult("Geçersiz fatura numarası");
            if (id == Guid.Empty) return new HttpNotFoundResult("Geçersiz fatura numarası");
            Siparisler result = _siparis.Find(id);
            if (result == null) return new HttpNotFoundResult("Böyle bir sipariş bulunamadı.");
            SirketBilgiTB sirket = _sirket.Find();
            string fatid = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            List<ItemRow> aciklamalar = new List<ItemRow>();
            aciklamalar.Add(ItemRow.Make("Günlük Yemek Ücreti", $"{result.Yemek.YemekAdi} {result.Yemek.PorsiyonGr} gr,{result.YemekSayisi} kişilik,sipariş trh:{result.SiparisTarihi.ToShortDateString()}", result.YemekSayisi, 8.0m, result.Musteri.GunlukYemekFiyati, decimal.Parse(result.Odeme.OdemeTutari)));
            new InvoicerApi(SizeOption.A4, OrientationOption.Landscape, "₺")
          .TextColor("#8C2234")
             .BackColor("#FFD6CC").Title($"Günlük Yemek Faturası")
             .Image(HttpContext.Server.MapPath("~/Content/assets/images/ikra/logo.png"), 127, 85)
              .Company(Address.Make($"ÖDEME YAPAN", new string[] { result.Musteri.FirmaAdSoyad, result.Musteri.Telefon, result.Musteri.Email, result.Musteri.FirmaAdres }))
              .Client(Address.Make($"ÖDEME ALAN", new string[] { sirket.Name, sirket.Phone, sirket.VATNo, sirket.Address }, sirket.Name, sirket.VATNo))
             .Items(aciklamalar)
             .DueDate(result.Odeme.OdemeTarihi)
             .Totals(new List<TotalRow> {
        TotalRow.Make("Ara Toplam(Kesinti)",0m),
        TotalRow.Make("Toplam Ödenen Ücret", decimal.Parse(result.Odeme.OdemeTutari), true),
 })
             .Details(new List<DetailRow> {
        DetailRow.Make("Yemek Ücreti Faturası",
        $"Müşterimiz {result.Musteri.FirmaAdSoyad}'nın günlük yemek ücreti için verilen faturadır") })
             .Footer("http://www.ikrayemek.com.tr")
             .Reference(fatid.Substring(0,15))
             
                 .Save(HttpContext.Server.MapPath("~/Content/")+fatid+".pdf");
            byte[] fileBytes = System.IO.File.ReadAllBytes(HttpContext.Server.MapPath("~/Content/")+fatid+".pdf");
            string fileName = $"IKRAYEMEK{result.SiparisTarihi.Year}{result.SiparisTarihi.Month}{result.SiparisTarihi.Day}{result.SiparisTarihi.Hour}{result.SiparisTarihi.Minute}{result.SiparisTarihi.Second}-FATURA.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);
            return File("", "");
        }
    }
}