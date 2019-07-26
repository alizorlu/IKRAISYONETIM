namespace Ikra_Is_Yonetim.PL.Desktop.Personeller.Izinler
{
    partial class frmYeniIzin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bitis = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.baslangic = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.bitis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.baslangic, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bitis
            // 
            this.bitis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitis.Location = new System.Drawing.Point(165, 34);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(374, 25);
            this.bitis.TabIndex = 24;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(156, 25);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "İzin Başlangıç Tarihi";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 34);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(156, 25);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "İzin Bitiş Tarihi";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton2.Location = new System.Drawing.Point(165, 65);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(374, 64);
            this.kryptonButton2.TabIndex = 22;
            this.kryptonButton2.Values.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.save;
            this.kryptonButton2.Values.Text = "Kaydet";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // baslangic
            // 
            this.baslangic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baslangic.Location = new System.Drawing.Point(165, 3);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(374, 25);
            this.baslangic.TabIndex = 23;
            this.baslangic.Validating += new System.ComponentModel.CancelEventHandler(this.kryptonDateTimePicker1_Validating);
            // 
            // frmYeniIzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYeniIzin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İzin İşlemi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker bitis;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker baslangic;
    }
}