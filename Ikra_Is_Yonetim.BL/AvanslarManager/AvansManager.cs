using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.AvanslarManager
{
    public interface IAvansManager
    {
        IEnumerable<Avanslar> All();
        IEnumerable<Avanslar> All(Guid personalid);
        void Insert(Avanslar model);
        void Update(Avanslar model);
    }
    public class EFManager : IAvansManager
    {
        private UnitOfRepo _repo;
        public EFManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Avanslar> All()
        {
            return _repo.avansRepository.Get();
        }

        public IEnumerable<Avanslar> All(Guid personalid)
        {
            return _repo.avansRepository.Get(f => f.PersonelId == personalid);

        }

        public void Insert(Avanslar model)
        {
            _repo.avansRepository.Insert(model);
            _repo.Save();
        }

        public void Update(Avanslar model)
        {
            _repo.avansRepository.Update(model);
            _repo.Save();
        }
    }
    public class AvansManager 
    {
        private IAvansManager _manager;
        public AvansManager(IAvansManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Avanslar> All()
        {
            return _manager.All();
        }

        public IEnumerable<Avanslar> All(Guid personalid)
        {
            return _manager.All(personalid);
        }

        public void Insert(Avanslar model)
        {
            _manager.Insert(model);
        }

        public void Update(Avanslar model)
        {
            _manager.Update(model);
        }
    }
}
