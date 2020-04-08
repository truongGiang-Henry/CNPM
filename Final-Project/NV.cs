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

            // get phong tro
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM PHONGTRO ");

            SqlConnection conn = new SqlConnection(Program.getConnectionString());
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query.ToString(), conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHONGTRO");
            conn.Close();

            int spaceCol = -100;
            int numRow = 3;
            // create phong tro 
            List<MaterialRaisedButton> buttons = new List<MaterialRaisedButton>();

            foreach (DataRow row in ds.Tables["PHONGTRO"].Rows)
            {
                // get X of button
                spaceCol = getSpaceCol(buttons.Count, spaceCol, numRow);

                MaterialRaisedButton newButton = new MaterialRaisedButton();
                newButton.AutoSize = false;
                //newButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                newButton.Depth = 0;
                newButton.Icon = null;
                newButton.Location = new Point(spaceCol, getSpaceRow(buttons.Count, numRow));
                newButton.MouseState = MouseState.HOVER;
                newButton.Name = "materialRaisedButton1";
                newButton.Primary = true;
                newButton.Size = new Size(80, 80);
                newButton.TabIndex = 0;
                newButton.Text = row["MAPT"].ToString();
                newButton.UseVisualStyleBackColor = true;

                buttons.Add(newButton);
                this.tabPageQLPT.Controls.Add(newButton);
                
               //MaterialMessageBox.Show(newButton.Location.ToString(), "abc");
            }
        }

        private int getSpaceCol(int count, int oldX, int numRow)
        {
            if(count % numRow == 0)
            {
                return 0;
            }
            else
            {
                return oldX + 100;
            }
        }

        private int getSpaceRow(int count, int numRow)
        {
            return 100 * (count / numRow);
        }

        private void NV_Load(object sender, EventArgs e)
        {

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
            changePassword changePassword = new changePassword();
            changePassword.ShowDialog();
        }
    }
}
