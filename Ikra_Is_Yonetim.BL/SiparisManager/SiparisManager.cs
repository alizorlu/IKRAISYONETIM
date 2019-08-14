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
        void Insert(Siparisler model);
        void Delete(Guid id);
        void Update(Siparisler model);
        Siparisler Find(Guid id);
        Siparisler DurumGuncelle(Guid siparisId, SiparisDurumu state);
        Siparisler VerilenSiparis(Guid cariid);
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
