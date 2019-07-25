using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.PersonellerManager;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Personeller
{
    public partial class frmPersonellerList : KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IPersonellerManager _personel;
        internal DAL.EntityFramework.Tables.Personeller _selected;
        
        public frmPersonellerList()
        {
            InitializeComponent();
            _personel = kernel.Get<IPersonellerManager>();
        }
        public void Yenile()
        {
           
            personalListbox.DataSource = _personel.All();
            personalListbox.DisplayMember = "AdSoyad";
            if (personalListbox.Items.Count>0)
            {
                personelViewTab.Visible = true;
                _selected = (DAL.EntityFramework.Tables.Personeller)
                   personalListbox.SelectedItem;
                personellerBindingSource.DataSource = _selected;
                topDuzenleBtn.Enabled = true;
                topSilBtn.Enabled = true;
            }
            else
            {
                personelViewTab.Visible = false;
                topDuzenleBtn.Enabled = false;
                topSilBtn.Enabled = false;
            }
            guncellbl.Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            Yenile(); 
        }
        private void yeniPersonelBtn_Click(object sender, EventArgs e)
        {
            frmYeniPersonel yeni = new frmYeniPersonel(OperasyonelIslem.Yeni);
            yeni.Show();
            yeni.FormClosing += Yeni_FormClosing;
            
        }

        private void Yeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Yenile();
        }

        private void personalListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personalListbox.Items.Count>0)
            {
                _selected = (DAL.EntityFramework.Tables.Personeller)
                    personalListbox.SelectedItem;
                personellerBindingSource.DataSource = _selected;
                duzenleBtn.Enabled = true;
                topDuzenleBtn.Enabled = true;
                
            }
        }

        private void yeniPersonelBtn_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (_selected!=null)
            {
                _personel.Delete((Guid)_selected.Id);
                personellerBindingSource.ResetBindings(true);
                Yenile();
            }
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            if (_selected!=null)
            {
                _personel.Update(_selected);
                guncellbl.Visible = true;
                duzenleBtn.Enabled = false;
                topDuzenleBtn.Enabled = false;
            }
        }

        private void frmPersonellerList_Load(object sender, EventArgs e)
        {
            personellerBindingSource.CurrencyManager.Position = 0;
        }

        private void topDuzenleBtn_Click(object sender, EventArgs e)
        {
            duzenleBtn_Click(sender, e);
        }

        private void topSilBtn_Click(object sender, EventArgs e)
        {
            silBtn_Click(sender, e);
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
