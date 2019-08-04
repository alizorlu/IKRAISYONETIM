using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.FirmalarManager
{
    public interface IFirmalarManager
    {
        IEnumerable<Firmalar> All();
        void Insert(Firmalar model);
        void Delete(Guid id);
        void Update(Firmalar model);
        Firmalar Find(Guid id);
    }
    public class EFFirmalarManager : IFirmalarManager
    {
        private UnitOfRepo _repo;
        public EFFirmalarManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Firmalar> All()
        {
            return _repo.firmaRepository.Get();
        }

        public void Delete(Guid id)
        {
            _repo.firmaRepository.Delete(id);
            _repo.Save();
        }

        public Firmalar Find(Guid id)
        {
            return _repo.firmaRepository.GetById(id);
        }

        public void Insert(Firmalar model)
        {
            _repo.firmaRepository.Insert(model);
            _repo.Save();
        }

        public void Update(Firmalar model)
        {
            _repo.firmaRepository.Update(model);
            _repo.Save();
        }
    }
    public class FirmalarManager
    {
        private IFirmalarManager _manager;
        public FirmalarManager(IFirmalarManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Firmalar> All()
        {
            return _manager.All();
        }

        public void Delete(Guid id)
        {
            _manager.Delete(id);
        }

        public Firmalar Find(Guid id)
        {
            return _manager.Find(id);
        }

        public void Insert(Firmalar model)
        {
            _manager.Insert(model);
        }

        public void Update(Firmalar model)
        {
            _manager.Update(model);
        }
    }
}
