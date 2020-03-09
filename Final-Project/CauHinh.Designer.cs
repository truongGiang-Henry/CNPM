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
            this.serName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name";
            // 
            // serName
            // 
            this.serName.Location = new System.Drawing.Point(278, 49);
            this.serName.Name = "serName";
            this.serName.Size = new System.Drawing.Size(303, 26);
            this.serName.TabIndex = 2;
            this.serName.Text = "TRUONGGIANG\\SQLEXPRESS";
            this.serName.TextChanged += new System.EventHandler(this.serName_TextChanged);
            // 
            // ButtonServer
            // 
            this.ButtonServer.Location = new System.Drawing.Point(428, 111);
            this.ButtonServer.Name = "ButtonServer";
            this.ButtonServer.Size = new System.Drawing.Size(181, 62);
            this.ButtonServer.TabIndex = 4;
            this.ButtonServer.Text = "Submit";
            this.ButtonServer.UseVisualStyleBackColor = true;
            this.ButtonServer.Click += new System.EventHandler(this.ButtonServer_Click);
            // 
            // CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.Controls.Add(this.ButtonServer);
            this.Controls.Add(this.serName);
            this.Controls.Add(this.label1);
            this.Name = "CauHinh";
            this.Text = "CauHinh";
            this.Load += new System.EventHandler(this.CauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonServer;
    }
}