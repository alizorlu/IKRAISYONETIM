using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.PersonellerManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.KasaManager
{
    public interface IKasaManager
    {
        IEnumerable<Kasalar> All();
        IEnumerable<Kasalar> All(string donem);
        void Insert(Kasalar kasa);
        void InsertAvans(Avanslar avans);
        void InsertMaas(Maaslar maas);
        void InsertStok(Stoklar stok);
        IEnumerable<string> Donem();
        
    }
    public class EFKasaManager : IKasaManager
    {
        
        private UnitOfRepo _repo;
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IPersonellerManager _personel;
        public EFKasaManager()
        {
            _repo = new UnitOfRepo();
            _personel = kernel.Get<IPersonellerManager>();
        }
        public IEnumerable<Kasalar> All()
        {
            return _repo.kasaRepository.Get();
        }

        public IEnumerable<Kasalar> All(string donem)
        {
            return _repo.kasaRepository.Get(s => s.Donem.Equals(donem));
        }

        public IEnumerable<string> Donem()
        {
            return _repo.kasaRepository.Get()
                .GroupBy(f => f.Donem).Select(sa => sa.Key);
        }

        public void Insert(Kasalar kasa)
        {
            _repo.kasaRepository.Insert(kasa);
            _repo.Save();
        }

        public void InsertAvans(Avanslar avans)
        {
            Personeller personel = _personel.Find(avans.PersonelId);
            Insert(new Kasalar()
            {
                Id = Guid.NewGuid(),
                Aciklama = $"{personel.AdSoyad} avans:₺{avans.AvansTutari.ToString("0.00")}",
                Donem = DateTime.Now.Year.ToString(),
                IslemTarihi = DateTime.Now,
                IslemTipi = IslemTip.Cikis,
                Miktar = avans.AvansTutari
            });
        }

        public void InsertMaas(Maaslar maas)
        {
            Personeller personel = _personel.Find(maas.PersonelId);
            Insert(new Kasalar() {
                Aciklama=$"{personel.AdSoyad} maaş ödemesi:₺{maas.OdemeTutari.ToString("0.00")}",
                Donem=DateTime.Now.Year.ToString(),
                Id=Guid.NewGuid(),
                IslemTarihi=DateTime.Now,
                IslemTipi=IslemTip.Cikis,
                Miktar=maas.OdemeTutari

            });
        }

        public void InsertStok(Stoklar stok)
        {
            Insert(new Kasalar()
            {
                Aciklama = $"{stok.StokAdi} stok girişi({stok.AlisTarihi}):₺{stok.StokTutari.ToString("0.00")}",
                Donem = DateTime.Now.Year.ToString(),
                Id = Guid.NewGuid(),
                IslemTarihi = DateTime.Now,
                IslemTipi = IslemTip.Cikis,
                Miktar = stok.StokTutari
            });
        }
    }
    public class KasaManager 
    {
        private IKasaManager _manager;
        public KasaManager(IKasaManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Kasalar> All()
        {
            return _manager.All();
        }

        public IEnumerable<Kasalar> All(string donem)
        {
            return _manager.All(donem);
        }

        public IEnumerable<string> Donem()
        {
            return _manager.Donem();
        }

        public void Insert(Kasalar kasa)
        {
            _manager.Insert(kasa);
        }

        public void InsertAvans(Avanslar avans)
        {
            _manager.InsertAvans(avans);
        }

        public void InsertMaas(Maaslar maas)
        {
            _manager.InsertMaas(maas);
        }
    }
}
