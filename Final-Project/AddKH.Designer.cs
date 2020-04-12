namespace Final_Project
{
    partial class AddKH
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
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // cbRoomId
            // 
            this.cbRoomId.AllowDrop = true;
            this.cbRoomId.BackColor = System.Drawing.SystemColors.Control;
            this.cbRoomId.FormattingEnabled = true;
            this.cbRoomId.Location = new System.Drawing.Point(149, 218);
            this.cbRoomId.Name = "cbRoomId";
            this.cbRoomId.Size = new System.Drawing.Size(134, 21);
            this.cbRoomId.TabIndex = 19;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Họ và Tên";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 126);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "CMND";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 170);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Số điện thoại";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 217);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Mã Phòng";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear.Depth = 0;
            this.clear.Icon = null;
            this.clear.Location = new System.Drawing.Point(369, 253);
            this.clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.clear.Name = "clear";
            this.clear.Primary = true;
            this.clear.Size = new System.Drawing.Size(63, 36);
            this.clear.TabIndex = 25;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Depth = 0;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(450, 253);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Primary = true;
            this.save.Size = new System.Drawing.Size(55, 36);
            this.save.TabIndex = 26;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // name
            // 
            this.name.Depth = 0;
            this.name.Hint = "";
            this.name.Location = new System.Drawing.Point(149, 77);
            this.name.MaxLength = 32767;
            this.name.MouseState = MaterialSkin.MouseState.HOVER;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(197, 23);
            this.name.TabIndex = 27;
            this.name.TabStop = false;
            this.name.UseSystemPasswordChar = false;
            // 
            // cmnd
            // 
            this.cmnd.Depth = 0;
            this.cmnd.Hint = "";
            this.cmnd.Location = new System.Drawing.Point(149, 122);
            this.cmnd.MaxLength = 32767;
            this.cmnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmnd.Name = "cmnd";
            this.cmnd.PasswordChar = '\0';
            this.cmnd.SelectedText = "";
            this.cmnd.SelectionLength = 0;
            this.cmnd.SelectionStart = 0;
            this.cmnd.Size = new System.Drawing.Size(197, 23);
            this.cmnd.TabIndex = 28;
            this.cmnd.TabStop = false;
            this.cmnd.UseSystemPasswordChar = false;
            // 
            // phone
            // 
            this.phone.Depth = 0;
            this.phone.Hint = "";
            this.phone.Location = new System.Drawing.Point(149, 170);
            this.phone.MaxLength = 32767;
            this.phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.SelectedText = "";
            this.phone.SelectionLength = 0;
            this.phone.SelectionStart = 0;
            this.phone.Size = new System.Drawing.Size(197, 23);
            this.phone.TabIndex = 29;
            this.phone.TabStop = false;
            this.phone.UseSystemPasswordChar = false;
            // 
            // AddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbRoomId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddKH";
            this.Text = "Thêm mới khách trọ";
            this.Load += new System.EventHandler(this.AddKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRoomId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton clear;
        private MaterialSkin.Controls.MaterialRaisedButton save;
        private MaterialSkin.Controls.MaterialSingleLineTextField name;
        private MaterialSkin.Controls.MaterialSingleLineTextField cmnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField phone;
    }
}