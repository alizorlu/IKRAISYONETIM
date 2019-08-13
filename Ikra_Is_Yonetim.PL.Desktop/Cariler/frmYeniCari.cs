using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.CarilerManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.PL.Desktop.UI;
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

namespace Ikra_Is_Yonetim.PL.Desktop.Cariler
{
    public partial class frmYeniCari : KryptonForm
    {
        private static StandardKernel kernel = SingletonKernelManager.Instance;
        private ICarilerManager _cari;
        private Musteriler _cariModel = new Musteriler();
        public frmYeniCari()
        {
            InitializeComponent();
            _cari = kernel.Get<ICarilerManager>();
            musterilerBindingSource.AllowNew = true;
            musterilerBindingSource.DataSource = _cariModel;
        }
        void HataListesiTemizle() => this.hataList.Items.Clear();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            CariValidator validator = new CariValidator();
            FluentValidation.Results.ValidationResult
              result = validator.Validate(_cariModel);
            if (result.IsValid==false)
            {
                HataListesiTemizle();
                foreach (var item in result.Errors)
                {
                    hataList.Items.Add($"{item.ErrorCode}:\t{item.ErrorMessage}");
                }
            }
            else
            {
                HataListesiTemizle();
                _cariModel.LastLogin = _cariModel.KayitTarihi;
                _cari.Insert(_cariModel);
                _cariModel = new Musteriler();
                musterilerBindingSource.AllowNew = true;
                musterilerBindingSource.DataSource = _cariModel;
                MessageBox.Show("Cari başarıyla kaydedildi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }
        }
    }
}
