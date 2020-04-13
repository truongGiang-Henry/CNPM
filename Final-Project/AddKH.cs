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

using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project
{
    public partial class AddKH : MaterialForm
    {
        private Room room;

        public AddKH(Room room)
        {
            InitializeComponent();

            this.room = room;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 300);
        }

        private void AddKH_Load(object sender, EventArgs e)
        {
            name.Focus();
            // load ma pt from db to cbbox
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Program.getConnectionString();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT MAPT FROM PHONGTRO");

            // open connection
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "da");
            conn.Close();

            // set value for combobox
            cbRoomId.ValueMember = "MAPT";
            cbRoomId.DataSource = ds.Tables["da"];
            cbRoomId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomId.Enabled = true;
            cbRoomId.SelectedIndex = cbRoomId.FindString(room.room.Id);
        }

        private void checkFocus(MaterialSingleLineTextField textBox)
        {
            if (textBox.Text.Equals(""))
            {
                textBox.Focus();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Text = "";
            cmnd.Text = "";
            phone.Text = "";
            cbRoomId.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            
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
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    // exec stored proc
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_ADDKHACHHANG @CMND, @HOTEN, @DIENTHOAI, @MAPT";
                    cmd.Parameters.Add("@CMND", SqlDbType.Char, 12).Value = cmnd.Text.ToString();
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = name.Text.ToString();
                    cmd.Parameters.Add("@DIENTHOAI", SqlDbType.VarChar).Value = phone.Text.ToString();
                    cmd.Parameters.Add("@MAPT", SqlDbType.Char, 5).Value = cbRoomId.Text.ToString();

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MaterialMessageBox.Show("Thêm khách hàng thành công ♥", "Thông báo");
                    this.Close();
                }
                catch (SqlException se)
                {
                    MaterialMessageBox.Show(se.Message, "Database");
                }
            }

            //refesh form room
            room.Reload(sender, e);
        }
    }
}
