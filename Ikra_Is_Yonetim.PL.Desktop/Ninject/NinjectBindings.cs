using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.PL.Desktop.Ninject
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IKullaniciManager>().To<EFKullaniciManager>();
            Bind<IHashManager>().To<CryptoHashManager>();
        }
    }
}
