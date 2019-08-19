using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.OdemeManager
{
    public interface IOdemeManager
    {
        IEnumerable<SiparisOdeme> All();
        void Insert(SiparisOdeme odeme);
        IEnumerable<SiparisOdeme> AllMy(Guid cariid);
    }
    public class EFOdemeManager : IOdemeManager
    {
        private UnitOfRepo _repo;
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private ISiparisManager _siparis;
        private static readonly object _siparisLock = new object();
        public EFOdemeManager()
        {
            _repo = new UnitOfRepo();
            lock (_siparisLock)
            {
                if (_siparis == null) _siparis = kernel.Get<ISiparisManager>();
            }
        }
        public IEnumerable<SiparisOdeme> All()
        {
            return _repo.odemeRepository.Get();
        }

        public IEnumerable<SiparisOdeme> AllMy(Guid cariid)
        {
            //Carinin tüm siparişleri
            var result = _siparis.AllMyOrder(cariid);
            //Ödemesini yaptığı siparişler
            result = result.Where(s => s.OdemeId != null || s.OdemeId != Guid.Empty);
            //Geriye dönün siparişlerin Odemelerini dön
            return result.Select(s => s.Odeme).ToList();
        }

        public void Insert(SiparisOdeme odeme)
        {
            _repo.odemeRepository.Insert(odeme);
            _repo.Save();
        }
    }
    public class OdemeManager
    {
    }
}
