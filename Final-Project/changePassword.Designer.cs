namespace Final_Project
{
    partial class ChangePassword
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.oldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newPasswordConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.submit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Mật khẩu cũ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(35, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Mật khẩu mới";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Xác nhận mật khẩu";
            // 
            // oldPassword
            // 
            this.oldPassword.Depth = 0;
            this.oldPassword.Hint = "";
            this.oldPassword.Location = new System.Drawing.Point(213, 93);
            this.oldPassword.MaxLength = 32767;
            this.oldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '\0';
            this.oldPassword.SelectedText = "";
            this.oldPassword.SelectionLength = 0;
            this.oldPassword.SelectionStart = 0;
            this.oldPassword.Size = new System.Drawing.Size(209, 23);
            this.oldPassword.TabIndex = 10;
            this.oldPassword.TabStop = false;
            this.oldPassword.UseSystemPasswordChar = false;
            // 
            // newPassword
            // 
            this.newPassword.Depth = 0;
            this.newPassword.Hint = "";
            this.newPassword.Location = new System.Drawing.Point(213, 128);
            this.newPassword.MaxLength = 32767;
            this.newPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '\0';
            this.newPassword.SelectedText = "";
            this.newPassword.SelectionLength = 0;
            this.newPassword.SelectionStart = 0;
            this.newPassword.Size = new System.Drawing.Size(209, 23);
            this.newPassword.TabIndex = 11;
            this.newPassword.TabStop = false;
            this.newPassword.UseSystemPasswordChar = false;
            // 
            // newPasswordConfirm
            // 
            this.newPasswordConfirm.Depth = 0;
            this.newPasswordConfirm.Hint = "";
            this.newPasswordConfirm.Location = new System.Drawing.Point(213, 165);
            this.newPasswordConfirm.MaxLength = 32767;
            this.newPasswordConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPasswordConfirm.Name = "newPasswordConfirm";
            this.newPasswordConfirm.PasswordChar = '\0';
            this.newPasswordConfirm.SelectedText = "";
            this.newPasswordConfirm.SelectionLength = 0;
            this.newPasswordConfirm.SelectionStart = 0;
            this.newPasswordConfirm.Size = new System.Drawing.Size(209, 23);
            this.newPasswordConfirm.TabIndex = 12;
            this.newPasswordConfirm.TabStop = false;
            this.newPasswordConfirm.UseSystemPasswordChar = false;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit.Depth = 0;
            this.submit.Icon = null;
            this.submit.Location = new System.Drawing.Point(280, 213);
            this.submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.submit.Name = "submit";
            this.submit.Primary = true;
            this.submit.Size = new System.Drawing.Size(71, 36);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.newPasswordConfirm);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ChangePassword";
            this.Text = "changePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField oldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPasswordConfirm;
        private MaterialSkin.Controls.MaterialRaisedButton submit;
    }
}