using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ikra_Is_Yonetim.PL.Web.Controllers
{
    public class accountController : Controller
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IHashManager _hash;
        private static readonly object _hashLock = new object();
        private ICarilerManager _cari;
        private static readonly object _cariLock = new object();
        public accountController()
        {
            lock (_hashLock)
            {
                if (_hash == null) _hash = kernel.Get<IHashManager>();
            }
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
            }
        }

        // GET: account
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(string phone,string pass)
        {
           
            if(!string.IsNullOrEmpty(pass)&&!string.IsNullOrEmpty(phone))
            {
                DAL.EntityFramework.Tables.Musteriler 
                    result 
                    = _cari.Login(phone, _hash.Create(pass));
                if (result == null)
                {
                    TempData["hata"] = "0";
                    return RedirectToAction("login", "account");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(result.Id.ToString(), false);
                    return RedirectToAction("index", "home");
                }
            }
            return View();
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login", "account");
        }
    }
}