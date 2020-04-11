using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project
{
    public partial class FormOK : MaterialForm
    {
        public FormOK()
        {
            InitializeComponent();

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(800, 350);
        }

        public void setMessage(string message)
        {
            materialLabel1.Text = message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
