namespace Ikra_Is_Yonetim.PL.Desktop.Firmalar
{
    partial class frmFirmalarList
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.firmaViewTab = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.personelBilgiTab = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.yetkilisi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.firmaAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addres = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.telefonTxt = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.hataliLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.basariliLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.personellerList = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.firmaListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yenileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.topSilBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.topDuzenleBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFirmaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaViewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiTab)).BeginInit();
            this.personelBilgiTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personellerList)).BeginInit();
            this.personellerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.firmaViewTab);
            this.kryptonPanel1.Controls.Add(this.personellerList);
            this.kryptonPanel1.Controls.Add(this.menuStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel1.Size = new System.Drawing.Size(1038, 583);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // firmaViewTab
            // 
            this.firmaViewTab.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.firmaViewTab.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.firmaViewTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaViewTab.Location = new System.Drawing.Point(254, 48);
            this.firmaViewTab.Name = "firmaViewTab";
            this.firmaViewTab.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.StackCheckButtonGroup;
            this.firmaViewTab.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.firmaViewTab.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.personelBilgiTab});
            this.firmaViewTab.SelectedIndex = 0;
            this.firmaViewTab.Size = new System.Drawing.Size(784, 535);
            this.firmaViewTab.TabIndex = 4;
            this.firmaViewTab.Text = "kryptonNavigator1";
            this.firmaViewTab.Visible = false;
            // 
            // personelBilgiTab
            // 
            this.personelBilgiTab.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.personelBilgiTab.Controls.Add(this.tableLayoutPanel1);
            this.personelBilgiTab.Flags = 65534;
            this.personelBilgiTab.LastVisibleSet = true;
            this.personelBilgiTab.MinimumSize = new System.Drawing.Size(50, 50);
            this.personelBilgiTab.Name = "personelBilgiTab";
            this.personelBilgiTab.Size = new System.Drawing.Size(782, 504);
            this.personelBilgiTab.Text = "Firma bilgisi ve işlemler";
            this.personelBilgiTab.ToolTipTitle = "Page ToolTip";
            this.personelBilgiTab.UniqueName = "4736439621CC4A661788A7A3F3653EC9";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.76191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.23809F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(776, 270);
            this.tableLayoutPanel3.TabIndex = 21;
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
            this.yetkilisi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.firmalarBindingSource, "YetkiliKisi", true));
            this.yetkilisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "YetkiliKisi", true));
            this.yetkilisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yetkilisi.Location = new System.Drawing.Point(123, 36);
            this.yetkilisi.Name = "yetkilisi";
            this.yetkilisi.Size = new System.Drawing.Size(494, 27);
            this.yetkilisi.TabIndex = 1;
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
            this.firmaAdi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.firmalarBindingSource, "FirmaAdi", true));
            this.firmaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaAdi.Location = new System.Drawing.Point(123, 3);
            this.firmaAdi.Name = "firmaAdi";
            this.firmaAdi.Size = new System.Drawing.Size(494, 27);
            this.firmaAdi.TabIndex = 0;
            // 
            // addres
            // 
            this.addres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "Adres", true));
            this.addres.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.firmalarBindingSource, "Adres", true));
            this.addres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addres.Location = new System.Drawing.Point(123, 102);
            this.addres.Name = "addres";
            this.addres.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.addres.Size = new System.Drawing.Size(494, 164);
            this.addres.TabIndex = 6;
            this.addres.Text = "";
            // 
            // telefonTxt
            // 
            this.telefonTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmalarBindingSource, "Telefon", true));
            this.telefonTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.firmalarBindingSource, "Telefon", true));
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
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 279);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(776, 26);
            this.kryptonHeader1.TabIndex = 22;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Firma borç-alacak takibi";
            // 
            // personellerList
            // 
            this.personellerList.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.personellerList.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.personellerList.Dock = System.Windows.Forms.DockStyle.Left;
            this.personellerList.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.personellerList.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.personellerList.Location = new System.Drawing.Point(0, 48);
            this.personellerList.Name = "personellerList";
            this.personellerList.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderGroup;
            this.personellerList.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.personellerList.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.personellerList.SelectedIndex = 0;
            this.personellerList.Size = new System.Drawing.Size(254, 535);
            this.personellerList.TabIndex = 3;
            this.personellerList.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.firmaListBox);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(252, 484);
            this.kryptonPage1.Text = "Firmalar Listesi";
            this.kryptonPage1.TextDescription = "Firmalar listesini verir";
            this.kryptonPage1.TextTitle = "Firmalar Listesi";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "9FDC33B82ECC439E3380BE5BA3BAEC66";
            // 
            // firmaListBox
            // 
            this.firmaListBox.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
            this.firmaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaListBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Command;
            this.firmaListBox.Location = new System.Drawing.Point(0, 0);
            this.firmaListBox.Name = "firmaListBox";
            this.firmaListBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.firmaListBox.Size = new System.Drawing.Size(252, 484);
            this.firmaListBox.TabIndex = 1;
            this.firmaListBox.SelectedIndexChanged += new System.EventHandler(this.FirmaListBox_SelectedIndexChanged);
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "EBE705D188124D03AEBA53007027FCB7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileBtn,
            this.toolStripMenuItem3,
            this.topSilBtn,
            this.topDuzenleBtn,
            this.yeniFirmaBtn,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1038, 48);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yenileBtn
            // 
            this.yenileBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.reload;
            this.yenileBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yenileBtn.Size = new System.Drawing.Size(107, 44);
            this.yenileBtn.Text = "Listeyi Yenile";
            this.yenileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 44);
            this.toolStripMenuItem3.Text = "|";
            // 
            // topSilBtn
            // 
            this.topSilBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.delete;
            this.topSilBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.topSilBtn.Name = "topSilBtn";
            this.topSilBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topSilBtn.Size = new System.Drawing.Size(80, 44);
            this.topSilBtn.Text = "Kaydı Sil";
            this.topSilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // topDuzenleBtn
            // 
            this.topDuzenleBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.save;
            this.topDuzenleBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.topDuzenleBtn.Name = "topDuzenleBtn";
            this.topDuzenleBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topDuzenleBtn.Size = new System.Drawing.Size(121, 44);
            this.topDuzenleBtn.Text = "Firma Güncelle";
            this.topDuzenleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.topDuzenleBtn.Click += new System.EventHandler(this.TopDuzenleBtn_Click);
            // 
            // yeniFirmaBtn
            // 
            this.yeniFirmaBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.plus;
            this.yeniFirmaBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yeniFirmaBtn.Name = "yeniFirmaBtn";
            this.yeniFirmaBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yeniFirmaBtn.Size = new System.Drawing.Size(91, 44);
            this.yeniFirmaBtn.Text = "Yeni Firma";
            this.yeniFirmaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yeniFirmaBtn.Click += new System.EventHandler(this.YeniFirmaBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.house;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 44);
            this.toolStripMenuItem1.Text = "Anasayfaya Dön";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Firmalar);
            // 
            // frmFirmalarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 583);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmFirmalarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmalar";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaViewTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiTab)).EndInit();
            this.personelBilgiTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personellerList)).EndInit();
            this.personellerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem topSilBtn;
        private System.Windows.Forms.ToolStripMenuItem topDuzenleBtn;
        private System.Windows.Forms.ToolStripMenuItem yeniFirmaBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator personellerList;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator firmaViewTab;
        private ComponentFactory.Krypton.Navigator.KryptonPage personelBilgiTab;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox firmaListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
    }
}