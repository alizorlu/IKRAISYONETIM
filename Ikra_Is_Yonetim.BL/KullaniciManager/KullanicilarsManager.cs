using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.KullaniciManager
{
    public interface IKullaniciManager
    {
        IEnumerable<Kullanicilar> All();
        IEnumerable<Kullanicilar> AllActive();
        IEnumerable<Kullanicilar> AllPassive();
        IEnumerable<Kullanicilar> AllAdmin();
        IEnumerable<Kullanicilar> AllCustomer();
        IEnumerable<Kullanicilar> AllPersonal();
        void Insert(Kullanicilar model);
        void Update(Kullanicilar model);
        void Delete(Guid id);
        Kullanicilar Query(string username, string password);
        Kullanicilar Query(string phone);
        Kullanicilar QueryEmail(string email);
        
    }
    public class EFKullaniciManager : IKullaniciManager
    {
        private UnitOfRepo _repo;
        public EFKullaniciManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Kullanicilar> All()
        {
            return _repo.kullaniciRepository.Get();
        }

        public IEnumerable<Kullanicilar> AllActive()
        {
            return All().Where(s => s.IsState == true);
        }

        public IEnumerable<Kullanicilar> AllAdmin()
        {
            return AllActive().Where(s => s.Tip == KullanicilarType.Admin);
        }

        public IEnumerable<Kullanicilar> AllCustomer()
        {
            return AllActive().Where(s => s.Tip == KullanicilarType.Musteri);
        }

        public IEnumerable<Kullanicilar> AllPassive()
        {
            return All().Where(s => s.IsState == false);
        }

        public IEnumerable<Kullanicilar> AllPersonal()
        {
            return AllActive().Where(s => s.Tip == KullanicilarType.Personel);
        }

        public void Delete(Guid id)
        {
            _repo.kullaniciRepository.Delete(id);
            _repo.Save();
        }

        public void Insert(Kullanicilar model)
        {
            _repo.kullaniciRepository.Insert(model);
            _repo.Save();
        }

        public Kullanicilar Query(string username, string password)
        {
            return All().Where(s => s.UserName.Equals(username) && s.Password.Equals(password))
                .FirstOrDefault();
        }

        public Kullanicilar Query(string phone)
        {
            return AllActive().Where(s => s.Phone.Equals(phone)).FirstOrDefault();
        }

        public Kullanicilar QueryEmail(string email)
        {
            return AllActive().Where(s => s.Email.Equals(email)).FirstOrDefault();
        }

        public void Update(Kullanicilar model)
        {
            _repo.kullaniciRepository.Update(model);
            _repo.Save();
        }
    }
    public class KullanicilarsManager
    {
        private IKullaniciManager _manager;
        public KullanicilarsManager(IKullaniciManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Kullanicilar> All()
        {
            return _manager.All();
        }

        public IEnumerable<Kullanicilar> AllActive()
        {
            return _manager.AllActive();
        }

        public IEnumerable<Kullanicilar> AllAdmin()
        {
            return _manager.AllAdmin();
        }

        public IEnumerable<Kullanicilar> AllCustomer()
        {
            return _manager.AllCustomer();
        }

        public IEnumerable<Kullanicilar> AllPassive()
        {
            return _manager.AllPassive();
        }

        public IEnumerable<Kullanicilar> AllPersonal()
        {
            return _manager.AllPersonal();
        }

        public void Delete(Guid id)
        {
            _manager.Delete(id);
        }

        public void Insert(Kullanicilar model)
        {
            _manager.Insert(model);
        }

        public Kullanicilar Query(string username, string password)
        {
            return _manager.Query(username, password);
        }

        public Kullanicilar Query(string phone)
        {
            return _manager.Query(phone);
        }

        public Kullanicilar QueryEmail(string email)
        {
            return _manager.QueryEmail(email);
        }

        public void Update(Kullanicilar model)
        {
            _manager.Update(model);
        }
    }
}
