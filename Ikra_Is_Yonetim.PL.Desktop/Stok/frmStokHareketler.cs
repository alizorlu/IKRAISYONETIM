using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.StoklarManager;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Stok
{
    public partial class frmStokHareketler : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private IStoklarManager _stok;
        private Guid _stokId;
        public frmStokHareketler(Guid stokid)
        {
            InitializeComponent();
            _stok = kernel.Get<IStoklarManager>();
            _stokId = stokid;
        }
        void ListeYukle()
        {
            List<DAL.EntityFramework.Tables.Malzeme> result 
                = _stok.Find(_stokId).Malzemeler.ToList();
            stokHareketlerGrid.DataSource =
                result.Select(s=>new {
                    Üretim=$"Kullanım Sebebi:{s.Yemek.YemekAdi} üretimi için \t| Yemek Üretim Tarihi:{s.Yemek.UretimZamani.Date.ToShortDateString()}",
                   Kullanım=$"{s.KullanimKg} kg",
                   Tarih= $"{s.KullanimTarihi.Date.ToShortDateString()}",
                }).ToList();
            stokHareketlerGrid.Columns["Üretim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stokHareketlerGrid.Columns["Kullanım"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stokHareketlerGrid.Columns["Tarih"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        protected override void OnActivated(EventArgs e)
        {
            ListeYukle();
        }
    }
}
