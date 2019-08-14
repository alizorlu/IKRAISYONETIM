using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ikra_Is_Yonetim.PL.Web.Controllers
{
    [Authorize]
    public class authPartialController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;

        private ICarilerManager _cari;
        private static readonly object _cariLock = new object();
        
        private ISiparisManager _siparis;
        // GET: authPartial
        public authPartialController()
        {
            //Her seferinde yenilenerek işaretlenir.
            _siparis = kernel.Get<ISiparisManager>();
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
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
        public PartialViewResult _profileView()
        {
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return PartialView(null);
            DAL.EntityFramework.Tables.Musteriler 
                cari 
                = _cari.Find(id: _id);
            return PartialView(cari);
        }

        public PartialViewResult _orderView()
        {
            Guid _id = getLoginUserId();
            if (_id == Guid.Empty) return PartialView(null);
            DAL.EntityFramework.Tables.Siparisler
                result 
                = _siparis.VerilenSiparis(_id);
            return PartialView(result);
        }
    }
}