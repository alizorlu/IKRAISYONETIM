using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.MalzemeManager
{
    public interface IMalzemeMananager
    {
        IEnumerable<Malzeme> All();
        IEnumerable<Malzeme> All(Guid yemekid);
        IEnumerable<Malzeme> All(Guid ?stokid);
        void Insert(Malzeme malzeme);
        void Update(Malzeme malzeme);
        void Delete(Guid id);
        Malzeme Find(Guid id);
        decimal UretimMaaliyetHesabi(List<Malzeme> malzemeler);
    }
    public class EFMalzemeManager : IMalzemeMananager
    {
        private UnitOfRepo _repo;
        public EFMalzemeManager()
        {
            _repo = new UnitOfRepo();
        }
        public IEnumerable<Malzeme> All()
        {
            return _repo.malzemeRepository.Get();
        }

        public IEnumerable<Malzeme> All(Guid yemekid)
        {
            return _repo.malzemeRepository.Get(sa => sa.Yemek.YemekId == yemekid);
        }

        public IEnumerable<Malzeme> All(Guid? stokid)
        {
            if (stokid != null && stokid.Value.ToString().Length > 12)
            {
                return _repo.
                    malzemeRepository.Get(s => s.Stok.StokId == stokid);
            }
            else return null;
        }

        public void Delete(Guid id)
        {
            _repo.malzemeRepository.Delete(id);
            _repo.Save();
        }

        public Malzeme Find(Guid id)
        {
            return _repo.malzemeRepository.GetById(id);
        }

        public void Insert(Malzeme malzeme)
        {
            _repo.malzemeRepository.Insert(malzeme);
            _repo.Save();
        }

        public void Update(Malzeme malzeme)
        {
            _repo.malzemeRepository.Update(malzeme);
            _repo.Save();
        }

        public decimal UretimMaaliyetHesabi(List<Malzeme> malzemeler)
        {
            decimal total = 0m;
            foreach (var item in malzemeler)
            {
                decimal kgTutari = item.Stok.StokTutari / item.Stok.StokKgBirimAlinan;
                total += total + (kgTutari * item.KullanimKg);
            }
            return total;
        }
    }
    class MalzemeManager
    {
    }
}
