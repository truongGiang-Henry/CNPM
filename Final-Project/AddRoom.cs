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
    public partial class AddRoom : MaterialForm
    {
        private NV nv;
        private RoomDAO roomDAO;
        private bool isUpdate = false;

        // constructors

        public AddRoom(NV nv)
        {
            InitializeComponent();

            this.nv = nv;
            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(600, 250);
        }

        public AddRoom(RoomDAO roomDAO)
        {
            InitializeComponent();

            this.roomDAO = roomDAO;
            this.isUpdate = true;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(600, 250);
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // pass data if update room
            if (isUpdate == true)
            {
                price.Text = roomDAO.Price.ToString();
                numberOfPeople.Text = roomDAO.NumberOfPeople.ToString();
                description.Text = roomDAO.Description.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (price.Text.Equals("") || numberOfPeople.Text.Equals("") || description.Text.Equals(""))
            {
                MaterialMessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if (isUpdate == false)
                {
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_ADDPHONGTRO @GIATHUE, @SONGUOI, @MOTA";
                    cmd.Parameters.Add("@GIATHUE", SqlDbType.Float).Value = price.Text.ToString();
                    cmd.Parameters.Add("@SONGUOI", SqlDbType.Int).Value = numberOfPeople.Text.ToString();
                    cmd.Parameters.Add("@MOTA", SqlDbType.NVarChar, 100).Value = description.Text.ToString();

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    nv.RefeshListRoom();
                    MaterialMessageBox.Show("Thêm phòng thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_UPDATEPHONGTRO @GIATHUE, @SONGUOI, @MOTA, @MAPT";
                    cmd.Parameters.Add("@GIATHUE", SqlDbType.Float).Value = price.Text.ToString();
                    cmd.Parameters.Add("@SONGUOI", SqlDbType.Int).Value = numberOfPeople.Text.ToString();
                    cmd.Parameters.Add("@MOTA", SqlDbType.NVarChar, 100).Value = description.Text.ToString();
                    cmd.Parameters.Add("@MAPT", SqlDbType.Char, 5).Value = roomDAO.Id.ToString();

                    MessageBox.Show(cmd.CommandText);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    nv.RefeshListRoom();
                    MaterialMessageBox.Show("Cập nhật phòng thành công", "Thông báo");
                    this.Close();
                }
            }
                

            
        }
    }
}
