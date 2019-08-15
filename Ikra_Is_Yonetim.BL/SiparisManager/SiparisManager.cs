using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.SiparisManager
{
    public interface ISiparisManager
    {
        IEnumerable<Siparisler> All();
        IEnumerable<Siparisler> All(SiparisDurumu state);
        IEnumerable<Siparisler> AllToday();
        IEnumerable<Siparisler> AllMyOrder(Guid cariid);
        void Insert(Siparisler model);
        void Delete(Guid id);
        void Update(Siparisler model);
        Siparisler Find(Guid id);
        Siparisler DurumGuncelle(Guid siparisId, SiparisDurumu state);
        Siparisler VerilenSiparis(Guid cariid);
        long SiparisSayiControl();
    }
    public class EFSiparisManager : ISiparisManager
    {
        private UnitOfRepo _repo;
        public EFSiparisManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Siparisler> All()
        {
            return _repo.siparisRepository.Get();
        }

        public IEnumerable<Siparisler> All(SiparisDurumu state)
        {
            return _repo.siparisRepository.Get(s => s.SiparisDurum == state);
        }

        public IEnumerable<Siparisler> AllMyOrder(Guid cariid)
        {
            return All().Where(s => s.MusteriId == cariid);
        }

        public IEnumerable<Siparisler> AllToday()
        {
            return All()
                .Where(s => s.SiparisTarihi.Date.ToShortDateString()
                == DateTime.Now.Date.ToShortDateString());
        }

        public void Delete(Guid id)
        {
            _repo.siparisRepository.Delete(id);
            _repo.Save();
        }
        
        public Siparisler DurumGuncelle(Guid siparisId, SiparisDurumu state)
        
{
            
            Siparisler result = Find(id: siparisId);
            if (result == null) return null;
            result.SiparisDurum = state;
            if (state == SiparisDurumu.İletildi) result.TeslimTarihi = DateTime.Now;
            Update(result);
            return Find(result.Id);
        }

        public Siparisler Find(Guid id)
        {
            return _repo.siparisRepository.GetById(id);
        }

        public void Insert(Siparisler model)
        {
            _repo.siparisRepository.Insert(model);
            _repo.Save();
        }

        public long SiparisSayiControl()
        {
            return All().LongCount();
        }

        public void Update(Siparisler model)
        {
            _repo.siparisRepository.Update(model);
            _repo.Save();
        }

        public Siparisler VerilenSiparis(Guid cariid)
        {
            List<Siparisler> cariResults =
                All().Where(s => s.MusteriId == cariid)
                .ToList();
            if (cariResults == null || cariResults.Count == 0)
                return null;
            else
            {
                Siparisler resultToday =
                    cariResults.Where(s => s.SiparisTarihi.ToShortDateString()
                ==
                DateTime.Now.ToShortDateString())
                    .FirstOrDefault();
                if (resultToday == null) return null;
                else return resultToday;
            }
        }
    }
    class SiparisManager
    {
    }
}
