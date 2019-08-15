using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.SiparisManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Siparis
{
    public partial class frmSiparislerList : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;

        private ISiparisManager _siparis;
        private static readonly object _siparisLock = new object();
        private static long _sonSiparisSayisi = 0;
        private IEnumerable<Siparisler> _siparislerBackList;
        private Siparisler _selectedSiparis;
        public frmSiparislerList()
        {
            InitializeComponent();
            lock (_siparisLock)
            {
                if(_siparis==null) _siparis = kernel.Get<ISiparisManager>();
            }
           
            siparisTmr.Start();
            _sonSiparisSayisi = _siparis.SiparisSayiControl();
            SiparisLoad();
        }
        void SiparisSayisiControl()
        {
            //string 
            if (_siparis.SiparisSayiControl() == _sonSiparisSayisi)
            {
                
            }
            else
            {

                GC.SuppressFinalize(_siparisLock);
                GC.SuppressFinalize(_siparis);
                lock (_siparisLock)
                {
                    _siparis = kernel.Get<ISiparisManager>();
                }
                SiparisLoad();
                _sonSiparisSayisi = _siparis.SiparisSayiControl();
            }
            this.TextExtra = $"Son sipariş denetimi :{DateTime.Now.ToShortTimeString()}";
        }
        void SiparisLoad()
        {
            IEnumerable<DAL.EntityFramework.Tables.Siparisler> 
                result
                = _siparis.AllToday();
            if (result == null || result.Count() <= 0) return;
            this._siparislerBackList = result;
            siparisDataGridView.DataSource
                =
                result.
                Select(s => new
                {
                    s.Id,
                    
                s.Musteri.FirmaAdSoyad,
                   
                s.YemekSayisi
                })
                .ToList();
            siparisDataGridView.Columns["Id"].Visible = false;
            siparisDataGridView.Columns["FirmaAdSoyad"]
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void SiparisDurumGuncelle(SiparisDurumu durumu)
        {
            if (_selectedSiparis == null) return;
            _siparis.DurumGuncelle(_selectedSiparis.Id, durumu);
            yemeklerBindingSource.ResetBindings(true);
            musterilerBindingSource.ResetBindings(true);
            siparislerBindingSource.ResetBindings(true);

            //-------------------------------------------
            yemeklerBindingSource.DataSource = _selectedSiparis.Yemek;
            musterilerBindingSource.DataSource = _selectedSiparis.Musteri;
            siparislerBindingSource.DataSource = _selectedSiparis;
        }
        private void FrmSiparislerList_Load(object sender, EventArgs e)
        {

        }

        private void SiparisTmr_Tick(object sender, EventArgs e)
        {
            this.Text = $"Siparişler({(siparisTmr.Interval)/60000} dk otomatik denetleniyor...)";
            SiparisSayisiControl();
        }

        private void SiparisDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                Guid result = (Guid)siparisDataGridView.
                    SelectedRows[0].Cells[0].Value;
                if (result == Guid.Empty) return;
                _selectedSiparis = _siparislerBackList.Where(s => s.Id == result)
                    .FirstOrDefault();
                if (_selectedSiparis == null) return;
                yemeklerBindingSource.DataSource = _selectedSiparis.Yemek;
                siparislerBindingSource.DataSource = _selectedSiparis;
                musterilerBindingSource.DataSource = _selectedSiparis.Musteri;

            }
            catch (Exception)
            {


            }
        }

       
        private void KryptonButton2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SiparisDurumGuncelle(SiparisDurumu.Hazırlanıyor);
            this.Enabled = true;
        }

        private void KryptonButton3_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SiparisDurumGuncelle(SiparisDurumu.Yolda);
            this.Enabled = true;
        }

        private void KryptonButton4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SiparisDurumGuncelle(SiparisDurumu.İletildi);
            this.Enabled = true;
        }

        private void KryptonButton5_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SiparisDurumGuncelle(SiparisDurumu.İptal);
            this.Enabled = true;
        }
    }
}
