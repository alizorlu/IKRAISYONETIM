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
    public partial class frmStoklarList : KryptonForm
    {
        private StandardKernel
kernel = SingletonKernelManager.Instance;
        private IStoklarManager _stok;
        public frmStoklarList()
        {
            InitializeComponent();
            _stok = kernel.Get<IStoklarManager>();
            Listele();
        }
        private void Listele()
        {
            IEnumerable<DAL.EntityFramework.Tables.Stoklar> result
                = _stok.All();
            stoklarDataGridView.DataSource
                = result.ToList();
            stoklarDataGridView.Columns["Id"].Visible = false;
            stoklarDataGridView.Columns["AlisTarihi"].Visible = false;
            stoklarDataGridView.Columns["Malzemeler"].Visible = false;
            stoklarDataGridView.Columns["StokKgBirimAlinan"].Visible = false;
            stoklarDataGridView.Columns["StokAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stoklarDataGridView.Columns["StokTutari"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stoklarDataGridView.Columns["StokKgBirimKalan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //stoklarDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YeniStokBtn_Click(object sender, EventArgs e)
        {
            frmYeniStok yeniStok = new frmYeniStok();
            yeniStok.FormClosing += YeniStok_FormClosing;
            yeniStok.Show();
        }

        private void YeniStok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Listele();
        }

        private void YenileBtn_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
