using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.StoklarManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    public partial class frmListStok : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager
            .Instance;
        private IStoklarManager _stok;
        public frmListStok()
        {
            InitializeComponent();
            _stok = kernel.Get<IStoklarManager>();
        }
        void Listele()
        {
            ICollection<Malzeme> sa = frmYeniYemekler.yemekModel.Malzemeler;

            List<DAL.EntityFramework.Tables.Stoklar> result = 
                _stok.All().ToList();
          
            stokDataGridView.
                DataSource = result;
            stokDataGridView.Columns["Id"].Visible = false;
            stokDataGridView.Columns["Id"].Visible = false;
            stokDataGridView.Columns["StokTutari"].Visible = false;
            stokDataGridView.Columns["StokKgBirimAlinan"].Visible = false;
            stokDataGridView.Columns["AlisTarihi"].Visible = false;
            stokDataGridView.Columns["Malzemeler"].Visible = false;
            stokDataGridView.Columns["StokAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void OnActivated(EventArgs e)
        {
            Listele();
        }

        private void StokDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var selected = (Stoklar)
                stokDataGridView.SelectedRows[0].DataBoundItem;
            frmEkleMalzeme._selectedStok
                  = selected;
            this.Close();
        }
    }
}
