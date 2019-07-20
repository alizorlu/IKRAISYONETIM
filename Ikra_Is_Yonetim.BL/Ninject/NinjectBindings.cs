using Ikra_Is_Yonetim._3rdApp.EmailManager;
using Ikra_Is_Yonetim._3rdApp.SmsManager;
using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ikra_Is_Yonetim.Utilities.PasswordCreateManager;
using Ikra_Is_Yonetim.Utilities.RegexManager;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.Ninject
{
    public class NinjectBindings:NinjectModule
    {
        public override void Load()
        {
            //BL
            Bind<IKullaniciManager>().To<EFKullaniciManager>();

            //Utilities
            Bind<IHashManager>().To<CryptoHashManager>();
            Bind<IRegexManager>().To<SystemRegexManager>();
            Bind<IPasswordCreateManager>().To<PasswordCreater>();
            //3RD
            Bind<ISMSManager>().To<VatanSMS>();
            Bind<IEmailManager>().To<EFEmailManager>();
        }
    }
}
