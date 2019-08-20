using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ikra_Is_Yonetim.BL.YemekManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ikra_Is_Yonetim.PL.Web.Controllers
{
    [Authorize]
    public class homeController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IYemekManager _yemek;
        private static readonly object _yemekLock = new object();
        private ICarilerManager _cari;
        private static readonly object _cariLock = new object();
        private ISiparisManager _siparis;
        private static readonly object _siparisLock = new object();
        public homeController()
        {
            lock (_yemekLock)
            {
                if (_yemek == null)
                    _yemek = kernel.Get<IYemekManager>();
            }
            lock (_siparisLock)
            {
                if (_siparis == null) _siparis = kernel.Get<ISiparisManager>();
            }
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
            }
        }
        // GET: home
        private bool isLoginUser()
        {
            return HttpContext.User.Identity.IsAuthenticated;
        }
        public Guid getLoginUserId()
        {
            if (isLoginUser() == false) return Guid.Empty;
            else return Guid.Parse(HttpContext.User.Identity.Name.ToString());
        }
        public PartialViewResult _gununYemegi()
        {
            DAL.EntityFramework.Tables.Yemekler
                result = _yemek.GununYemegi();
            return PartialView(result);
        }
        public ActionResult _siparisOzet()
        {
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            if (_id == null) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            IEnumerable<DAL.EntityFramework.Tables.Siparisler>
                result 
                = _siparis.AllMyOrder(_id);
            return PartialView(result);
        }
        public ActionResult _odemeOzet()
        {
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            if (_id == null) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            IEnumerable<DAL.EntityFramework.Tables.Siparisler>
                result
                = _siparis.AllMyOrder(_id);
            result = result.Where(s => s.OdemeId == null || s.OdemeId == Guid.Empty);
            return PartialView(result);
        }
        public ActionResult _son5Siparisler()
        {
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            if (_id == null) return new HttpNotFoundResult("Geçersiz müşteri numarası");
            IEnumerable<DAL.EntityFramework.Tables.Siparisler>
               result
               = _siparis.AllMyOrder(_id);
            result = result.OrderByDescending(s=>s.SiparisTarihi).Take(5);
            return PartialView(result);
        }
        public ActionResult index()
        {
            return View();
        }
    }
}