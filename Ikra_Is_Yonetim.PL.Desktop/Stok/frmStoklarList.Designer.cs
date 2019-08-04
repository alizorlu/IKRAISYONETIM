namespace Ikra_Is_Yonetim.PL.Desktop.Stok
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.stoklarDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yenileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniStokBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.stoklarDataGridView);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.menuStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel1.Size = new System.Drawing.Size(956, 661);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // stoklarDataGridView
            // 
            this.stoklarDataGridView.AllowUserToAddRows = false;
            this.stoklarDataGridView.AllowUserToDeleteRows = false;
            this.stoklarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stoklarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stoklarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stoklarDataGridView.Location = new System.Drawing.Point(0, 108);
            this.stoklarDataGridView.Name = "stoklarDataGridView";
            this.stoklarDataGridView.ReadOnly = true;
            this.stoklarDataGridView.RowHeadersWidth = 51;
            this.stoklarDataGridView.RowTemplate.Height = 24;
            this.stoklarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stoklarDataGridView.Size = new System.Drawing.Size(956, 553);
            this.stoklarDataGridView.TabIndex = 4;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 48);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(956, 60);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileBtn,
            this.toolStripMenuItem3,
            this.yeniStokBtn,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(956, 48);
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
            this.yenileBtn.Click += new System.EventHandler(this.YenileBtn_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 44);
            this.toolStripMenuItem3.Text = "|";
            // 
            // yeniStokBtn
            // 
            this.yeniStokBtn.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.plus;
            this.yeniStokBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yeniStokBtn.Name = "yeniStokBtn";
            this.yeniStokBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yeniStokBtn.Size = new System.Drawing.Size(83, 44);
            this.yeniStokBtn.Text = "Yeni Stok";
            this.yeniStokBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yeniStokBtn.Click += new System.EventHandler(this.YeniStokBtn_Click);
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
            // frmStoklarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 661);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmStoklarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem yeniStokBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView stoklarDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}