//using Ikra_Is_Yonetim._3rdApp.Invoicer.InvoicerGenerator;
using Ikra_Is_Yonetim.BL.MaasManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Ninject;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.PersonellerManager;

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Maaslar
{
    public partial class frmMaasOdemsi :KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IPersonellerManager _personal;
        private IMaasManager _maas;
        private Guid _id { get; set; }
        public frmMaasOdemsi(Guid id)
        {
            InitializeComponent();
            _id = id;
            _personal = kernel.Get<IPersonellerManager>();
            _maas = kernel.Get<IMaasManager>();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            DAL.EntityFramework.Tables.Personeller 
                personal = _personal.Find(_id);
            if (personal!=null)
            {
                decimal kesintiler = 0;
                
                IEnumerable<DAL.EntityFramework.Tables.Avanslar>
                    avanslars = _maas.CalcAvans(personal.Id);
                IEnumerable<DAL.EntityFramework.Tables.Izinler> izinlers = _maas.CalcIzin(personal.Id);
                DateTime sonMaasTarih = _maas.CalcMaas(personal.Id);
                decimal gunlukUcret = _maas.CalcGunlukUcret(personal.Id);
                adsoyad.Text = personal.AdSoyad;
                sonmaastarih.Text = sonMaasTarih.Date.ToShortDateString();
                string kesintiText = string.Empty;
                foreach (var item in izinlers)
                {
                    kesintiText = $"İzin tarihi:{item.IzinTarihi.Date.ToShortDateString()}" +
                        $"- İzin süresi : {(item.IzinSuresi - item.IzinTarihi).Days} gün\n";
                    izinRich.Text += kesintiText;
                    TimeSpan gunFarki = item.IzinSuresi - item.IzinTarihi;
                    kesintiler += gunFarki.Days * gunlukUcret;
                }
                string avansText = string.Empty;
                foreach (var item in avanslars)
                {
                    avansText = $"Avans tarihi:{item.AvansTarihi} - ₺{item.AvansTutari}\n";
                    avansRich.Text += avansText;
                    kesintiler += item.AvansTutari;
                }
                decimal maasTutari = 
                    (DateTime.Now.Date - sonMaasTarih.Date)
                    .Days * gunlukUcret;
                gunSayisi.Text = $"{(DateTime.Now.Date - sonMaasTarih.Date).Days} iş günü X {gunlukUcret.ToString("0.00")} ₺";
                netMaas.Text = $"₺ {(maasTutari - kesintiler)}";

            }
           
        }
       

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MaasManager manager = new MaasManager(new EFMaasManager());
            manager.MaasInvoice(_id);
        }
    }
}
