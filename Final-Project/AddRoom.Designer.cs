namespace Final_Project
{
    partial class AddRoom
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
            this.price = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numberOfPeople = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(64, 113);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Giá thuê";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(64, 170);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Số người";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(64, 231);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Mô tả";
            // 
            // price
            // 
            this.price.Depth = 0;
            this.price.Hint = "";
            this.price.Location = new System.Drawing.Point(172, 113);
            this.price.MaxLength = 32767;
            this.price.MouseState = MaterialSkin.MouseState.HOVER;
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.SelectedText = "";
            this.price.SelectionLength = 0;
            this.price.SelectionStart = 0;
            this.price.Size = new System.Drawing.Size(219, 23);
            this.price.TabIndex = 3;
            this.price.TabStop = false;
            this.price.UseSystemPasswordChar = false;
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.Depth = 0;
            this.numberOfPeople.Hint = "";
            this.numberOfPeople.Location = new System.Drawing.Point(172, 170);
            this.numberOfPeople.MaxLength = 32767;
            this.numberOfPeople.MouseState = MaterialSkin.MouseState.HOVER;
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.PasswordChar = '\0';
            this.numberOfPeople.SelectedText = "";
            this.numberOfPeople.SelectionLength = 0;
            this.numberOfPeople.SelectionStart = 0;
            this.numberOfPeople.Size = new System.Drawing.Size(219, 23);
            this.numberOfPeople.TabIndex = 4;
            this.numberOfPeople.TabStop = false;
            this.numberOfPeople.UseSystemPasswordChar = false;
            // 
            // description
            // 
            this.description.Depth = 0;
            this.description.Hint = "";
            this.description.Location = new System.Drawing.Point(172, 231);
            this.description.MaxLength = 32767;
            this.description.MouseState = MaterialSkin.MouseState.HOVER;
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.SelectedText = "";
            this.description.SelectionLength = 0;
            this.description.SelectionStart = 0;
            this.description.Size = new System.Drawing.Size(219, 23);
            this.description.TabIndex = 5;
            this.description.TabStop = false;
            this.description.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(229, 287);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(47, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 338);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.description);
            this.Controls.Add(this.numberOfPeople);
            this.Controls.Add(this.price);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField price;
        private MaterialSkin.Controls.MaterialSingleLineTextField numberOfPeople;
        private MaterialSkin.Controls.MaterialSingleLineTextField description;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
    }
}