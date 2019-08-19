using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using Ikra_Is_Yonetim.Utilities.HashManager;
using Ninject;
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
        Musteriler Query(string phone);
        Musteriler Login(string phone, string pass);
        Musteriler SifreGuncelle(Guid id, string pass);
        string YeniSifreOlustur();
    }
    public class EFCarilerManager : ICarilerManager
    {
        private UnitOfRepo _repo;
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IHashManager _hash;
        public EFCarilerManager()
        {
            _repo = new UnitOfRepo();
            _hash = kernel.Get<IHashManager>();
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

        public Musteriler SifreGuncelle(Guid id, string pass)
        {
            string hashPass = _hash.Create(pass);
            var result = Find(id);
            if (result == null) return null;
            result.GeciciPassword = hashPass;
            Update(result);
            return result;
        }

        public void Update(Musteriler model)
        {
            _repo.musterilerRepository.Update(model);
            _repo.Save();
        }

        public string YeniSifreOlustur()
        {
            tekrar:
            string pass = new Random().Next(10000, 99999).ToString();
            StandardKernel kernel = SingletonKernelManager.Instance;
            IHashManager _hash = kernel.Get<IHashManager>();
            string hashPass = _hash.Create(pass);
            //Bunu tüm şifrelerde ara...
            var result = All().Where(s => s.GeciciPassword.Equals(hashPass))
                .FirstOrDefault();
            if (result == null)
            {
                //Çakışmayan şifre gönder...
                return pass;
            }
            else goto tekrar;
        }

        public Musteriler Query(string phone)
        {
            return All().Where(s => s.Telefon.Equals(phone))
                .FirstOrDefault();
        }
    }
    public class CarilerManager
    {
    }
}
