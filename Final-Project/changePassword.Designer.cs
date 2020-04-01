namespace Final_Project
{
    partial class changePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPasssword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newPasswordConfirm = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới ";
            // 
            // oldPasssword
            // 
            this.oldPasssword.Location = new System.Drawing.Point(138, 46);
            this.oldPasssword.Name = "oldPasssword";
            this.oldPasssword.Size = new System.Drawing.Size(157, 20);
            this.oldPasssword.TabIndex = 3;
            this.oldPasssword.Text = " ";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(138, 83);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(157, 20);
            this.newPassword.TabIndex = 4;
            // 
            // newPasswordConfirm
            // 
            this.newPasswordConfirm.Location = new System.Drawing.Point(138, 118);
            this.newPasswordConfirm.Name = "newPasswordConfirm";
            this.newPasswordConfirm.Size = new System.Drawing.Size(157, 20);
            this.newPasswordConfirm.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(138, 171);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 31);
            this.submit.TabIndex = 6;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 214);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.newPasswordConfirm);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPasssword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changePassword";
            this.Text = "changePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPasssword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newPasswordConfirm;
        private System.Windows.Forms.Button submit;
    }
}