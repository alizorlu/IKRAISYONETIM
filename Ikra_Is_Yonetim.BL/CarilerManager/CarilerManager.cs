using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.CarilerManager
{
    public interface ICarilerManager
    {
        IEnumerable<Musteriler> All();
        IEnumerable<Musteriler> Search(string query);
        void Insert(Musteriler model);
        void Update(Musteriler model);
        void Delete(Guid id);
        Musteriler Find(Guid id);
        Musteriler Login(string phone, string pass);
    }
    public class EFCarilerManager : ICarilerManager
    {
        private UnitOfRepo _repo;
        public EFCarilerManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Musteriler> All()
        {
            return _repo.musterilerRepository.Get();

        }

        public void Delete(Guid id)
        {
            _repo.musterilerRepository.Delete(id);
            _repo.Save();
        }

        public Musteriler Find(Guid id)
        {
            return _repo.musterilerRepository.GetById(id);
        }

        public void Insert(Musteriler model)
        {
            _repo.musterilerRepository.Insert(model);
            _repo.Save();
        }

        public Musteriler Login(string phone, string pass)
        {
            var result = All().Where(s => s.Telefon.Equals(phone)
              && s.GeciciPassword.Equals(pass)).FirstOrDefault();
            if (result == null) return null;
            else return result;
        }

        public IEnumerable<Musteriler> Search(string query)
        {
            if (query == null || query.Length <= 0) return null;
            return All().Where(s => s.FirmaAdSoyad.ToLower().Contains(query.ToLower()));
        }

        public void Update(Musteriler model)
        {
            _repo.musterilerRepository.Update(model);
            _repo.Save();
        }
    }
    public class CarilerManager
    {
    }
}
