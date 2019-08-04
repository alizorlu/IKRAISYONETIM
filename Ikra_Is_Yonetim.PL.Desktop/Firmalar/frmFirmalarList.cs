using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.FirmalarManager;
using Ikra_Is_Yonetim.BL.Ninject;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Firmalar
{
    public partial class frmFirmalarList : KryptonForm
    {
        private StandardKernel kernel = SingletonKernelManager.Instance;
        private IFirmalarManager _firma;
        internal  DAL.EntityFramework.Tables.Firmalar _selected;
        public frmFirmalarList()
        {
            InitializeComponent();
            _firma = kernel.Get<IFirmalarManager>();
            firmalarBindingSource.DataSource = _selected;
        }
        public void ListeYenile()
        {
            IEnumerable<DAL.EntityFramework.Tables.Firmalar>
                result = _firma.All();
            firmaListBox.DataSource = result;
            firmaListBox.DisplayMember = "FirmaAdi";
        }
        protected override void OnActivated(EventArgs e)
        {
            ListeYenile();
        }
        protected override void OnLoad(EventArgs e)
        {
            ListeYenile();
        }
        private void YeniFirmaBtn_Click(object sender, EventArgs e)
        {
            Add.frmYeniFirma addFirma = new Add.frmYeniFirma();
            addFirma.Show();
        }

        private void FirmaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firmaListBox.SelectedIndex != -1)
            {
                _selected = (DAL.EntityFramework.Tables.Firmalar)
                    firmaListBox.SelectedItem;

                firmalarBindingSource.DataSource = _selected;
                firmaViewTab.Visible = true;
                topDuzenleBtn.Enabled = true;
            }
            else firmaViewTab.Visible = false;
        }

        private void TopDuzenleBtn_Click(object sender, EventArgs e)
        {
            _firma.Update(_selected);
            ListeYenile();
            topDuzenleBtn.Enabled = false;
            firmalarBindingSource.ResetBindings(true);
        }
    }
}
