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
using System.Configuration;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project
{
    public partial class Login : MaterialForm
    {
        public static String userName;
        public Login()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey300, Primary.BlueGrey500,
                Primary.BlueGrey500, Accent.LightBlue400,
                TextShade.WHITE
            );

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 250);

        }

       private void Form1_Load(object sender, EventArgs e)
        {
            materialSingleLineTextFieldUserName.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextFieldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.materialRaisedButtonLogin_Click(sender, e);
            }
        }

        public Boolean checkUsername(String txt)
        {
            Boolean result = true;
            if (txt == null)
            {
                throw new NullReferenceException();
            }
            if (txt.Length < 3)
            {
                result = false;
            }
            return result;
        }
        public Boolean checkPassword(String txt)
        {
            Boolean result = true;
            if (txt == null)
            {
                throw new NullReferenceException();
            }
            if (txt.Length < 3)
            {
                result = false;
            }
            return result;
        }

        public static String getUserName()
        {
            return userName;
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();
        }

        private void materialRaisedButtonLogin_Click(object sender, EventArgs e)
        {
            if (checkUsername(materialSingleLineTextFieldUserName.Text) == false || checkPassword(materialSingleLineTextFieldPassword.Text) == false )
            {
                MaterialMessageBox.Show("Wrong Structure", "Error");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    conn.Open();

                    StringBuilder query = new StringBuilder();
                    query.Append("SELECT ID FROM TAIKHOAN WHERE USERNAME = '");
                    query.Append(materialSingleLineTextFieldUserName.Text.Trim());
                    query.Append("' AND PWD = '");
                    query.Append(materialSingleLineTextFieldPassword.Text.Trim());
                    query.Append("'");

                    SqlDataAdapter sda = new SqlDataAdapter(query.ToString(), conn);
                    DataTable tbl = new DataTable();
                    sda.Fill(tbl);

                    conn.Close();

                    if (tbl.Rows.Count == 1)
                    {
                        // get username for change password form
                        userName = materialSingleLineTextFieldUserName.Text;

                        NV nv = new NV();
                        this.Hide();
                        nv.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        MaterialMessageBox.Show("Check your Username and Password", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
