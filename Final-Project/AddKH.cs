using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AddKH : Form
    {
        public AddKH()
        {
            InitializeComponent();
        }

        private void AddKH_Load(object sender, EventArgs e)
        {
            name.Focus();
            // load ma pt from db to cbbox
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Program.getConnectionString();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT MAPT FROM PHONGTRO");

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "da");
            roomId.ValueMember = "MAPT";
            roomId.DataSource = ds.Tables["da"];
            roomId.DropDownStyle = ComboBoxStyle.DropDownList;
            roomId.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.getConnectionString());
            // check valid data
            if (name.Text.Equals("") || phone.Text.Equals("") || cmnd.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần điền đủ dữ liệu");
                checkFocus(name);
                checkFocus(phone);
                checkFocus(cmnd);
            }
            else
            {
                try
                {
                    // exec stored proc
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_ADDKHACHHANG @CMND, @HOTEN, @DIENTHOAI, @MAPT";
                    cmd.Parameters.Add("@CMND", SqlDbType.Char, 12).Value = cmnd.Text.ToString();
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = name.Text.ToString();
                    cmd.Parameters.Add("@DIENTHOAI", SqlDbType.VarChar).Value = phone.Text.ToString();
                    cmd.Parameters.Add("@MAPT", SqlDbType.Char, 5).Value = roomId.Text.ToString();

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    // clear field
                    clear.PerformClick();

                    MessageBox.Show("Thêm khách hàng thành công ♥♫");
                }
                catch(SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
        }

        private void checkFocus(TextBox textBox)
        {
            if (textBox.Text.Equals(""))
            {
                textBox.Focus();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.CharacterCasing = CharacterCasing.Upper;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Text = "";
            cmnd.Text = "";
            phone.Text = "";
            roomId.Text = "";
        }
    }
}
