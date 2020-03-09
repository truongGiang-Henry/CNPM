using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CauHinh : Form
    {
        public CauHinh()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CauHinh_Load(object sender, EventArgs e)
        {

        }

        private void ButtonServer_Click(object sender, EventArgs e)
        {
            string title = serName.Text;
            Login f1 = new Login();
            f1.setServerName(title);
            f1.Show();
            this.Hide();
        }

        private void serName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
