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
    public partial class NV : Form
    {
        public NV()
        {
            InitializeComponent();
        }

        private void NV_Load(object sender, EventArgs e)
        {

        }

        private void qlptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLPT qlpt = new QLPT();
            qlpt.ShowDialog();
        }

        private void qlntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLKH qlkh = new QLKH();
            qlkh.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void tktcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword changePassword = new changePassword();
            changePassword.ShowDialog();
        }
    }
}
