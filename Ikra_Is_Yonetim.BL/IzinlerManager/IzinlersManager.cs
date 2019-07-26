using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.IzinlerManager
{
    public interface IizinlerManager
    {
        IEnumerable<Izinler> All();
        IEnumerable<Izinler> All(Guid personalid);
        void Insert(Izinler model);
        void Update(Izinler model);
        Izinler Find(Guid id);
        void Delete(Izinler id);
    }
    public class EFIzinlerManager : IizinlerManager
    {
        private UnitOfRepo _repo;
        public EFIzinlerManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Izinler> All()
        {
            return _repo.izinlerRepository.Get();
        }

        public IEnumerable<Izinler> All(Guid personalid)
        {
            return _repo.izinlerRepository.Get(s => s.PersonelId == personalid);
        }

        public void Delete(Izinler id)
        {
            _repo.izinlerRepository.Delete(id);
            _repo.Save();
        }

        public Izinler Find(Guid id)
        {
            return _repo.izinlerRepository.GetById(id);
        }

        public void Insert(Izinler model)
        {
            _repo.izinlerRepository.Insert(model);
            _repo.Save();
        }

        public void Update(Izinler model)
        {
            _repo.izinlerRepository.Update(model);
            _repo.Save();
        }
    }
    public class IzinlersManager 
    {
        private IizinlerManager _manager;
        public IzinlersManager(IizinlerManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Izinler> All()
        {
            return _manager.All();
        }

        public IEnumerable<Izinler> All(Guid personalid)
        {
            return _manager.All(personalid);
        }

        public void Delete(Izinler id)
        {
            _manager.Delete(id);
        }

        public Izinler Find(Guid id)
        {
            return _manager.Find(id);
        }

        public void Insert(Izinler model)
        {
            _manager.Insert(model);
        }

        public void Update(Izinler model)
        {
            _manager.Update(model);
        }
    }
}
