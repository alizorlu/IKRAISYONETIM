using Ikra_Is_Yonetim.BL.Ninject;
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
        public homeController()
        {
            lock (_yemekLock)
            {
                if (_yemek == null)
                    _yemek = kernel.Get<IYemekManager>();
            }
        }
        // GET: home
        public PartialViewResult _gununYemegi()
        {
            DAL.EntityFramework.Tables.Yemekler
                result = _yemek.GununYemegi();
            return PartialView(result);
        }
        public ActionResult index()
        {
            return View();
        }
    }
}