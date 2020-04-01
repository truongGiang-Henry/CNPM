namespace Final_Project
{
    partial class NV
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
            this.logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQuanLyPhongTro = new System.Windows.Forms.ToolStripMenuItem();
            this.qlptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tktcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(396, 248);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(126, 33);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyPhongTro,
            this.tktcToolStripMenuItem,
            this.dvToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQuanLyPhongTro
            // 
            this.menuQuanLyPhongTro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuQuanLyPhongTro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlptToolStripMenuItem,
            this.qlntToolStripMenuItem});
            this.menuQuanLyPhongTro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuQuanLyPhongTro.Name = "menuQuanLyPhongTro";
            this.menuQuanLyPhongTro.Size = new System.Drawing.Size(68, 20);
            this.menuQuanLyPhongTro.Text = "QUẢN LÝ";
            // 
            // qlptToolStripMenuItem
            // 
            this.qlptToolStripMenuItem.Name = "qlptToolStripMenuItem";
            this.qlptToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.qlptToolStripMenuItem.Text = "QUẢN LÝ PHÒNG TRỌ";
            this.qlptToolStripMenuItem.Click += new System.EventHandler(this.qlptToolStripMenuItem_Click);
            // 
            // qlntToolStripMenuItem
            // 
            this.qlntToolStripMenuItem.Name = "qlntToolStripMenuItem";
            this.qlntToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.qlntToolStripMenuItem.Text = "QUẢN LÝ NGƯỜI THUÊ";
            this.qlntToolStripMenuItem.Click += new System.EventHandler(this.qlntToolStripMenuItem_Click);
            // 
            // tktcToolStripMenuItem
            // 
            this.tktcToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tktcToolStripMenuItem.Name = "tktcToolStripMenuItem";
            this.tktcToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.tktcToolStripMenuItem.Text = "THỐNG KÊ THU CHI";
            this.tktcToolStripMenuItem.Click += new System.EventHandler(this.tktcToolStripMenuItem_Click);
            // 
            // dvToolStripMenuItem
            // 
            this.dvToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dvToolStripMenuItem.Name = "dvToolStripMenuItem";
            this.dvToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.dvToolStripMenuItem.Text = "DỊCH VỤ";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.changePasswordToolStripMenuItem.Text = "ĐỔI MẬT KHẨU";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NV";
            this.Text = "QLPT";
            this.Load += new System.EventHandler(this.NV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyPhongTro;
        private System.Windows.Forms.ToolStripMenuItem qlptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tktcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}