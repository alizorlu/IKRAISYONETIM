using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
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
    }
    public class EFOdemeManager : IOdemeManager
    {
        private UnitOfRepo _repo;
        public EFOdemeManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<SiparisOdeme> All()
        {
            return _repo.odemeRepository.Get();
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
