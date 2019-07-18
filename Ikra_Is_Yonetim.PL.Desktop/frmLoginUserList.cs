using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop
{
    public partial class frmLoginUserList : KryptonForm
    {
        StandardKernel _kernel = new StandardKernel();
        private IKullaniciManager _kullaniciManager;
       
        public frmLoginUserList()
        {
           
            InitializeComponent();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _kullaniciManager = _kernel.Get<IKullaniciManager>();
        }
        public void FillList()
        {
           
            userList.DataSource = _kullaniciManager.AllAdmin().ToList();
            userList.Columns[0].Visible = false;
            userList.Columns[1].Visible = false;
            userList.Columns[2].Visible = false;
            userList.Columns[3].Visible = false;
            userList.Columns[4].Visible = false;
            userList.Columns[5].Visible = false;
            userList.Columns[6].Visible = false;
            userList.Columns[7].Visible = false;
            userList.Columns[8].Visible = false;
            userList.Columns[9].Visible = false;
            userList.Columns["UserName"].Visible = true;
            userList.Columns["Address"].Visible = false;
            userList.Columns["MealCount"].Visible = false;
        }
        protected override void OnActivated(EventArgs e)
        {
            FillList();
        }

        private void userList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Kullanicilar selected =
                (Kullanicilar)userList.
                SelectedRows[e.RowIndex]
                .DataBoundItem;
                frmLoginUser._selected = selected;
                this.Close();
            }
            catch (Exception)
            {


            }


        }

        private void userList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void userList_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void userList_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Kullanicilar selected =
                (Kullanicilar)userList.
                SelectedRows[e.RowIndex]
                .DataBoundItem;
                frmLoginUser._selected = selected;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void userList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Kullanicilar selected =
                (Kullanicilar)userList.
                SelectedRows[e.RowIndex]
                .DataBoundItem;
                frmLoginUser._selected = selected;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void userList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Kullanicilar selected =
                (Kullanicilar)userList.
                SelectedRows[e.RowIndex]
                .DataBoundItem;
                frmLoginUser._selected = selected;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void userList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Kullanicilar selected =
                (Kullanicilar)userList.
                SelectedRows[e.RowIndex]
                .DataBoundItem;
                frmLoginUser._selected = selected;
                this.Close();
            }
            catch (Exception)
            {


            }
        }

        private void userList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
