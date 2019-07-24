namespace Ikra_Is_Yonetim.PL.Desktop.Stoklar
{
    partial class frmStoklarList
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
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.yeniStokKryptonBtn = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.stokGirisiPnl = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stokFiyati = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.stokIslemNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.yeniStokEkleTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGirisiPnl)).BeginInit();
            this.stokGirisiPnl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokIslemNavigator)).BeginInit();
            this.stokIslemNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeniStokEkleTab)).BeginInit();
            this.yeniStokEkleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonRibbon1.QATUserChange = false;
            this.kryptonRibbon1.RibbonAppButton.AppButtonVisible = false;
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(1054, 135);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.kryptonRibbonTab1.Text = "Genel İşlemler";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Stok İşlemleri";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.yeniStokKryptonBtn,
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3});
            // 
            // yeniStokKryptonBtn
            // 
            this.yeniStokKryptonBtn.TextLine1 = "Yeni Stok Girişi";
            this.yeniStokKryptonBtn.Click += new System.EventHandler(this.yeniStokKryptonBtn_Click);
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.TextLine1 = "Stok Listesi";
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.TextLine1 = "Stok Maaliyetleri";
            // 
            // stokGirisiPnl
            // 
            this.stokGirisiPnl.Controls.Add(this.stokIslemNavigator);
            this.stokGirisiPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.stokGirisiPnl.Location = new System.Drawing.Point(0, 135);
            this.stokGirisiPnl.Name = "stokGirisiPnl";
            this.stokGirisiPnl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.stokGirisiPnl.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabHighProfile;
            this.stokGirisiPnl.Size = new System.Drawing.Size(1054, 235);
            this.stokGirisiPnl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.01943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.98057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonComboBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stokFiyati, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.13772F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.580838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(82, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Stok Fiyatı";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Stok Adı";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonComboBox1.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.kryptonComboBox1.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 455;
            this.kryptonComboBox1.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.kryptonComboBox1.Location = new System.Drawing.Point(140, 3);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonComboBox1.Size = new System.Drawing.Size(454, 25);
            this.kryptonComboBox1.TabIndex = 1;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 69);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(122, 24);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Stok Miktarı(KG)";
            // 
            // stokFiyati
            // 
            this.stokFiyati.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokFiyati.Location = new System.Drawing.Point(140, 36);
            this.stokFiyati.Name = "stokFiyati";
            this.stokFiyati.Size = new System.Drawing.Size(454, 30);
            this.stokFiyati.TabIndex = 1;
            this.stokFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.stokFiyati.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(140, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 30);
            this.textBox1.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButton1.Location = new System.Drawing.Point(429, 102);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(165, 45);
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Kaydet";
            // 
            // stokIslemNavigator
            // 
            this.stokIslemNavigator.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.HidePage;
            this.stokIslemNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.stokIslemNavigator.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.stokIslemNavigator.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.stokIslemNavigator.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.stokIslemNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokIslemNavigator.Location = new System.Drawing.Point(0, 0);
            this.stokIslemNavigator.Name = "stokIslemNavigator";
            this.stokIslemNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.stokIslemNavigator.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            this.stokIslemNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.yeniStokEkleTab});
            this.stokIslemNavigator.SelectedIndex = 0;
            this.stokIslemNavigator.Size = new System.Drawing.Size(1054, 235);
            this.stokIslemNavigator.TabIndex = 1;
            this.stokIslemNavigator.Text = "kryptonNavigator1";
            this.stokIslemNavigator.Visible = false;
            // 
            // yeniStokEkleTab
            // 
            this.yeniStokEkleTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.yeniStokEkleTab.Controls.Add(this.tableLayoutPanel1);
            this.yeniStokEkleTab.Flags = 65534;
            this.yeniStokEkleTab.LastVisibleSet = true;
            this.yeniStokEkleTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.yeniStokEkleTab.Name = "yeniStokEkleTab";
            this.yeniStokEkleTab.Size = new System.Drawing.Size(1052, 202);
            this.yeniStokEkleTab.Text = "Yeni Stok Girişi";
            this.yeniStokEkleTab.ToolTipTitle = "Page ToolTip";
            this.yeniStokEkleTab.UniqueName = "329C5E2BAD8249C55EA2670FE1C36796";
            this.yeniStokEkleTab.Visible = false;
            // 
            // frmStoklarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 771);
            this.Controls.Add(this.stokGirisiPnl);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "frmStoklarList";
            this.Text = "Stoklar İşlemi | İkra İş Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokGirisiPnl)).EndInit();
            this.stokGirisiPnl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokIslemNavigator)).EndInit();
            this.stokIslemNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yeniStokEkleTab)).EndInit();
            this.yeniStokEkleTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton yeniStokKryptonBtn;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel stokGirisiPnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox stokFiyati;
        private System.Windows.Forms.TextBox textBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator stokIslemNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage yeniStokEkleTab;
    }
}