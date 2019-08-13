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

namespace Ikra_Is_Yonetim.PL.Desktop.Stok
{
    public partial class frmStoklarList : KryptonForm
    {
        private StandardKernel
            kernel = SingletonKernelManager.Instance;
        private IStoklarManager _stok;
        private Stoklar _selectedStok { get; set; }
        = null;
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
            stoklarDataGridView.Columns["StokId"].Visible = false;
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

        private void StoklarDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (true)
                {
                    //MessageBox.Show("Test");
                    Stoklar stok = (Stoklar)stoklarDataGridView.Rows[e.RowIndex]
                        .DataBoundItem;
                    _selectedStok = stok;

                }
            }
            catch (Exception)
            {

                //
            }
        }

        private void HareketlerBtn_Click(object sender, EventArgs e)
        {
            if (_selectedStok!=null)
            {
                frmStokHareketler hareketler = new frmStokHareketler(_selectedStok.StokId);
                hareketler.Show();
            }
        }

        private void StoklarDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (stoklarDataGridView.SelectedRows.Count>0)
            {
                Stoklar stok = (Stoklar)
                    stoklarDataGridView.SelectedRows[0].DataBoundItem;
                _selectedStok = stok;
            }
        }

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
