using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
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
        // GET: profile
        public profileController()
        {
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
        public PartialViewResult profile_layout()
        {
            return PartialView();
        }
        public ActionResult index()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            if (_id == Guid.Empty) return new HttpNotFoundResult("Geçersiz hesap id parametresi");
            var result = _cari.Find(_id);
            return View(result);
        }
    }
}