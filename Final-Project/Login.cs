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
        private String connectionString;

        public Login()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Final_Project.Properties.Settings.QLPTConnectionString"].ConnectionString;
            //MessageBox.Show(connectionString);
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
                SqlConnection sql = new SqlConnection(this.connectionString);
               
                sql.Open();
                String query = "Select * from TaiKhoan where username = '" + txtUsername.Text.Trim() + "' and pwd = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);
                sql.Close();
                if (tbl.Rows.Count == 1)
                {

                    NV nv = new NV();
                    this.Hide();
                    nv.ShowDialog();
                    sql.Close();

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
    }
}
