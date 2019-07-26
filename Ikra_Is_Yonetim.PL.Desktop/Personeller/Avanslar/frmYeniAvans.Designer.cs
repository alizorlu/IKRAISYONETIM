namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Avanslar
{
    partial class frmYeniAvans
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.avansTutari = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.duzenleBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.avanslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avanslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.avansTutari, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.duzenleBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(168, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Avans Tutarını Giriniz";
            // 
            // avansTutari
            // 
            this.avansTutari.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.avansTutari.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avanslarBindingSource, "AvansTutari", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.avansTutari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avansTutari.Location = new System.Drawing.Point(177, 3);
            this.avansTutari.Name = "avansTutari";
            this.avansTutari.Size = new System.Drawing.Size(387, 27);
            this.avansTutari.TabIndex = 1;
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duzenleBtn.Location = new System.Drawing.Point(177, 36);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(387, 49);
            this.duzenleBtn.TabIndex = 17;
            this.duzenleBtn.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.save;
            this.duzenleBtn.Values.Text = "Avans İşlemini Kaydet";
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // avanslarBindingSource
            // 
            this.avanslarBindingSource.DataSource = typeof(Ikra_Is_Yonetim.DAL.EntityFramework.Tables.Avanslar);
            // 
            // frmYeniAvans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 87);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniAvans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avans İşlemi";
            this.Load += new System.EventHandler(this.frmYeniAvans_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avanslarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox avansTutari;
        private ComponentFactory.Krypton.Toolkit.KryptonButton duzenleBtn;
        private System.Windows.Forms.BindingSource avanslarBindingSource;
    }
}