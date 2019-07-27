namespace Ikra_Is_Yonetim.PL.Desktop.Kasa
{
    partial class frmKasaList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kapatBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._donemLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.donemLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this._ayLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kasaGirisCikislarGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.islemListelemeCombo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.donemCombo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this._haftaLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this._gunLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasaGirisCikislarGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemListelemeCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1135, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kapatBtn
            // 
            this.kapatBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kapatBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.house;
            this.kapatBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kapatBtn.Name = "kapatBtn";
            this.kapatBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kapatBtn.Size = new System.Drawing.Size(130, 44);
            this.kapatBtn.Text = "Anasayfaya Dön";
            this.kapatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donemLbl,
            this._donemLbl,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this._ayLbl,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this._haftaLbl,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this._gunLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1135, 34);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _donemLbl
            // 
            this._donemLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._donemLbl.Name = "_donemLbl";
            this._donemLbl.Size = new System.Drawing.Size(76, 28);
            this._donemLbl.Text = "--------";
            // 
            // donemLbl
            // 
            this.donemLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.donemLbl.Name = "donemLbl";
            this.donemLbl.Size = new System.Drawing.Size(189, 28);
            this.donemLbl.Text = "2019 DÖNEM KARI :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 28);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(136, 28);
            this.toolStripStatusLabel3.Text = "BU AYIN KÂRI:";
            // 
            // _ayLbl
            // 
            this._ayLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._ayLbl.Name = "_ayLbl";
            this._ayLbl.Size = new System.Drawing.Size(76, 28);
            this._ayLbl.Text = "--------";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Enabled = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 28);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 48);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(1135, 607);
            this.kryptonNavigator1.TabIndex = 3;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kasaGirisCikislarGrid);
            this.kryptonPage1.Controls.Add(this.kryptonPanel1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1133, 576);
            this.kryptonPage1.Text = "Kasa Girişler-Çıkışlar";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "C25CC2B9C09645937BA3622E7985AE8F";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.donemCombo);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.islemListelemeCombo);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel1.Size = new System.Drawing.Size(1133, 65);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kasaGirisCikislarGrid
            // 
            this.kasaGirisCikislarGrid.AllowUserToAddRows = false;
            this.kasaGirisCikislarGrid.AllowUserToDeleteRows = false;
            this.kasaGirisCikislarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.kasaGirisCikislarGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.kasaGirisCikislarGrid.ColumnHeadersHeight = 29;
            this.kasaGirisCikislarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kasaGirisCikislarGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kasaGirisCikislarGrid.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.kasaGirisCikislarGrid.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.kasaGirisCikislarGrid.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kasaGirisCikislarGrid.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kasaGirisCikislarGrid.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.kasaGirisCikislarGrid.Location = new System.Drawing.Point(0, 65);
            this.kasaGirisCikislarGrid.MultiSelect = false;
            this.kasaGirisCikislarGrid.Name = "kasaGirisCikislarGrid";
            this.kasaGirisCikislarGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kasaGirisCikislarGrid.ReadOnly = true;
            this.kasaGirisCikislarGrid.RowHeadersWidth = 51;
            this.kasaGirisCikislarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kasaGirisCikislarGrid.RowTemplate.Height = 24;
            this.kasaGirisCikislarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kasaGirisCikislarGrid.Size = new System.Drawing.Size(1133, 511);
            this.kasaGirisCikislarGrid.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(295, 19);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(131, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "İşlem Listeleme :";
            // 
            // islemListelemeCombo
            // 
            this.islemListelemeCombo.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.islemListelemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemListelemeCombo.DropDownWidth = 205;
            this.islemListelemeCombo.Items.AddRange(new object[] {
            "Tüm İşlemler",
            "Maaş",
            "Avans",
            "Satış"});
            this.islemListelemeCombo.Location = new System.Drawing.Point(433, 19);
            this.islemListelemeCombo.Name = "islemListelemeCombo";
            this.islemListelemeCombo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.islemListelemeCombo.Size = new System.Drawing.Size(205, 25);
            this.islemListelemeCombo.TabIndex = 1;
            this.islemListelemeCombo.SelectedIndexChanged += new System.EventHandler(this.IslemListelemeCombo_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 20);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(73, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Dönem :";
            // 
            // donemCombo
            // 
            this.donemCombo.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.donemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.donemCombo.DropDownWidth = 205;
            this.donemCombo.Items.AddRange(new object[] {
            "Tüm İşlemler",
            "Maaş",
            "Avans",
            "Satış"});
            this.donemCombo.Location = new System.Drawing.Point(82, 19);
            this.donemCombo.Name = "donemCombo";
            this.donemCombo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.donemCombo.Size = new System.Drawing.Size(205, 25);
            this.donemCombo.TabIndex = 3;
            this.donemCombo.SelectedIndexChanged += new System.EventHandler(this.DonemCombo_SelectedIndexChanged);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Enabled = false;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(13, 28);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(165, 28);
            this.toolStripStatusLabel9.Text = "BUGÜNÜN KARI :";
            // 
            // _haftaLbl
            // 
            this._haftaLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._haftaLbl.Name = "_haftaLbl";
            this._haftaLbl.Size = new System.Drawing.Size(76, 28);
            this._haftaLbl.Text = "--------";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(202, 28);
            this.toolStripStatusLabel6.Text = "SON 7 GÜNÜN KARI :";
            // 
            // _gunLbl
            // 
            this._gunLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._gunLbl.Name = "_gunLbl";
            this._gunLbl.Size = new System.Drawing.Size(76, 28);
            this._gunLbl.Text = "--------";
            // 
            // frmKasaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 689);
            this.Controls.Add(this.kryptonNavigator1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmKasaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa/Defter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasaGirisCikislarGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemListelemeCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donemCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kapatBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel donemLbl;
        private System.Windows.Forms.ToolStripStatusLabel _donemLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel _ayLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kasaGirisCikislarGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox islemListelemeCombo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox donemCombo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel _haftaLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel _gunLbl;
    }
}