namespace Ikra_Is_Yonetim.PL.Desktop.Stok
{
    partial class frmStokHareketler
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
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokHareketlerGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketlerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Malzeme);
            // 
            // stoklarBindingSource
            // 
            this.stoklarBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Stoklar);
            // 
            // stokHareketlerGrid
            // 
            this.stokHareketlerGrid.AllowUserToAddRows = false;
            this.stokHareketlerGrid.AllowUserToDeleteRows = false;
            this.stokHareketlerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stokHareketlerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokHareketlerGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.stoklarBindingSource, "Malzemeler", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stokHareketlerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokHareketlerGrid.Location = new System.Drawing.Point(0, 0);
            this.stokHareketlerGrid.Name = "stokHareketlerGrid";
            this.stokHareketlerGrid.ReadOnly = true;
            this.stokHareketlerGrid.RowHeadersWidth = 51;
            this.stokHareketlerGrid.RowTemplate.Height = 24;
            this.stokHareketlerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokHareketlerGrid.Size = new System.Drawing.Size(671, 553);
            this.stokHareketlerGrid.TabIndex = 5;
            // 
            // frmStokHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 553);
            this.Controls.Add(this.stokHareketlerGrid);
            this.Name = "frmStokHareketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketlerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource stoklarBindingSource;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView stokHareketlerGrid;
    }
}