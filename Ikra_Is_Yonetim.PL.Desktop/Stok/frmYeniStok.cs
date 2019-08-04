using ComponentFactory.Krypton.Toolkit;
using Ikra_Is_Yonetim.BL.KasaManager;
using Ikra_Is_Yonetim.BL.Ninject;
using Ikra_Is_Yonetim.BL.StoklarManager;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Ikra_Is_Yonetim.PL.Desktop.Stok
{
    public partial class frmYeniStok : KryptonForm
    {
        private StandardKernel
            kernel = SingletonKernelManager.Instance;
        private IStoklarManager _stok;
        private IKasaManager _kasa;
        internal Stoklar stokModel = new Stoklar();
        public frmYeniStok()
        {
            InitializeComponent();
            stoklarBindingSource.AllowNew = true;
            stoklarBindingSource.DataSource = stokModel;
            _stok = kernel.Get<IStoklarManager>();
            _kasa = kernel.Get<IKasaManager>();
        }
        void HataTemizle() => hataList.Items.Clear();
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
           
            StokValidator validator = new StokValidator();

            FluentValidation.Results.ValidationResult
                result = validator.Validate(stokModel);
            if (result.IsValid == false)
            {
                HataTemizle();
                foreach (var item in result.Errors)
                {
                    hataList.Items.Add($"{item.ErrorCode}:\t{item.ErrorMessage}");
                }
            }
            else if (result.IsValid)
            {
                HataTemizle();
                _stok.Insert(model: stokModel);
                _kasa.InsertStok(stok: stokModel);
                stokModel = new Stoklar();
                stoklarBindingSource.AllowNew = true;
                stoklarBindingSource.DataSource = stokModel;
                
                MessageBox.Show("Stok başarıyla kaydedildi","Kaydedildi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void StokAdiTxt_TextChanged(object sender, EventArgs e)
        {
            stokModel.StokAdi = stokAdiTxt.Text;
        }

    }
}
