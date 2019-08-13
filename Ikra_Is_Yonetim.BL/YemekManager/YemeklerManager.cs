using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.YemekManager
{
    public interface IYemekManager
    {
        IEnumerable<Yemekler> All();
        void Insert(Yemekler yemek);
        void Update(Yemekler yemek);
        void Delete(Guid id);
        Yemekler Find(Guid id);
        Yemekler GununYemegi();
    }
    public class EFYemekManager : IYemekManager
    {
        private UnitOfRepo _repo;
        public EFYemekManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Yemekler> All()
        {
            return _repo.yemekRepository.Get();
        }

        public void Delete(Guid id)
        {
            _repo.yemekRepository.Delete(id);
        }

        public Yemekler Find(Guid id)
        {
            return _repo.yemekRepository.GetById(id);
        }

        public Yemekler GununYemegi()
        {
            return All().Where(s => s.UretimZamani.ToShortDateString()
            ==DateTime.Now.ToShortDateString()&&s.YayinDurumu==true)
                .FirstOrDefault();
                
        }

        public void Insert(Yemekler yemek)
        {
            _repo.yemekRepository.Insert(yemek);
            _repo.Save();
        }

        public void Update(Yemekler yemek)
        {
            _repo.yemekRepository.Update(yemek);
            _repo.Save();
        }
    }
    public class YemeklerManager
    {

    }
}
