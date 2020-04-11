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
    public partial class NV : MaterialForm
    {
        private static int numPerRow = 10;

        // room data access object
        private static List<RoomDAO> rooms = new List<RoomDAO>();

        // create button to go to form room 
        private static List<MaterialRaisedButton> buttons = new List<MaterialRaisedButton>();

        public NV()
        {
            InitializeComponent(); 

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // make my form not resizeable
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 250); 
        }

        private void NV_Load(object sender, EventArgs e)
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

        private void qlptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLPT qlpt = new QLPT();
            qlpt.ShowDialog();
        }

        private void qlntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLKH qlkh = new QLKH();
            qlkh.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }

        private void tktcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
