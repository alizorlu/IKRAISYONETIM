namespace Ikra_Is_Yonetim.PL.Desktop.Firmalar.Add
{
    partial class frmYeniFirma
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.yetkilisi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.firmaAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addres = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.telefonTxt = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.hataliLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.basariliLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.firmalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(907, 48);
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
            this.closeBtn.Size = new System.Drawing.Size(169, 44);
            this.closeBtn.Text = "Firmalar Listesine Dön";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 588);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.firmalar2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(165, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(821, 64);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "İşlemi";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel8, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.yetkilisi, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.firmaAdi, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addres, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.telefonTxt, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.hataliLbl, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.basariliLbl, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(165, 73);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(821, 512);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(3, 102);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel8.Size = new System.Drawing.Size(114, 164);
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "Adresi";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel2.Size = new System.Drawing.Size(114, 27);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Firma Adı";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel3.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Firma Yetkilisi";
            // 
            // yetkilisi
            // 
            this.yetkilisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "YetkiliKisi", true));
            this.yetkilisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yetkilisi.Location = new System.Drawing.Point(123, 36);
            this.yetkilisi.Name = "yetkilisi";
            this.yetkilisi.Size = new System.Drawing.Size(494, 27);
            this.yetkilisi.TabIndex = 1;
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Firmalar);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 69);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonLabel4.Size = new System.Drawing.Size(114, 27);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Firma Tel No";
            // 
            // firmaAdi
            // 
            this.firmaAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "FirmaAdi", true));
            this.firmaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaAdi.Location = new System.Drawing.Point(123, 3);
            this.firmaAdi.Name = "firmaAdi";
            this.firmaAdi.Size = new System.Drawing.Size(494, 27);
            this.firmaAdi.TabIndex = 0;
            // 
            // addres
            // 
            this.addres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "Adres", true));
            this.addres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addres.Location = new System.Drawing.Point(123, 102);
            this.addres.Multiline = false;
            this.addres.Name = "addres";
            this.addres.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addres.Size = new System.Drawing.Size(494, 164);
            this.addres.TabIndex = 6;
            this.addres.Text = "";
            // 
            // telefonTxt
            // 
            this.telefonTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "Telefon", true));
            this.telefonTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefonTxt.Location = new System.Drawing.Point(123, 69);
            this.telefonTxt.Mask = "(000)-(000)-(0000)";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(494, 27);
            this.telefonTxt.TabIndex = 2;
            this.telefonTxt.Text = "(   )-(   )-(    )";
            // 
            // hataliLbl
            // 
            this.hataliLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.hataliLbl.Location = new System.Drawing.Point(123, 306);
            this.hataliLbl.Name = "hataliLbl";
            this.hataliLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.hataliLbl.Size = new System.Drawing.Size(278, 28);
            this.hataliLbl.TabIndex = 16;
            this.hataliLbl.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.warning;
            this.hataliLbl.Values.Text = "Hata oluştu...Lütfen tekrar deneyiniz";
            this.hataliLbl.Visible = false;
            // 
            // basariliLbl
            // 
            this.basariliLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.basariliLbl.Location = new System.Drawing.Point(123, 272);
            this.basariliLbl.Name = "basariliLbl";
            this.basariliLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.basariliLbl.Size = new System.Drawing.Size(211, 28);
            this.basariliLbl.TabIndex = 16;
            this.basariliLbl.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources._checked;
            this.basariliLbl.Values.Text = "İşlem başarıyla kaydedildi.";
            this.basariliLbl.Visible = false;
            // 
            // firmalarBindingSource1
            // 
            this.firmalarBindingSource1.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Firmalar);
            // 
            // frmYeniFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmYeniFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Firma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox yetkilisi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firmaAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox addres;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox telefonTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel hataliLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel basariliLbl;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
        private System.Windows.Forms.BindingSource firmalarBindingSource1;
    }
}