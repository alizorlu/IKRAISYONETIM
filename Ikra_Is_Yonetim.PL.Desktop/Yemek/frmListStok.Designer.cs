namespace Ikra_Is_Yonetim.PL.Desktop.Yemek
{
    partial class frmListStok
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
            this.stokDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stokDataGridView
            // 
            this.stokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokDataGridView.Location = new System.Drawing.Point(0, 0);
            this.stokDataGridView.MultiSelect = false;
            this.stokDataGridView.Name = "stokDataGridView";
            this.stokDataGridView.RowHeadersWidth = 51;
            this.stokDataGridView.RowTemplate.Height = 24;
            this.stokDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokDataGridView.Size = new System.Drawing.Size(388, 646);
            this.stokDataGridView.TabIndex = 0;
            this.stokDataGridView.DoubleClick += new System.EventHandler(this.StokDataGridView_DoubleClick);
            // 
            // frmListStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 646);
            this.Controls.Add(this.stokDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lütfen kullanacağınız stoğu seçiniz.";
            ((System.ComponentModel.ISupportInitialize)(this.stokDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView stokDataGridView;
    }
}