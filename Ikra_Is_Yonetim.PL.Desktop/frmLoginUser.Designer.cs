namespace Ikra_Is_Yonetim.PL.Desktop
{
    partial class frmLoginUser
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
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.usernameTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.passTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.loginBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.forgetPassLinkLbl = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnViewUserList = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 156);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(280, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // usernameTxt
            // 
            this.usernameTxt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnViewUserList});
            this.usernameTxt.Location = new System.Drawing.Point(32, 206);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(198, 27);
            this.usernameTxt.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(32, 176);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(95, 24);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Kullanıcı Adı";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(32, 240);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Şifreniz";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(32, 270);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '●';
            this.passTxt.Size = new System.Drawing.Size(198, 27);
            this.passTxt.TabIndex = 4;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(32, 12);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.loginBtn.Size = new System.Drawing.Size(198, 39);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Values.Text = "Giriş";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.forgetPassLinkLbl);
            this.kryptonPanel1.Controls.Add(this.loginBtn);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 311);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(262, 100);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // forgetPassLinkLbl
            // 
            this.forgetPassLinkLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.forgetPassLinkLbl.Location = new System.Drawing.Point(97, 64);
            this.forgetPassLinkLbl.Name = "forgetPassLinkLbl";
            this.forgetPassLinkLbl.Size = new System.Drawing.Size(133, 24);
            this.forgetPassLinkLbl.TabIndex = 7;
            this.forgetPassLinkLbl.Values.Text = "Şifremi Unuttum";
            // 
            // btnViewUserList
            // 
            this.btnViewUserList.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.view;
            this.btnViewUserList.UniqueName = "BD88AC3786A54706FA88CA4B4774DB1B";
            this.btnViewUserList.Click += new System.EventHandler(this.btnViewUserList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ikra_Is_Yonetim.PL.Desktop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(262, 411);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ikra İş Yönetim Sistemi";
            this.Load += new System.EventHandler(this.frmLoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox usernameTxt;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnViewUserList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton loginBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel forgetPassLinkLbl;
    }
}