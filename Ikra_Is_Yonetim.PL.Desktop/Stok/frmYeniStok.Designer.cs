namespace Ikra_Is_Yonetim.PL.Desktop.Stok
{
    partial class frmYeniStok
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
            this.stokAdiTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.stoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stokKg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stokTutari = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hataList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(416, 48);
            this.menuStrip1.TabIndex = 2;
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
            this.closeBtn.Size = new System.Drawing.Size(161, 44);
            this.closeBtn.Text = "Stoklar Listesine Dön";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stokAdiTxt
            // 
            this.stokAdiTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.stoklarBindingSource, "StokAdi", true));
            this.stokAdiTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stoklarBindingSource, "StokAdi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stokAdiTxt.Location = new System.Drawing.Point(24, 118);
            this.stokAdiTxt.Name = "stokAdiTxt";
            this.stokAdiTxt.Size = new System.Drawing.Size(368, 27);
            this.stokAdiTxt.TabIndex = 3;
            this.stokAdiTxt.TextChanged += new System.EventHandler(this.StokAdiTxt_TextChanged);
            // 
            // stoklarBindingSource
            // 
            this.stoklarBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Stoklar);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 88);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 24);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Stok Adı";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(24, 153);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(157, 24);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Stok Giriş Miktarı(KG)";
            // 
            // stokKg
            // 
            this.stokKg.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.stoklarBindingSource, "StokKgBirimAlinan", true));
            this.stokKg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stoklarBindingSource, "StokKgBirimAlinan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.stokKg.Location = new System.Drawing.Point(24, 183);
            this.stokKg.Name = "stokKg";
            this.stokKg.Size = new System.Drawing.Size(368, 27);
            this.stokKg.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 218);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 24);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Stok Tutarı(₺)";
            // 
            // stokTutari
            // 
            this.stokTutari.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.stoklarBindingSource, "StokTutari", true));
            this.stokTutari.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stoklarBindingSource, "StokTutari", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.stokTutari.Location = new System.Drawing.Point(24, 248);
            this.stokTutari.Name = "stokTutari";
            this.stokTutari.Size = new System.Drawing.Size(368, 27);
            this.stokTutari.TabIndex = 7;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 371);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.warning1;
            this.kryptonLabel4.Values.Text = "Hata Listesi";
            // 
            // hataList
            // 
            this.hataList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.hataList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hataList.Location = new System.Drawing.Point(0, 401);
            this.hataList.Name = "hataList";
            this.hataList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.hataList.Size = new System.Drawing.Size(416, 154);
            this.hataList.TabIndex = 12;
            // 
            // frmYeniStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 555);
            this.Controls.Add(this.hataList);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.stokTutari);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.stokKg);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.stokAdiTxt);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Stok Tanımı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stokAdiTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stokKg;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox stokTutari;
        private System.Windows.Forms.BindingSource stoklarBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox hataList;
    }
}