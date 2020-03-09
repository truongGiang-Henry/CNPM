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

namespace Final_Project
{
    public partial class Login : Form
    {
        private String serverName;

        public void setServerName(String serverName)
        {
            this.serverName = serverName;
        }
        public Login()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        { 
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
            SqlConnection sql = new SqlConnection(
               @"Data Source=" + this.serverName + ";Initial Catalog=QLPT;Integrated Security=True");
            String query = "Select * from TaiKhoan where username = '" + txtUsername.Text.Trim() + "' and pwd = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
           
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

    }
}
