namespace Ikra_Is_Yonetim.PL.Desktop
{
    partial class frmLoginUserList
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
            this.userList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToDeleteRows = false;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.ReadOnly = true;
            this.userList.RowTemplate.Height = 24;
            this.userList.Size = new System.Drawing.Size(243, 668);
            this.userList.TabIndex = 0;
            this.userList.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.userList_CellContextMenuStripNeeded);
            this.userList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellDoubleClick);
            this.userList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.userList_MouseDoubleClick);
            // 
            // frmLoginUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(243, 668);
            this.Controls.Add(this.userList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView userList;
    }
}