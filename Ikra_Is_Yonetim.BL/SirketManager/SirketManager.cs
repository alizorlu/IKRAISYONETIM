using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.SirketManager
{
    public interface ISirketManager
    {
        void Insert(SirketBilgiTB model);
        SirketBilgiTB Find();
    }
    public class EFSirketManager : ISirketManager
    {
        private UnitOfRepo _repo;
        public EFSirketManager()
        {
            _repo = new UnitOfRepo();
        }
        public SirketBilgiTB Find()
        {
            return _repo.sirketRepository.Get().FirstOrDefault();
        }

        public void Insert(SirketBilgiTB model)
        {
            _repo.sirketRepository.Insert(model);
            _repo.Save();
        }
    }
    public class SirketManager 
    {
        private ISirketManager _manager;
        public SirketManager(ISirketManager manager)
        {
            _manager = manager;
        }
        public SirketBilgiTB Find()
        {
            return _manager.Find();
        }

        public void Insert(SirketBilgiTB model)
        {
            _manager.Insert(model);
        }
    }
}
