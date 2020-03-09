namespace Final_Project
{
    partial class CauHinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonServer = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.DBTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(112, 19);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(203, 20);
            this.serverTextBox.TabIndex = 2;
            this.serverTextBox.TextChanged += new System.EventHandler(this.serName_TextChanged);
            // 
            // ButtonServer
            // 
            this.ButtonServer.Location = new System.Drawing.Point(324, 160);
            this.ButtonServer.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonServer.Name = "ButtonServer";
            this.ButtonServer.Size = new System.Drawing.Size(100, 34);
            this.ButtonServer.TabIndex = 6;
            this.ButtonServer.Text = "Submit";
            this.ButtonServer.UseVisualStyleBackColor = true;
            this.ButtonServer.Click += new System.EventHandler(this.ButtonServer_Click);
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(29, 89);
            this.userId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(46, 13);
            this.userId.TabIndex = 5;
            this.userId.Text = "User ID:";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Location = new System.Drawing.Point(29, 125);
            this.passwordLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(56, 13);
            this.passwordLable.TabIndex = 6;
            this.passwordLable.Text = "Password:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(112, 89);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(203, 20);
            this.userIdTextBox.TabIndex = 4;
            this.userIdTextBox.TextChanged += new System.EventHandler(this.userIdTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 122);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(203, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // DBTextBox
            // 
            this.DBTextBox.Location = new System.Drawing.Point(112, 55);
            this.DBTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DBTextBox.Name = "DBTextBox";
            this.DBTextBox.Size = new System.Drawing.Size(203, 20);
            this.DBTextBox.TabIndex = 3;
            this.DBTextBox.TextChanged += new System.EventHandler(this.DBTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB Name:";
            // 
            // CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 205);
            this.Controls.Add(this.DBTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.ButtonServer);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CauHinh";
            this.Text = "CauHinh";
            this.Load += new System.EventHandler(this.CauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonServer;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox DBTextBox;
        private System.Windows.Forms.Label label4;
    }
}