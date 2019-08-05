namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    partial class frmEkleMalzeme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stokSecimTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.malzemeEkleBtn = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kullanGr = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.hataList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kaydetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(196, 24);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Kullanılabilir stok seçiniz(...)";
            // 
            // stokSecimTxt
            // 
            this.stokSecimTxt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.malzemeEkleBtn});
            this.stokSecimTxt.Location = new System.Drawing.Point(12, 99);
            this.stokSecimTxt.Name = "stokSecimTxt";
            this.stokSecimTxt.ReadOnly = true;
            this.stokSecimTxt.Size = new System.Drawing.Size(856, 32);
            this.stokSecimTxt.TabIndex = 9;
            // 
            // malzemeEkleBtn
            // 
            this.malzemeEkleBtn.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.malzemeEkleBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.gozat;
            this.malzemeEkleBtn.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.malzemeEkleBtn.Text = "Ekle";
            this.malzemeEkleBtn.UniqueName = "9D8BDA1726AD4043BA9BC752A5501260";
            this.malzemeEkleBtn.Click += new System.EventHandler(this.MalzemeEkleBtn_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 149);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(264, 24);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Stoktan kullanım miktarını giriniz(KG)";
            // 
            // kullanGr
            // 
            this.kullanGr.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.malzemeBindingSource, "KullanimKg", true));
            this.kullanGr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "KullanimKg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.kullanGr.Location = new System.Drawing.Point(12, 179);
            this.kullanGr.Name = "kullanGr";
            this.kullanGr.Size = new System.Drawing.Size(856, 27);
            this.kullanGr.TabIndex = 13;
            this.kullanGr.Validated += new System.EventHandler(this.KullanGr_Validated);
            // 
            // hataList
            // 
            this.hataList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.hataList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hataList.Location = new System.Drawing.Point(0, 331);
            this.hataList.Name = "hataList";
            this.hataList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.hataList.Size = new System.Drawing.Size(880, 154);
            this.hataList.TabIndex = 21;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 301);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel5.TabIndex = 20;
            this.kryptonLabel5.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.warning1;
            this.kryptonLabel5.Values.Text = "Hata Listesi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBtn,
            this.closeBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(880, 48);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.save;
            this.kaydetBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kaydetBtn.Size = new System.Drawing.Size(69, 44);
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.house;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.closeBtn.Size = new System.Drawing.Size(100, 44);
            this.closeBtn.Text = "Tanıma dön";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Malzeme);
            // 
            // frmEkleMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(880, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.hataList);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kullanGr);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.stokSecimTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEkleMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Ekle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stokSecimTxt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny malzemeEkleBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox kullanGr;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox hataList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
    }
}