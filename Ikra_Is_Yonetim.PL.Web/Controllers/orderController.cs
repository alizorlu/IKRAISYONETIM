using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
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
            _siparis = kernel.Get<ISiparisManager>();
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
    }
}