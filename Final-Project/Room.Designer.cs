namespace Final_Project
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.labelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.labelNumberOfPeople = new MaterialSkin.Controls.MaterialLabel();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialListViewCustomer = new MaterialSkin.Controls.MaterialListView();
            this.columnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButtonAddCustomer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButtonBill = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Depth = 0;
            this.labelPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPrice.Location = new System.Drawing.Point(9, 235);
            this.labelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 19);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "so tien";
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Depth = 0;
            this.labelNumberOfPeople.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNumberOfPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberOfPeople.Location = new System.Drawing.Point(9, 200);
            this.labelNumberOfPeople.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(67, 19);
            this.labelNumberOfPeople.TabIndex = 1;
            this.labelNumberOfPeople.Text = "so nguoi";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(9, 272);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(48, 19);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "mo ta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(656, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialListViewCustomer
            // 
            this.materialListViewCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.materialListViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSTT,
            this.columnName,
            this.columnCMND,
            this.columnPhoneNumber});
            this.materialListViewCustomer.Depth = 0;
            this.materialListViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListViewCustomer.FullRowSelect = true;
            this.materialListViewCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListViewCustomer.HideSelection = false;
            this.materialListViewCustomer.Location = new System.Drawing.Point(386, 200);
            this.materialListViewCustomer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewCustomer.Name = "materialListViewCustomer";
            this.materialListViewCustomer.OwnerDraw = true;
            this.materialListViewCustomer.Size = new System.Drawing.Size(626, 318);
            this.materialListViewCustomer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.materialListViewCustomer.TabIndex = 5;
            this.materialListViewCustomer.UseCompatibleStateImageBehavior = false;
            this.materialListViewCustomer.View = System.Windows.Forms.View.Details;
            // 
            // columnSTT
            // 
            this.columnSTT.Text = "STT";
            this.columnSTT.Width = 82;
            // 
            // columnName
            // 
            this.columnName.Text = "Họ tên";
            this.columnName.Width = 183;
            // 
            // columnCMND
            // 
            this.columnCMND.Text = "CMND";
            this.columnCMND.Width = 149;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Số điện thoại";
            this.columnPhoneNumber.Width = 218;
            // 
            // materialRaisedButtonAddCustomer
            // 
            this.materialRaisedButtonAddCustomer.AutoSize = true;
            this.materialRaisedButtonAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAddCustomer.Depth = 0;
            this.materialRaisedButtonAddCustomer.Icon = null;
            this.materialRaisedButtonAddCustomer.Location = new System.Drawing.Point(22, 362);
            this.materialRaisedButtonAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddCustomer.Name = "materialRaisedButtonAddCustomer";
            this.materialRaisedButtonAddCustomer.Primary = true;
            this.materialRaisedButtonAddCustomer.Size = new System.Drawing.Size(138, 36);
            this.materialRaisedButtonAddCustomer.TabIndex = 6;
            this.materialRaisedButtonAddCustomer.Text = "Thêm khách trọ";
            this.materialRaisedButtonAddCustomer.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddCustomer.Click += new System.EventHandler(this.materialRaisedButtonAddCustomer_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.SystemColors.Control;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialDivider1.Location = new System.Drawing.Point(10, 352);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(349, 165);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButtonBill
            // 
            this.materialRaisedButtonBill.AutoSize = true;
            this.materialRaisedButtonBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonBill.Depth = 0;
            this.materialRaisedButtonBill.Icon = null;
            this.materialRaisedButtonBill.Location = new System.Drawing.Point(265, 362);
            this.materialRaisedButtonBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonBill.Name = "materialRaisedButtonBill";
            this.materialRaisedButtonBill.Primary = true;
            this.materialRaisedButtonBill.Size = new System.Drawing.Size(81, 36);
            this.materialRaisedButtonBill.TabIndex = 8;
            this.materialRaisedButtonBill.Text = "Hóa Đơn";
            this.materialRaisedButtonBill.UseVisualStyleBackColor = true;
            this.materialRaisedButtonBill.Click += new System.EventHandler(this.materialRaisedButtonBill_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 530);
            this.Controls.Add(this.materialRaisedButtonBill);
            this.Controls.Add(this.materialRaisedButtonAddCustomer);
            this.Controls.Add(this.materialListViewCustomer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialDivider1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelPrice;
        private MaterialSkin.Controls.MaterialLabel labelNumberOfPeople;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialListView materialListViewCustomer;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCMND;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnSTT;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddCustomer;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonBill;
    }
}