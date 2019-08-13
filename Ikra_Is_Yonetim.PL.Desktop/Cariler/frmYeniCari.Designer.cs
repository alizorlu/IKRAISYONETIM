namespace Ikra_Is_Yonetim.PL.Desktop.Cariler
{
    partial class frmYeniCari
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kaydetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.firmaEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaYemekSayisi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firmaTelefon = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firmaYemekUcret = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firmaYemekAdresi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firmaAd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hataList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(641, 48);
            this.menuStrip1.TabIndex = 23;
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
            this.closeBtn.Size = new System.Drawing.Size(110, 44);
            this.closeBtn.Text = "Cariler Listesi";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 87);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 24);
            this.kryptonLabel2.TabIndex = 24;
            this.kryptonLabel2.Values.Text = "Firma Adı";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 152);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(137, 24);
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Firma Email Adresi";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 216);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(184, 24);
            this.kryptonLabel3.TabIndex = 28;
            this.kryptonLabel3.Values.Text = "Günlük(Kişi) Yemek Sayısı";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 281);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(345, 24);
            this.kryptonLabel4.TabIndex = 30;
            this.kryptonLabel4.Values.Text = "Firma Telefon(*Giriş bilgisinde kullanılacaktır)";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 355);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(181, 24);
            this.kryptonLabel5.TabIndex = 32;
            this.kryptonLabel5.Values.Text = "1 Kişilik Yemek Ücreti(TL)";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 417);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(96, 24);
            this.kryptonLabel6.TabIndex = 34;
            this.kryptonLabel6.Values.Text = "Firma Adresi";
            // 
            // firmaEmail
            // 
            this.firmaEmail.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "Email", true));
            this.firmaEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firmaEmail.Location = new System.Drawing.Point(12, 182);
            this.firmaEmail.Name = "firmaEmail";
            this.firmaEmail.Size = new System.Drawing.Size(617, 27);
            this.firmaEmail.TabIndex = 1;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Musteriler);
            // 
            // firmaYemekSayisi
            // 
            this.firmaYemekSayisi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "GunlukYemekSayisi", true));
            this.firmaYemekSayisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "GunlukYemekSayisi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.firmaYemekSayisi.Location = new System.Drawing.Point(12, 246);
            this.firmaYemekSayisi.Name = "firmaYemekSayisi";
            this.firmaYemekSayisi.Size = new System.Drawing.Size(617, 27);
            this.firmaYemekSayisi.TabIndex = 2;
            // 
            // firmaTelefon
            // 
            this.firmaTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "Telefon", true));
            this.firmaTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Telefon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firmaTelefon.Location = new System.Drawing.Point(12, 311);
            this.firmaTelefon.Name = "firmaTelefon";
            this.firmaTelefon.Size = new System.Drawing.Size(617, 27);
            this.firmaTelefon.TabIndex = 3;
            // 
            // firmaYemekUcret
            // 
            this.firmaYemekUcret.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "GunlukYemekFiyati", true));
            this.firmaYemekUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "GunlukYemekFiyati", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.firmaYemekUcret.Location = new System.Drawing.Point(12, 385);
            this.firmaYemekUcret.Name = "firmaYemekUcret";
            this.firmaYemekUcret.Size = new System.Drawing.Size(617, 27);
            this.firmaYemekUcret.TabIndex = 4;
            // 
            // firmaYemekAdresi
            // 
            this.firmaYemekAdresi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "FirmaAdres", true));
            this.firmaYemekAdresi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "FirmaAdres", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firmaYemekAdresi.Location = new System.Drawing.Point(12, 447);
            this.firmaYemekAdresi.Multiline = true;
            this.firmaYemekAdresi.Name = "firmaYemekAdresi";
            this.firmaYemekAdresi.Size = new System.Drawing.Size(617, 86);
            this.firmaYemekAdresi.TabIndex = 5;
            // 
            // firmaAd
            // 
            this.firmaAd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.musterilerBindingSource, "FirmaAdSoyad", true));
            this.firmaAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "FirmaAdSoyad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firmaAd.Location = new System.Drawing.Point(12, 119);
            this.firmaAd.Name = "firmaAd";
            this.firmaAd.Size = new System.Drawing.Size(617, 27);
            this.firmaAd.TabIndex = 0;
            // 
            // hataList
            // 
            this.hataList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.hataList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hataList.Location = new System.Drawing.Point(0, 621);
            this.hataList.Name = "hataList";
            this.hataList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.hataList.Size = new System.Drawing.Size(641, 154);
            this.hataList.TabIndex = 42;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 591);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel7.TabIndex = 41;
            this.kryptonLabel7.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.warning1;
            this.kryptonLabel7.Values.Text = "Hata Listesi";
            // 
            // frmYeniCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 775);
            this.Controls.Add(this.hataList);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.firmaAd);
            this.Controls.Add(this.firmaYemekAdresi);
            this.Controls.Add(this.firmaYemekUcret);
            this.Controls.Add(this.firmaTelefon);
            this.Controls.Add(this.firmaYemekSayisi);
            this.Controls.Add(this.firmaEmail);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmYeniCari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Cari Ekleme";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaYemekSayisi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaTelefon;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaYemekUcret;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaYemekAdresi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaAd;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox hataList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
    }
}