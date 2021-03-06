﻿namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    partial class frmYeniYemekler
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
            this.porsiyonGr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.yemeklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.yemekAdiTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.UretimDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.malzemeGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.stokEkleBtn = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.stokSilBtn = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.hataList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemeklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(445, 48);
            this.menuStrip1.TabIndex = 8;
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
            this.closeBtn.Size = new System.Drawing.Size(158, 44);
            this.closeBtn.Text = "Yemek Listesine Dön";
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 138);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(149, 24);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "1 Porsiyon Gramajı";
            // 
            // porsiyonGr
            // 
            this.porsiyonGr.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "PorsiyonGr", true));
            this.porsiyonGr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yemeklerBindingSource, "PorsiyonGr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.porsiyonGr.Location = new System.Drawing.Point(26, 168);
            this.porsiyonGr.Name = "porsiyonGr";
            this.porsiyonGr.Size = new System.Drawing.Size(392, 27);
            this.porsiyonGr.TabIndex = 1;
            // 
            // yemeklerBindingSource
            // 
            this.yemeklerBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Yemekler);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 73);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(89, 24);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Yemek Adı";
            // 
            // yemekAdiTxt
            // 
            this.yemekAdiTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "YemekAdi", true));
            this.yemekAdiTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yemeklerBindingSource, "YemekAdi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.yemekAdiTxt.Location = new System.Drawing.Point(26, 103);
            this.yemekAdiTxt.Name = "yemekAdiTxt";
            this.yemekAdiTxt.Size = new System.Drawing.Size(392, 27);
            this.yemekAdiTxt.TabIndex = 0;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 298);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(108, 24);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Üretim Tarihi";
            // 
            // UretimDate
            // 
            this.UretimDate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.yemeklerBindingSource, "UretimZamani", true));
            this.UretimDate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "UretimZamani", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UretimDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.yemeklerBindingSource, "UretimZamani", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.UretimDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UretimDate.Location = new System.Drawing.Point(26, 328);
            this.UretimDate.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.UretimDate.MinDate = new System.DateTime(2019, 8, 5, 0, 0, 0, 0);
            this.UretimDate.Name = "UretimDate";
            this.UretimDate.Size = new System.Drawing.Size(392, 25);
            this.UretimDate.TabIndex = 3;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(26, 425);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(155, 24);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Üretim Malzemeleri";
            // 
            // malzemeGridView
            // 
            this.malzemeGridView.AllowUserToAddRows = false;
            this.malzemeGridView.AllowUserToDeleteRows = false;
            this.malzemeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.malzemeGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "Malzemeler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.malzemeGridView.Location = new System.Drawing.Point(26, 455);
            this.malzemeGridView.MultiSelect = false;
            this.malzemeGridView.Name = "malzemeGridView";
            this.malzemeGridView.ReadOnly = true;
            this.malzemeGridView.RowHeadersWidth = 51;
            this.malzemeGridView.RowTemplate.Height = 24;
            this.malzemeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.malzemeGridView.Size = new System.Drawing.Size(392, 150);
            this.malzemeGridView.TabIndex = 5;
            // 
            // stokEkleBtn
            // 
            this.stokEkleBtn.Location = new System.Drawing.Point(26, 611);
            this.stokEkleBtn.Name = "stokEkleBtn";
            this.stokEkleBtn.Size = new System.Drawing.Size(39, 24);
            this.stokEkleBtn.TabIndex = 6;
            this.stokEkleBtn.Values.Text = "Ekle";
            this.stokEkleBtn.LinkClicked += new System.EventHandler(this.StokEkleBtn_LinkClicked);
            this.stokEkleBtn.Click += new System.EventHandler(this.StokEkleBtn_Click);
            // 
            // stokSilBtn
            // 
            this.stokSilBtn.Location = new System.Drawing.Point(71, 611);
            this.stokSilBtn.Name = "stokSilBtn";
            this.stokSilBtn.Size = new System.Drawing.Size(125, 24);
            this.stokSilBtn.TabIndex = 7;
            this.stokSilBtn.Values.Text = "Seçili olanı kaldır";
            this.stokSilBtn.Click += new System.EventHandler(this.StokSilBtn_Click);
            // 
            // hataList
            // 
            this.hataList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnList;
            this.hataList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hataList.Location = new System.Drawing.Point(0, 695);
            this.hataList.Name = "hataList";
            this.hataList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.hataList.Size = new System.Drawing.Size(445, 154);
            this.hataList.TabIndex = 19;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(26, 665);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(106, 24);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.warning1;
            this.kryptonLabel5.Values.Text = "Hata Listesi";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(26, 206);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(330, 24);
            this.kryptonLabel6.TabIndex = 21;
            this.kryptonLabel6.Values.ExtraText = "Menüyü tam olarak yazınız";
            this.kryptonLabel6.Values.Text = "Yemek Açıklaması";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "YemekAciklamasi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kryptonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yemeklerBindingSource, "YemekAciklamasi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kryptonTextBox1.Location = new System.Drawing.Point(26, 232);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(392, 60);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(26, 381);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(301, 24);
            this.kryptonLabel7.TabIndex = 23;
            this.kryptonLabel7.Values.Text = "Yemek Web Ortamında Yayınlansın Mı ?";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Checked = true;
            this.kryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.yemeklerBindingSource, "YayinDurumu", true));
            this.kryptonCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.yemeklerBindingSource, "YayinDurumu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kryptonCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.yemeklerBindingSource, "YayinDurumu", true));
            this.kryptonCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yemeklerBindingSource, "YayinDurumu", true));
            this.kryptonCheckBox1.Location = new System.Drawing.Point(364, 381);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(24, 24);
            this.kryptonCheckBox1.TabIndex = 4;
            this.kryptonCheckBox1.Values.Text = "    ";
            // 
            // frmYeniYemekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(445, 849);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.hataList);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.stokSilBtn);
            this.Controls.Add(this.stokEkleBtn);
            this.Controls.Add(this.malzemeGridView);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.UretimDate);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.porsiyonGr);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.yemekAdiTxt);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniYemekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Yemek Tanımı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemeklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox porsiyonGr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox yemekAdiTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker UretimDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView malzemeGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel stokEkleBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel stokSilBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox hataList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.BindingSource yemeklerBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
    }
}