using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.StoklarManager
{
    public interface IStoklarManager
    {
        IEnumerable<Stoklar> All();
        IEnumerable<Stoklar> AllBiten();
        void Insert(Stoklar model);
        void Update(Stoklar model);
    }
    public class EFStoklarManager : IStoklarManager
    {
        private UnitOfRepo _repo;
        public EFStoklarManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Stoklar> All()
        {
            return _repo.stokRepository.Get(s=>s.StokKgBirimAlinan>0m);
        }

        public IEnumerable<Stoklar> AllBiten()
        {
            return _repo.stokRepository.Get(s => s.StokKgBirimKalan <= 0);
        }

        public void Insert(Stoklar model)
        {
            model.StokKgBirimKalan = model.StokKgBirimAlinan;
            _repo.stokRepository.Insert(model);
            _repo.Save();
        }

        public void Update(Stoklar model)
        {
            _repo.stokRepository.Insert(model);
            _repo.Save();
        }
    }
    public class StoklarManager : IStoklarManager
    {
        private IStoklarManager _manager;
        public StoklarManager(IStoklarManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Stoklar> All()
        {
            return _manager.All();
        }

        public IEnumerable<Stoklar> AllBiten()
        {
            return _manager.AllBiten();
        }

        public void Insert(Stoklar model)
        {
           
            _manager.Insert(model);
        }

        public void Update(Stoklar model)
        {
            _manager.Update(model);
        }
    }
}
