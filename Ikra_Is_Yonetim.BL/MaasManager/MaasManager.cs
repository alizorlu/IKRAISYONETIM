using Ikra_Is_Yonetim.BL.AvanslarManager;
using Ikra_Is_Yonetim.BL.IzinlerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.PersonellerManager;
using Ikra_Is_Yonetim.BL.SirketManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
//using Ikra_Is_Yonetim.Utilities.ImageBinaryDataManager;
using Invoicer.Models;
using Invoicer.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.BL.MaasManager
{
    public interface IMaasManager
    {
        IEnumerable<Maaslar> All();
        IEnumerable<Maaslar> All(Guid personalid);
        decimal CalcGunlukUcret(Guid personalid);
        DateTime CalcMaas(Guid personalid);
        IEnumerable<Avanslar> CalcAvans(Guid personalid);
        IEnumerable<Izinler> CalcIzin(Guid personalid);

        void Insert(Maaslar model);
        void MaasInvoice(Guid personalid);
    }
    public class EFMaasManager : IMaasManager
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IAvansManager _avans;
        private IizinlerManager _izin;
        private IPersonellerManager _personel;
        private UnitOfRepo _repo;
        private ISirketManager _sirket;
        //private IImageBinaryDataManager _image;
        public EFMaasManager()
        {
            _repo = new UnitOfRepo();
            _avans = kernel.Get<IAvansManager>();
            _izin = kernel.Get<IizinlerManager>();
            _personel = kernel.Get<IPersonellerManager>();
            _sirket = kernel.Get<ISirketManager>();
            //_image = kernel.Get<IImageBinaryDataManager>();
        }
        public IEnumerable<Maaslar> All()
        {
            return _repo.maasRepository.Get();
        }

        public IEnumerable<Maaslar> All(Guid personalid)
        {
            return _repo.maasRepository.Get(s => s.PersonelId == personalid);
        }

        public IEnumerable<Avanslar> CalcAvans(Guid personalid)
        {
            return _avans.All(personalid)
                .Where(s => s.MaastanDusulduMu == false)
                ;
        }

        public decimal CalcGunlukUcret(Guid personalid)
        {
            //var finded = _personel.Find(personalid);
            return _personel.Find(personalid).ToplamMaasi / 30;
        }

        public IEnumerable<Izinler> CalcIzin(Guid personalid)
        {
            return _izin.All(personalid)
                .Where(s => s.MaastanDusurulduMu == false);
        }

        /// <summary>
        /// Çalıştığı günü hesaplayıp döner
        /// </summary>
        /// <param name="personalid"></param>
        /// <returns></returns>
        public DateTime CalcMaas(Guid personalid)
        {
            //1.Daha önce maaş ödendiyse o tarihten itibareni hesapla.
            //2.Hiç maaş ödenmemişse giriş tarihinden itibaren hesapla.
            var maasQuery = All(personalid);
            if (maasQuery.Count() > 0)
            {
                var sontarih = maasQuery.OrderByDescending(sa => sa.SonMaasDonemTarihi);
                //TimeSpan fark = DateTime.Now - sontarih.First().SonMaasDonemTarihi;
                //return fark.Days;
                return sontarih.First().SonMaasDonemTarihi;
            }
            else
            {
                var girisTarihi = _personel.Find(personalid).GirisZamani;
                return girisTarihi;
            }
        }

        public void Insert(Maaslar model)
        {
            _repo.maasRepository.Insert(model);
            _repo.Save();
        }

        public void MaasInvoice(Guid personalid)
        {
            Guid fatid = Guid.NewGuid();
            Personeller personal = _personel.Find(personalid);
            SirketBilgiTB sirket = _sirket.Find();
            IEnumerable<Izinler> izinler = CalcIzin(personalid);
            IEnumerable<Avanslar> avanslar = CalcAvans(personalid);
            decimal gunlukUcret = CalcGunlukUcret(personalid);

            DateTime sonMaasTarihi = CalcMaas(personalid);
            int toplamCalismaGunu = (
                DateTime.Now - sonMaasTarihi).Days;
            decimal maas = toplamCalismaGunu * gunlukUcret;
            decimal kesintiler = 0;
            List<ItemRow> aciklamalar = new List<ItemRow>();
            foreach (var item in izinler)
            {
                var izinSuresi = item.IzinSuresi - item.IzinTarihi;
                aciklamalar.Add(
               ItemRow.Make("İZİN", $"Izin kesintisi-{item.IzinTarihi.Date.ToShortDateString()} alından {izinSuresi.Days.ToString()} günlük izin ", izinSuresi.Days, 0, gunlukUcret, gunlukUcret * izinSuresi.Days));
                kesintiler += gunlukUcret * izinSuresi.Days;
            }
            foreach (var item in avanslar)
            {
                aciklamalar.Add(ItemRow.Make("AVANS", $"Avans kesintisi - {item.AvansTarihi.Date.ToShortDateString()}", 1, 0, item.AvansTutari, item.AvansTutari));
                kesintiler += item.AvansTutari;
            }

            aciklamalar.Add(ItemRow.Make("MAAŞ BİLGİSİ", $"Günlük çalışma ücreti {gunlukUcret}", toplamCalismaGunu, 0, gunlukUcret, maas));

            new InvoicerApi(SizeOption.A4, OrientationOption.Landscape, "₺")
          .TextColor("#8C2234")
             .BackColor("#FFD6CC").Title($"{sirket.Name} Personel Maaş Faturası")
             .Image(sirket.Logo, 127, 85)
              .Company(Address.Make($"ÖDEME YAPAN", new string[] { sirket.Name, sirket.Phone,sirket.VATNo,sirket.Address }, sirket.Name, sirket.VATNo))
              .Client(Address.Make("ÖDEME ALAN", new string[] { $"Adı Soyadı :{personal.AdSoyad}",$"Görevi :{personal.Gorevi}",$"Telefon :{personal.Telefon}" }))
             .Items(aciklamalar)
             .Totals(new List<TotalRow> {
        TotalRow.Make("KESİNTİLER", -kesintiler),
        TotalRow.Make("GÜN BAŞINA ÇALIŞMA", maas),
        TotalRow.Make("TOPLAM KESİN ÜCRET(MAAŞ)", maas-kesintiler, true),
 })
             .Details(new List<DetailRow> {
        DetailRow.Make("Maaş ödeme faturası",
        "Personel maaş bordrosu yerine kullanılabilir.",
        "",
        $"Ek bu fatura,İkra yemek fabrikası çalışanı {personal.AdSoyad} 'ın maaş ödemesinin yapıldığını gösterir.Çeşitli nedenlerle kesintileri varsa bu faturada belirtilir.")
 })
             .Footer("http://www.ikrayemek.com.tr").Reference(fatid.ToString().Substring(0,32))
                 .Save();
            Maaslar yeniMaasOdemesi = new Maaslar();
            yeniMaasOdemesi.Id = fatid;
            yeniMaasOdemesi.PersonelId = personalid;
            yeniMaasOdemesi.OdemeTutari = maas - kesintiler;
            yeniMaasOdemesi.SonMaasDonemTarihi = DateTime.Now;
            yeniMaasOdemesi.FaturaId = fatid.ToString().Substring(0, 32);
            yeniMaasOdemesi.Odendi = true;
            Insert(yeniMaasOdemesi);
            foreach (var item in izinler)
            {
                item.MaastanDusurulduMu = true;
                _izin.Update(item);
            }
            foreach (var item in avanslar)
            {
                item.MaastanDusulduMu = true;
                _avans.Update(item);
            }
            
        }
    }
    public class MaasManager :IMaasManager
    {
        private IMaasManager _manager;
        public MaasManager(IMaasManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Maaslar> All()
        {
            return _manager.All();
        }

        public IEnumerable<Maaslar> All(Guid personalid)
        {
            return All(personalid);
        }

        public IEnumerable<Avanslar> CalcAvans(Guid personalid)
        {
            return _manager.CalcAvans(personalid);
        }

        public decimal CalcGunlukUcret(Guid personalid)
        {
            return _manager.CalcGunlukUcret(personalid);
        }

        public IEnumerable<Izinler> CalcIzin(Guid personalid)
        {
            return _manager.CalcIzin(personalid);
        }

        public DateTime CalcMaas(Guid personalid)
        {
            return _manager.CalcMaas(personalid);
        }

        public void Insert(Maaslar model)
        {
            _manager.Insert(model);
        }

        public void MaasInvoice(Guid personalid)
        {
            _manager.MaasInvoice(personalid);
        }
    }
}
