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
    public partial class NV : MaterialForm
    {
        private static int numPerRow = 11;

        private List<CustomerDAO> customers = new List<CustomerDAO>();

        // room data access object
        private static List<RoomDAO> rooms = new List<RoomDAO>();

        // create button to go to form room 
        private static List<MaterialRaisedButton> buttons = new List<MaterialRaisedButton>();

        public NV()
        {
            InitializeComponent(); 

            // Create a material theme manager and add the form to manage (this)
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // make my form not resizeable
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150); 
        }
        
        private void NV_Load(object sender, EventArgs e)
        {
            // tabPage QLPT
            RenderDataQLPT();

            // tabPageQLKH
            RenderDataQLKH();

            // tabPageTK

            DataTable dt = new DataTable();
            ReportDocument objRep = new CrystalReportThongKe();
            ConnectionInfo mycon = new ConnectionInfo();
            TableLogOnInfo myinfo = new TableLogOnInfo();
            mycon.IntegratedSecurity = true;
            //mycon.UserID = "RUBY";
            //mycon.Password = "123456789";
            mycon.ServerName = "ADMIN";
            mycon.DatabaseName = "QLPT";
            myinfo.ConnectionInfo = mycon;
            objRep.Database.Tables[0].ApplyLogOnInfo(myinfo);
            crystalReportViewer.ReportSource = objRep;
            crystalReportViewer.Refresh();

        }

        private void RenderDataQLPT()
        {
            // get phong tro
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM PHONGTRO ");

            SqlConnection conn = new SqlConnection(Program.getConnectionString());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHONGTRO");
            conn.Close();

            int spaceCol = -50;

            foreach (DataRow row in ds.Tables["PHONGTRO"].Rows)
            {
                // pass data to roomDAO
                RoomDAO room = new RoomDAO();
                room.Id = row["MAPT"].ToString();
                room.Price = Convert.ToDecimal(row["GIATHUE"]);
                room.NumberOfPeople = Convert.ToInt32(row["SONGUOI"]);
                room.Description = row["MOTA"].ToString();
                rooms.Add(room);

                // get X of button
                spaceCol = getSpaceCol(buttons.Count, spaceCol, numPerRow);

                MaterialRaisedButton newButton = new MaterialRaisedButton();
                newButton.AutoSize = false;
                //newButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                newButton.Depth = 0;
                newButton.Icon = null;
                newButton.Location = new Point(spaceCol, getSpaceRow(buttons.Count, numPerRow));
                newButton.MouseState = MouseState.HOVER;
                newButton.Name = row["MAPT"].ToString();
                newButton.Primary = true;
                newButton.Size = new Size(80, 80);
                newButton.TabIndex = 0;
                newButton.Text = row["MAPT"].ToString();
                newButton.UseVisualStyleBackColor = true;

                // Add a Button Click Event handler
                newButton.Click += new EventHandler(newButton_Click);

                buttons.Add(newButton);
                this.tabPageQLPT.Controls.Add(newButton);
            }

            // add button to add a new room

            // get X of button
            spaceCol = getSpaceCol(buttons.Count, spaceCol, numPerRow);

            MaterialRaisedButton addButton = new MaterialRaisedButton();
            addButton.AutoSize = false;
            //newButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.Depth = 0;
            addButton.Icon = null;
            addButton.Location = new Point(spaceCol, getSpaceRow(buttons.Count, numPerRow));
            addButton.MouseState = MouseState.HOVER;
            addButton.Name = "addRoom";
            addButton.Primary = true;
            addButton.Size = new Size(80, 80);
            addButton.TabIndex = 0;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;

            addButton.Click += new EventHandler(addButton_Click);
            buttons.Add(addButton);

            this.tabPageQLPT.Controls.Add(addButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRoom newRoom = new AddRoom(this);
            newRoom.ShowDialog();
        }

        private void RenderDataQLKH()
        {

            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM KHACHHANG");
            query.Append(" ORDER BY MAPT ASC");

            SqlConnection conn = new SqlConnection(Program.getConnectionString());
            conn.Open();
            SqlDataAdapter daCustomer = new SqlDataAdapter(query.ToString(), conn);
            DataSet dsCustommer = new DataSet();
            daCustomer.Fill(dsCustommer, "KHACHHANG");
            conn.Close();


            foreach (DataRow rows in dsCustommer.Tables["KHACHHANG"].Rows)
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
                data.Add(new string[] { i.ToString(), customer.RoomId, customer.Name, customer.CMND, customer.PhoneNumber });
                i++;
            }

            foreach (string[] row in data)
            {
                ListViewItem item = new ListViewItem(row);
                materialListViewCustomer.Items.Add(item);
            }
        }

        // return x value of dynamic button
        private int getSpaceCol(int count, int oldX, int numPerRow)
        {
            if (count % numPerRow == 0)
            {
                return 0;
            }
            else
            {
                return oldX + 100;
            }
        }
        
        // return y value of dynamic button
        private int getSpaceRow(int count, int numPerRow)
        {
            return 100 * (count / numPerRow);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MaterialRaisedButton pressedButton = (MaterialRaisedButton)sender;

            // create form for pressed button
            foreach (RoomDAO room in rooms)
            {
                if (room.Id.Equals(pressedButton.Text))
                {
                    Room roomForm = new Room(room);
                    roomForm.ShowDialog();
                    break;
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }

        private void materialListViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewCustomer.SelectedItems.Count == 0)
                return;

            ListViewItem item = materialListViewCustomer.SelectedItems[0];
            //fill the text boxes
            roomId.Text = item.SubItems[1].Text;
            name.Text = item.SubItems[2].Text;
            cmndOld.Text = item.SubItems[3].Text;
            cmndNew.Text = item.SubItems[3].Text;
            phone.Text = item.SubItems[4].Text;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(roomId.Text.Equals("") || name.Text.Equals("") || cmndOld.Text.Equals("") || phone.Text.Equals(""))
            {
                MaterialMessageBox.Show("Bạn phải điền đủ thông tin", "Thông báo");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_UPDATEKHACHHANG @OLDCMND, @NEWCMND, @HOTEN, @DIENTHOAI, @MAPT";
                    cmd.Parameters.Add("@OLDCMND", SqlDbType.Char, 12).Value = cmndOld.Text.ToString();
                    cmd.Parameters.Add("@NEWCMND", SqlDbType.Char, 12).Value = cmndNew.Text.ToString();
                    cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 50).Value = name.Text.ToString();
                    cmd.Parameters.Add("@DIENTHOAI", SqlDbType.VarChar, 15).Value = phone.Text.ToString();
                    cmd.Parameters.Add("@MAPT", SqlDbType.Char, 12).Value = roomId.Text.ToString();

                    //open connectin
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // clear field
                    roomId.Text = "";
                    name.Text = "";
                    cmndOld.Text = "";
                    cmndNew.Text = "";
                    phone.Text = "";

                    // render data
                    materialListViewCustomer.Items.Clear();
                    customers.Clear();
                    RenderDataQLKH();

                    MaterialMessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                catch(SqlException se)
                {
                    MaterialMessageBox.Show(se.Message, "Database error");
                }
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (roomId.Text.Equals("") || name.Text.Equals("") || cmndOld.Text.Equals("") || phone.Text.Equals(""))
            {
                MaterialMessageBox.Show("Bạn chọn người xóa", "Thông báo");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXEC SP_DELETEKHACHHANG @CMND";
                    cmd.Parameters.Add("@CMND", SqlDbType.Char, 12).Value = cmndOld.Text.ToString();

                    //open connectin
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // clear field
                    roomId.Text = "";
                    name.Text = "";
                    cmndOld.Text = "";
                    cmndNew.Text = "";
                    phone.Text = "";

                    // render data
                    materialListViewCustomer.Items.Clear();
                    customers.Clear();
                    RenderDataQLKH();

                    MaterialMessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (SqlException se)
                {
                    MaterialMessageBox.Show(se.Message, "Database error");
                }
            }
        }

        public void RefeshListRoom()
        {
            rooms.Clear();
            buttons.Clear();
            tabPageQLPT.Controls.Clear();
            RenderDataQLPT();
        }
    }
}
