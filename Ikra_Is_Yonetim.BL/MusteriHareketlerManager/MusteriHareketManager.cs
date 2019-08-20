using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.MusteriHareketlerManager
{
    public interface IMusteriHareketManager
    {
        IEnumerable<MusteriGirisHareketleri> All(Guid cariid);
        void Insert(MusteriGirisHareketleri model);
        
    }
    public class EFMusteriHareketManager : IMusteriHareketManager
    {
        private UnitOfRepo _repo;
        public EFMusteriHareketManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<MusteriGirisHareketleri> All(Guid cariid)
        {
            return _repo.hareketRepository
                .Get(s => s.MusteriId == cariid);
        }

        public void Insert(MusteriGirisHareketleri model)
        {
            _repo.hareketRepository.Insert(model);
            _repo.Save();
        }
    }
    class MusteriHareketManager
    {
    }
}
