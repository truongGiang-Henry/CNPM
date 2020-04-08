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
            this.tabPageQLNV = new System.Windows.Forms.TabPage();
            this.tabPageTKTC = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.AllowDrop = true;
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.materialTabControl1.Controls.Add(this.tabPageQLPT);
            this.materialTabControl1.Controls.Add(this.tabPageQLNV);
            this.materialTabControl1.Controls.Add(this.tabPageTKTC);
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
            // tabPageQLNV
            // 
            this.tabPageQLNV.Location = new System.Drawing.Point(4, 28);
            this.tabPageQLNV.Name = "tabPageQLNV";
            this.tabPageQLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQLNV.Size = new System.Drawing.Size(1035, 425);
            this.tabPageQLNV.TabIndex = 1;
            this.tabPageQLNV.Text = "Quản lý nhân viên";
            this.tabPageQLNV.UseVisualStyleBackColor = true;
            // 
            // tabPageTKTC
            // 
            this.tabPageTKTC.Location = new System.Drawing.Point(4, 28);
            this.tabPageTKTC.Name = "tabPageTKTC";
            this.tabPageTKTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTKTC.Size = new System.Drawing.Size(1035, 425);
            this.tabPageTKTC.TabIndex = 2;
            this.tabPageTKTC.Text = "Thống kê thu chi";
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
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageQLPT;
        private System.Windows.Forms.TabPage tabPageQLNV;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPageTKTC;
    }
}