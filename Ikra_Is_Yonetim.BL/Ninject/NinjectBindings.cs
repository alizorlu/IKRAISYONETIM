using Ikra_Is_Yonetim._3rdApp.EmailManager;
using Ikra_Is_Yonetim._3rdApp.SmsManager;
using Ikra_Is_Yonetim.BL.AvanslarManager;
using Ikra_Is_Yonetim.BL.IzinlerManager;
using Ikra_Is_Yonetim.BL.KasaManager;
using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.BL.MaasManager;
using Ikra_Is_Yonetim.BL.PersonellerManager;
using Ikra_Is_Yonetim.BL.SirketManager;
using Ikra_Is_Yonetim.BL.StoklarManager;
using Ikra_Is_Yonetim.Utilities.HashManager;
//using Ikra_Is_Yonetim.Utilities.ImageBinaryDataManager;
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
            Bind<IPersonellerManager>().To<EFPersonellerManager>();
            Bind<IizinlerManager>().To<EFIzinlerManager>();
            Bind<IAvansManager>().To<EFManager>();
            Bind<ISirketManager>().To<EFSirketManager>();
            Bind<IMaasManager>().To<EFMaasManager>();
            Bind<IKasaManager>().To<EFKasaManager>();
            Bind<IStoklarManager>().To<EFStoklarManager>();
            //Utilities
            Bind<IHashManager>().To<CryptoHashManager>();
            Bind<IRegexManager>().To<SystemRegexManager>();
            Bind<IPasswordCreateManager>().To<PasswordCreater>();
            //Bind<IImageBinaryDataManager>().To<SystemImageBinaryData>();
            //3RD
            Bind<ISMSManager>().To<VatanSMS>();
            Bind<IEmailManager>().To<EFEmailManager>();
            

        }
    }
}
