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
            this.materialListViewCustomer = new MaterialSkin.Controls.MaterialListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageTKTC = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPageQLKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.AllowDrop = true;
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.materialTabControl1.Controls.Add(this.tabPageQLPT);
            this.materialTabControl1.Controls.Add(this.tabPageQLKH);
            this.materialTabControl1.Controls.Add(this.tabPageTKTC);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(12, 122);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1043, 457);
            this.materialTabControl1.TabIndex = 13;
            // 
            // tabPageQLPT
            // 
            this.tabPageQLPT.Location = new System.Drawing.Point(4, 28);
            this.tabPageQLPT.Name = "tabPageQLPT";
            this.tabPageQLPT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLPT.Size = new System.Drawing.Size(1035, 425);
            this.tabPageQLPT.TabIndex = 0;
            this.tabPageQLPT.Text = "Quản lý phòng trọ";
            this.tabPageQLPT.UseVisualStyleBackColor = true;
            // 
            // tabPageQLKH
            // 
            this.tabPageQLKH.Controls.Add(this.materialListViewCustomer);
            this.tabPageQLKH.Location = new System.Drawing.Point(4, 28);
            this.tabPageQLKH.Name = "tabPageQLKH";
            this.tabPageQLKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLKH.Size = new System.Drawing.Size(1035, 425);
            this.tabPageQLKH.TabIndex = 1;
            this.tabPageQLKH.Text = "Quản lý khách hàng";
            this.tabPageQLKH.UseVisualStyleBackColor = true;
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
            this.materialListViewCustomer.Location = new System.Drawing.Point(6, 6);
            this.materialListViewCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewCustomer.Name = "materialListViewCustomer";
            this.materialListViewCustomer.OwnerDraw = true;
            this.materialListViewCustomer.Size = new System.Drawing.Size(693, 423);
            this.materialListViewCustomer.TabIndex = 0;
            this.materialListViewCustomer.UseCompatibleStateImageBehavior = false;
            this.materialListViewCustomer.View = System.Windows.Forms.View.Details;
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
            // tabPageTKTC
            // 
            this.tabPageTKTC.Location = new System.Drawing.Point(4, 28);
            this.tabPageTKTC.Name = "tabPageTKTC";
            this.tabPageTKTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTKTC.Size = new System.Drawing.Size(1035, 425);
            this.tabPageTKTC.TabIndex = 2;
            this.tabPageTKTC.Text = "Thống kê ";
            this.tabPageTKTC.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1035, 425);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Đổi mật khẩu";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1068, 48);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NV";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.NV_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageQLKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageQLPT;
        private System.Windows.Forms.TabPage tabPageQLKH;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPageTKTC;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialListView materialListViewCustomer;
        private System.Windows.Forms.ColumnHeader columnRoomId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCMND;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader STT;
    }
}