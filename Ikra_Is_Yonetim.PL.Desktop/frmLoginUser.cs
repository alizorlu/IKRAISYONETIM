using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.KullaniciManager;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.Utilities.HashManager;
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
    public partial class frmLoginUser : KryptonForm
    {
        StandardKernel _kernel = new StandardKernel();
        private IKullaniciManager _kullaniciManager;
        private IHashManager _hashManager;
        public static Kullanicilar _selected { get; set; } = null;
        public static Kullanicilar _login { get; set; } = null;
        public frmLoginUser()
        {
            InitializeComponent();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _kullaniciManager = _kernel.Get<IKullaniciManager>();
            _hashManager = _kernel.Get<IHashManager>();
        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
         
        }

        private void btnViewUserList_Click(object sender, EventArgs e)
        {
            frmLoginUserList list = new frmLoginUserList();
            //list.ShowDialog();
            if (list.ShowDialog()==DialogResult.OK)
            {

            }
            else
            {
                if (_selected != null)
                {
                    usernameTxt.Text = _selected.UserName;
                    passTxt.Focus();
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTxt.Text))
            {
                if (!string.IsNullOrEmpty(passTxt.Text))
                {
                    string hashPass = _hashManager.Create(passTxt.Text);
                    Kullanicilar query
                        = _kullaniciManager.Query(usernameTxt.Text, hashPass);
                    if (query==null)
                    {
                        MessageBox.Show("Hata giriş bilgisi girdiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        usernameTxt.Clear();
                        _selected = null;
                        passTxt.Clear();
                        usernameTxt.Focus();
                    }
                    else
                    {
                        _login = query;
                        frmHome home = new frmHome();
                        home.ShowDialog();
                    }
                }
            }
        }
    }
}
