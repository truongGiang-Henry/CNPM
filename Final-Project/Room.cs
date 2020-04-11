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
    public partial class Room : MaterialForm
    {
        private RoomDAO room;

        private List<CustomerDAO> customers = new List<CustomerDAO>();

        public Room(RoomDAO room)
        {
            InitializeComponent();

            this.room = room;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " "+ room.Id;
            labelPrice.Text = "Giá thuê: " + String.Format("{0:N}", room.Price) +" VNĐ";
            labelNumberOfPeople.Text = "Số người: " + room.NumberOfPeople.ToString();
            labelDescription.Text = "Mô tả : " + room.Description;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM KHACHHANG WHERE MAPT LIKE '");
            query.Append(room.Id);
            query.Append("'");

            SqlConnection conn = new SqlConnection(Program.getConnectionString());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "KHACHHANG");
            conn.Close();

            foreach(DataRow rows in ds.Tables["KHACHHANG"].Rows)
            {
                CustomerDAO customer = new CustomerDAO();
                customer.CMND = rows["CMND"].ToString();
                customer.Name = rows["HOTEN"].ToString();
                customer.PhoneNumber = rows["DIENTHOAI"].ToString();
                customer.RoomId = rows["MAPT"].ToString();
                customers.Add(customer);

                
            }

            seedListView();
        }

        private void seedListView()
        {
            List<string[]> data = new List<string[]>();
            int i = 1;
            foreach (CustomerDAO customer in customers)
            {
                data.Add(new string[] { i.ToString(),customer.Name, customer.CMND, customer.PhoneNumber });
                i++;
            }

            foreach (string[] row in data)
            {
                ListViewItem item = new ListViewItem(row);
                materialListViewCustomer.Items.Add(item);
            }
        }
    }
}
