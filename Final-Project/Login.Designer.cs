namespace Final_Project
{
    partial class Login
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
            this.qlptDataSet11 = new Final_Project.QLPTDataSet1();
            this.qlptDataSet12 = new Final_Project.QLPTDataSet1();
            this.materialSingleLineTextFieldUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelForgotPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.qlptDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlptDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // qlptDataSet11
            // 
            this.qlptDataSet11.DataSetName = "QLPTDataSet1";
            this.qlptDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlptDataSet12
            // 
            this.qlptDataSet12.DataSetName = "QLPTDataSet1";
            this.qlptDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialSingleLineTextFieldUserName
            // 
            this.materialSingleLineTextFieldUserName.Depth = 0;
            this.materialSingleLineTextFieldUserName.Hint = "";
            this.materialSingleLineTextFieldUserName.Location = new System.Drawing.Point(108, 98);
            this.materialSingleLineTextFieldUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldUserName.Name = "materialSingleLineTextFieldUserName";
            this.materialSingleLineTextFieldUserName.PasswordChar = '\0';
            this.materialSingleLineTextFieldUserName.SelectedText = "";
            this.materialSingleLineTextFieldUserName.SelectionLength = 0;
            this.materialSingleLineTextFieldUserName.SelectionStart = 0;
            this.materialSingleLineTextFieldUserName.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextFieldUserName.TabIndex = 5;
            this.materialSingleLineTextFieldUserName.TabStop = false;
            this.materialSingleLineTextFieldUserName.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldPassword
            // 
            this.materialSingleLineTextFieldPassword.Depth = 0;
            this.materialSingleLineTextFieldPassword.Hint = "";
            this.materialSingleLineTextFieldPassword.Location = new System.Drawing.Point(108, 147);
            this.materialSingleLineTextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassword.Name = "materialSingleLineTextFieldPassword";
            this.materialSingleLineTextFieldPassword.PasswordChar = '*';
            this.materialSingleLineTextFieldPassword.SelectedText = "";
            this.materialSingleLineTextFieldPassword.SelectionLength = 0;
            this.materialSingleLineTextFieldPassword.SelectionStart = 0;
            this.materialSingleLineTextFieldPassword.Size = new System.Drawing.Size(208, 23);
            this.materialSingleLineTextFieldPassword.TabIndex = 6;
            this.materialSingleLineTextFieldPassword.TabStop = false;
            this.materialSingleLineTextFieldPassword.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialSingleLineTextFieldPassword_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "User name :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Password : ";
            // 
            // materialLabelForgotPassword
            // 
            this.materialLabelForgotPassword.AutoSize = true;
            this.materialLabelForgotPassword.Depth = 0;
            this.materialLabelForgotPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelForgotPassword.Location = new System.Drawing.Point(122, 237);
            this.materialLabelForgotPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelForgotPassword.Name = "materialLabelForgotPassword";
            this.materialLabelForgotPassword.Size = new System.Drawing.Size(133, 19);
            this.materialLabelForgotPassword.TabIndex = 10;
            this.materialLabelForgotPassword.Text = "Forgot password ?";
            this.materialLabelForgotPassword.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialRaisedButtonLogin
            // 
            this.materialRaisedButtonLogin.AutoSize = true;
            this.materialRaisedButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonLogin.Depth = 0;
            this.materialRaisedButtonLogin.Icon = null;
            this.materialRaisedButtonLogin.Location = new System.Drawing.Point(157, 187);
            this.materialRaisedButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonLogin.Name = "materialRaisedButtonLogin";
            this.materialRaisedButtonLogin.Primary = true;
            this.materialRaisedButtonLogin.Size = new System.Drawing.Size(61, 36);
            this.materialRaisedButtonLogin.TabIndex = 12;
            this.materialRaisedButtonLogin.Text = "Login";
            this.materialRaisedButtonLogin.UseVisualStyleBackColor = true;
            this.materialRaisedButtonLogin.Click += new System.EventHandler(this.materialRaisedButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 265);
            this.Controls.Add(this.materialRaisedButtonLogin);
            this.Controls.Add(this.materialLabelForgotPassword);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSingleLineTextFieldPassword);
            this.Controls.Add(this.materialSingleLineTextFieldUserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlptDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlptDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLPTDataSet1 qlptDataSet11;
        private QLPTDataSet1 qlptDataSet12;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabelForgotPassword;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonLogin;
    }
}

