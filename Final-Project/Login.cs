using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.getConnectionString());
                conn.Open();

                StringBuilder query = new StringBuilder();
                query.Append("SELECT * FROM TAIKHOAN WHERE USERNAME = '");
                query.Append(txtUsername.Text.Trim());
                query.Append("' AND PWD = '");
                query.Append(txtPassword.Text.Trim());
                query.Append("'");

                SqlDataAdapter sda = new SqlDataAdapter(query.ToString(), conn);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                conn.Close();

                if (tbl.Rows.Count == 1)
                {

                    NV nv = new NV();
                    this.Hide();
                    nv.ShowDialog();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Check your Username and Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword forgot = new forgotPassword();
            forgot.ShowDialog();
        }
    }
}
