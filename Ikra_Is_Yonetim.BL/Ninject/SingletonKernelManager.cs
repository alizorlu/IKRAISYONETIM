using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.Ninject
{
    public sealed class SingletonKernelManager
    {
        private static volatile StandardKernel instance;
        private static object instanceLock = new object();
        public static StandardKernel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                            instance = new StandardKernel(new NinjectBindings());
                    }
                }
                return instance;
            }
        }
    }
}
