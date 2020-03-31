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
    public partial class QLPT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = Program.getConnectionString();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PhongTro";
            adapter.SelectCommand = command;

            table.Clear();
            adapter.Fill(table);
            dgv.DataSource =  table;
        }
 

        public QLPT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            NV nv = new NV();
            this.Hide();
            nv.ShowDialog();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            Login f1 = new Login();
            this.Hide();
            f1.ShowDialog();
            connection.Close();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPT pt = new AddPT();
            pt.Show();
            connection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLPT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPT.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtMaPT.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtGT.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtSoNT.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtMota.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into PhongTro( giaThue,soNguoi, moTa) values ('" + txtGT.Text + "' , '" + txtSoNT.Text+ "' , '" + txtMota.Text + "')";  
            command.ExecuteNonQuery(); 
            loadData();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from PhongTro where maPT = '"+ txtMaPT.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PhongTro set giaThue = '" + txtGT.Text + "' ,soNguoi = '" + txtSoNT.Text + "' ,moTa = '" + txtMota.Text + "' where maPT = '" + txtMaPT.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
