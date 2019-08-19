using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.OdemeManager;
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
    public class paidController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager
            .Instance;
        private ISiparisManager _siparis;
        private static readonly object _siparisLock = new object();
        //Ödeme geçmişi
        // GET: paid
        public paidController()
        {
            lock (_siparisLock)
            {
                if (_siparis == null) _siparis = kernel.Get<ISiparisManager>();
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
        public ActionResult getProfile()
        {
            Guid _id = getLoginUserId();
            if (_id == null) return HttpNotFound();
            if (_id == Guid.Empty) return HttpNotFound();
            else return RedirectToAction("index", "paid", new { id = _id });
            //return View();
        }
        public ActionResult index(Guid id)
        {
            if (id == null) HttpNotFound();
            if (id == Guid.Empty) HttpNotFound();
            IEnumerable<DAL.EntityFramework.Tables.Siparisler> result 
                = _siparis.AllMyOrder(id);
            return View(result);
        }
    }
}