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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project
{
    public partial class HoaDon : MaterialForm
    {
        private String roomId;

        public HoaDon(String id)
        {
            InitializeComponent();

            roomId = id;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 250);
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            // load ho ten from db to cbbox
            SqlConnection conn = new SqlConnection(Program.getConnectionString());

            StringBuilder query = new StringBuilder();
            query.Append("SELECT CMND FROM KHACHHANG WHERE MAPT LIKE '");
            query.Append(roomId);
            query.Append("'");

            // open connection
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "da");
            conn.Close();

            // set value for combobox
            comboBoxCMND.ValueMember = "CMND";
            comboBoxCMND.DataSource = ds.Tables["da"];
            comboBoxCMND.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCMND.Enabled = true;
            comboBoxCMND.SelectedIndex = 0;

            // load ma pt from db to cbbox
            query.Clear();
            query.Append("SELECT MAPT FROM PHONGTRO");

            // open connection
            conn.Open();
            SqlDataAdapter dapt = new SqlDataAdapter(query.ToString(), conn);
            DataSet dspt = new DataSet();
            dapt.Fill(dspt, "dapt");
            conn.Close();

            // set value for combobox
            comboBoxRoomId.ValueMember = "MAPT";
            comboBoxRoomId.DataSource = dspt.Tables["dapt"];
            comboBoxRoomId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomId.Enabled = true;
            comboBoxRoomId.SelectedIndex = comboBoxRoomId.FindString(roomId);

            // get name by cmnd
            getNameByCMND();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxCMND.Text.Equals("") || comboBoxRoomId.Text.Equals(""))
            {
                MaterialMessageBox.Show("Bận cần điền đủ thông tin", "Thông báo");
            }
            else
            {

                SqlConnection conn = new SqlConnection(Program.getConnectionString());
                // exec stored proc
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC SP_ADDHOADON @CMND, @MAPT";
                cmd.Parameters.Add("@CMND", SqlDbType.Char, 12).Value = comboBoxCMND.Text.ToString();
                cmd.Parameters.Add("@MAPT", SqlDbType.NVarChar, 50).Value = comboBoxRoomId.Text.ToString();

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                MaterialMessageBox.Show("Thêm hóa đơn thành công ♥", "Thông báo");
                this.Close();
            }
        }

        private void comboBoxCMND_SelectedValueChanged(object sender, EventArgs e)
        {
            getNameByCMND();
        }

        private void getNameByCMND()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.getConnectionString());
                StringBuilder query = new StringBuilder();
                // create query to get number of people in phong tro
                query.Clear();
                query.Append("SELECT HOTEN FROM KHACHHANG WHERE CMND LIKE '");
                query.Append(comboBoxCMND.Text);
                query.Append("'");

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query.ToString();

                //open connection
                conn.Open();
                String name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                materialLabel3.Text = name;
            }
            catch(NullReferenceException e)
            {
                MaterialMessageBox.Show(e.Message, "Thông báo");
            }
        }
    }
}
