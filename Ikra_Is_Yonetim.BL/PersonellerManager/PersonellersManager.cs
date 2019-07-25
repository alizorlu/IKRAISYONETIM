using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.PersonellerManager
{
    public interface IPersonellerManager
    {
        IEnumerable<Personeller> All();
        Personeller Find(Guid id);
        Personeller NewPersonel();
        void Insert(Personeller personeller);
        Personeller Update(Personeller personeller);
        void Delete(Guid id);
    }
    public class EFPersonellerManager : IPersonellerManager
    {
        private UnitOfRepo _repo;
        public EFPersonellerManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Personeller> All()
        {
            return _repo.personelRepository.Get();
        }

        public void Delete(Guid id)
        {
            _repo.personelRepository.Delete(id);
            _repo.Save();

        }

        public Personeller Find(Guid id)
        {
            return _repo.personelRepository.GetById(id);
        }

        public void Insert(Personeller personeller)
        {
            _repo.personelRepository.Insert(personeller);
            _repo.Save();
        }

        public Personeller NewPersonel()
        {
            return new Personeller();
        }

        public Personeller Update(Personeller personeller)
        {
            _repo.personelRepository.Update(personeller);
            _repo.Save();
            return personeller;
        }
    }
    public class PersonellersManager 
    {
        private IPersonellerManager _manager;
        public PersonellersManager(IPersonellerManager manager)
        {
            _manager = manager;
        }
        public Personeller NewPersonel()
        {
           return _manager.NewPersonel();
        }
        public IEnumerable<Personeller> All()
        {
            return _manager.All();
        }

        public void Delete(Guid id)
        {
            _manager.Delete(id);
        }

        public Personeller Find(Guid id)
        {
            return _manager.Find(id);
        }

        public void Insert(Personeller personeller)
        {
            _manager.Insert(personeller);
        }

        public Personeller Update(Personeller personeller)
        {
           return _manager.Update(personeller);
        }
    }
}
