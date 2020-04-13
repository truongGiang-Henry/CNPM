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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageQLPT = new System.Windows.Forms.TabPage();
            this.tabPageQLKH = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmndOld = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.roomId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialListViewCustomer = new MaterialSkin.Controls.MaterialListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPageTKTC = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmndNew = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPageQLKH.SuspendLayout();
            this.tabPageTKTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.AllowDrop = true;
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.materialTabControl1.Controls.Add(this.tabPageQLPT);
            this.materialTabControl1.Controls.Add(this.tabPageQLKH);
            this.materialTabControl1.Controls.Add(this.tabPageTKTC);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(12, 122);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1117, 636);
            this.materialTabControl1.TabIndex = 13;
            // 
            // tabPageQLPT
            // 
            this.tabPageQLPT.Location = new System.Drawing.Point(4, 28);
            this.tabPageQLPT.Name = "tabPageQLPT";
            this.tabPageQLPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLPT.Size = new System.Drawing.Size(1109, 604);
            this.tabPageQLPT.TabIndex = 0;
            this.tabPageQLPT.Text = "Quản lý phòng trọ";
            this.tabPageQLPT.UseVisualStyleBackColor = true;
            // 
            // tabPageQLKH
            // 
            this.tabPageQLKH.Controls.Add(this.materialLabel5);
            this.tabPageQLKH.Controls.Add(this.cmndNew);
            this.tabPageQLKH.Controls.Add(this.materialRaisedButton1);
            this.tabPageQLKH.Controls.Add(this.btnUpdate);
            this.tabPageQLKH.Controls.Add(this.materialLabel4);
            this.tabPageQLKH.Controls.Add(this.materialLabel3);
            this.tabPageQLKH.Controls.Add(this.materialLabel2);
            this.tabPageQLKH.Controls.Add(this.materialLabel1);
            this.tabPageQLKH.Controls.Add(this.phone);
            this.tabPageQLKH.Controls.Add(this.cmndOld);
            this.tabPageQLKH.Controls.Add(this.name);
            this.tabPageQLKH.Controls.Add(this.roomId);
            this.tabPageQLKH.Controls.Add(this.materialListViewCustomer);
            this.tabPageQLKH.Controls.Add(this.materialDivider1);
            this.tabPageQLKH.Location = new System.Drawing.Point(4, 28);
            this.tabPageQLKH.Name = "tabPageQLKH";
            this.tabPageQLKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLKH.Size = new System.Drawing.Size(1109, 604);
            this.tabPageQLKH.TabIndex = 1;
            this.tabPageQLKH.Text = "Quản lý khách hàng";
            this.tabPageQLKH.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(736, 436);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(48, 36);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Xóa";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(972, 436);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(717, 353);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Điện thoại";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(717, 270);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "CMND cũ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(717, 232);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Họ Tên";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(717, 195);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Phòng";
            // 
            // phone
            // 
            this.phone.Depth = 0;
            this.phone.Hint = "";
            this.phone.Location = new System.Drawing.Point(840, 349);
            this.phone.MaxLength = 32767;
            this.phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.SelectedText = "";
            this.phone.SelectionLength = 0;
            this.phone.SelectionStart = 0;
            this.phone.Size = new System.Drawing.Size(232, 23);
            this.phone.TabIndex = 4;
            this.phone.TabStop = false;
            this.phone.UseSystemPasswordChar = false;
            // 
            // cmndOld
            // 
            this.cmndOld.Depth = 0;
            this.cmndOld.Enabled = false;
            this.cmndOld.Hint = "";
            this.cmndOld.Location = new System.Drawing.Point(840, 270);
            this.cmndOld.MaxLength = 32767;
            this.cmndOld.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmndOld.Name = "cmndOld";
            this.cmndOld.PasswordChar = '\0';
            this.cmndOld.SelectedText = "";
            this.cmndOld.SelectionLength = 0;
            this.cmndOld.SelectionStart = 0;
            this.cmndOld.Size = new System.Drawing.Size(232, 23);
            this.cmndOld.TabIndex = 3;
            this.cmndOld.TabStop = false;
            this.cmndOld.UseSystemPasswordChar = false;
            // 
            // name
            // 
            this.name.Depth = 0;
            this.name.Hint = "";
            this.name.Location = new System.Drawing.Point(840, 232);
            this.name.MaxLength = 32767;
            this.name.MouseState = MaterialSkin.MouseState.HOVER;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(232, 23);
            this.name.TabIndex = 2;
            this.name.TabStop = false;
            this.name.UseSystemPasswordChar = false;
            // 
            // roomId
            // 
            this.roomId.Depth = 0;
            this.roomId.Hint = "";
            this.roomId.Location = new System.Drawing.Point(840, 191);
            this.roomId.MaxLength = 32767;
            this.roomId.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomId.Name = "roomId";
            this.roomId.PasswordChar = '\0';
            this.roomId.SelectedText = "";
            this.roomId.SelectionLength = 0;
            this.roomId.SelectionStart = 0;
            this.roomId.Size = new System.Drawing.Size(232, 23);
            this.roomId.TabIndex = 1;
            this.roomId.TabStop = false;
            this.roomId.UseSystemPasswordChar = false;
            // 
            // materialListViewCustomer
            // 
            this.materialListViewCustomer.AutoArrange = false;
            this.materialListViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnRoomId,
            this.columnName,
            this.columnCMND,
            this.columnPhone});
            this.materialListViewCustomer.Depth = 0;
            this.materialListViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListViewCustomer.FullRowSelect = true;
            this.materialListViewCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListViewCustomer.HideSelection = false;
            this.materialListViewCustomer.Location = new System.Drawing.Point(6, 3);
            this.materialListViewCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewCustomer.Name = "materialListViewCustomer";
            this.materialListViewCustomer.OwnerDraw = true;
            this.materialListViewCustomer.Size = new System.Drawing.Size(685, 598);
            this.materialListViewCustomer.TabIndex = 0;
            this.materialListViewCustomer.UseCompatibleStateImageBehavior = false;
            this.materialListViewCustomer.View = System.Windows.Forms.View.Details;
            this.materialListViewCustomer.SelectedIndexChanged += new System.EventHandler(this.materialListViewCustomer_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 84;
            // 
            // columnRoomId
            // 
            this.columnRoomId.Text = "Phòng";
            this.columnRoomId.Width = 100;
            // 
            // columnName
            // 
            this.columnName.Text = "Họ Tên";
            this.columnName.Width = 173;
            // 
            // columnCMND
            // 
            this.columnCMND.Text = "CMND";
            this.columnCMND.Width = 167;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Điện thoại";
            this.columnPhone.Width = 175;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(715, 419);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(357, 179);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tabPageTKTC
            // 
            this.tabPageTKTC.Controls.Add(this.crystalReportViewer);
            this.tabPageTKTC.Location = new System.Drawing.Point(4, 28);
            this.tabPageTKTC.Name = "tabPageTKTC";
            this.tabPageTKTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTKTC.Size = new System.Drawing.Size(1109, 604);
            this.tabPageTKTC.TabIndex = 2;
            this.tabPageTKTC.Text = "Thống kê ";
            this.tabPageTKTC.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.AllowDrop = true;
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 68);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1141, 48);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(717, 314);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "CMND mới";
            // 
            // cmndNew
            // 
            this.cmndNew.Depth = 0;
            this.cmndNew.Hint = "";
            this.cmndNew.Location = new System.Drawing.Point(840, 310);
            this.cmndNew.MaxLength = 32767;
            this.cmndNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmndNew.Name = "cmndNew";
            this.cmndNew.PasswordChar = '\0';
            this.cmndNew.SelectedText = "";
            this.cmndNew.SelectionLength = 0;
            this.cmndNew.SelectionStart = 0;
            this.cmndNew.Size = new System.Drawing.Size(232, 23);
            this.cmndNew.TabIndex = 12;
            this.cmndNew.TabStop = false;
            this.cmndNew.UseSystemPasswordChar = false;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1103, 598);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.GrayText;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(1013, 80);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(116, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Đổi mật khẩu";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 770);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NV";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.NV_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageQLKH.ResumeLayout(false);
            this.tabPageQLKH.PerformLayout();
            this.tabPageTKTC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageQLPT;
        private System.Windows.Forms.TabPage tabPageQLKH;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPageTKTC;
        private MaterialSkin.Controls.MaterialListView materialListViewCustomer;
        private System.Windows.Forms.ColumnHeader columnRoomId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCMND;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader STT;
        private MaterialSkin.Controls.MaterialSingleLineTextField phone;
        private MaterialSkin.Controls.MaterialSingleLineTextField cmndOld;
        private MaterialSkin.Controls.MaterialSingleLineTextField name;
        private MaterialSkin.Controls.MaterialSingleLineTextField roomId;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField cmndNew;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}