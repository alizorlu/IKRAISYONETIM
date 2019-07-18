using Ikra_Is_Yonetim.BL.KullaniciManager;
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
    public partial class Form1 : Form
    {
        StandardKernel _kernel = new StandardKernel();
        private IKullaniciManager _kullaniciManager;
        public Form1()
        {
            InitializeComponent();
            _kernel.Load(Assembly.GetExecutingAssembly());
            _kullaniciManager = _kernel.Get<IKullaniciManager>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show(_kullaniciManager.All().Count().ToString());

        }
    }
}
