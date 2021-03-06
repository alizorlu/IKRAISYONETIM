﻿using Ikra_Is_Yonetim._3rdApp.SmsManager;
using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.MusteriHareketlerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.Utilities.ClientManager;
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
        private ISMSManager _sms;
        private static readonly object _smsLock = new object();
        private IMusteriHareketManager _hareket;
        private static readonly object _hareketLock = new object();
        private IClientManager _client;
        private static readonly object _clientLock = new object();
        public accountController()
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
            lock (_hashLock)
            {
                if (_hash == null) _hash = kernel.Get<IHashManager>();
            }
            lock (_cariLock)
            {
                if (_cari == null) _cari = kernel.Get<ICarilerManager>();
            }
            lock (_smsLock)
            {
                if (_sms == null) _sms = kernel.Get<ISMSManager>();
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
                    _hareket.Insert(new MusteriGirisHareketleri()
                    {
                        IslemTarihi = DateTime.Now,
                        Islem = HareketTipleri.Giris,
                        IslemAciklama = "Giriş yaptınız.",
                        MusteriId = result.Id,
                        CihazIp = _client.GetClientIp(),
                        CihazBrowserAnonId = _client.GetClientAnonId(),
                        CihazBrowser=_client.GetBrowser(_client.GetUserAgent(),_client.GetVersion())
                    });
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

        [HttpPost]
        public JsonResult repass(string phone)
        {
            if (phone == null || phone == "") return new JsonResult() {
                Data="Telefon boş olamaz",
                JsonRequestBehavior=JsonRequestBehavior.AllowGet
            };
            if (phone.Length != 11) return new JsonResult() {
                Data="Telefon 11 haneli girilmelidir.",
                JsonRequestBehavior=JsonRequestBehavior.AllowGet
            };
            var result = _cari.Query(phone);
            if (result==null)
            {
                return new JsonResult()
                {
                    Data = "Böyle bir hesap bulunamadı",
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            string sifre = _cari.YeniSifreOlustur();
            _cari.SifreGuncelle(result.Id, sifre);
            _sms.SetAuth();
           bool isSended=
                _sms.TekSmsGonder(new SmsModel() {
                Phone=result.Telefon,
                Text=$"Talebiniz doğrultusunda" +
                $" şifrenizi güncelledik." +
                $"Bilgileriniz;\nTelefon:{result.Telefon}\nŞifre:{sifre}"
            });
            if (isSended == true)
            {
                _hareket.Insert(new MusteriGirisHareketleri()
                {
                    IslemTarihi = DateTime.Now,
                    Islem = HareketTipleri.Sifre_Degistirme,
                    IslemAciklama = "Şifrenizi unuttuğunuz için talebiniz doğrultusunda yeni şifre verildi.",
                    MusteriId = result.Id,
                    CihazIp = _client.GetClientIp(),
                    CihazBrowserAnonId = _client.GetClientAnonId(),
                    CihazBrowser = _client.GetBrowser(_client.GetUserAgent(), _client.GetVersion())
                });
                return Json("Yeni şifre telefon numaranıza gönderildi.", JsonRequestBehavior.AllowGet);

            }
            else
            {
                _hareket.Insert(new MusteriGirisHareketleri()
                {
                    IslemTarihi = DateTime.Now,
                    Islem = HareketTipleri.Sifre_Degistirme,
                    IslemAciklama = "Şifrenizi unuttuğunuz için talebiniz doğrultusunda yeni şifre verildi.",
                    MusteriId = result.Id,
                    CihazIp = _client.GetClientIp(),
                    CihazBrowserAnonId = _client.GetClientAnonId(),
                    CihazBrowser = _client.GetBrowser(_client.GetUserAgent(), _client.GetVersion())
                });
                return Json("Yeni şifreni oluşturduk fakat SMS hizmetimizde bir sorun oluştuğu için sms gönderemedik.Lütfen bizimle iletişime geçiniz.", JsonRequestBehavior.AllowGet);
            }
           

        }
    }
}