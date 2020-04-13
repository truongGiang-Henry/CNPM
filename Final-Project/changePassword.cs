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
    public partial class ChangePassword : MaterialForm
    {
        private String userName = Login.getUserName();

        public ChangePassword()
        {
            InitializeComponent();

            // set the start position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 350);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (oldPassword.Text.Equals("") || newPassword.Text.Equals("") || newPasswordConfirm.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin vui lòng kiểm tra!");
                checkFocus(oldPassword);
                checkFocus(newPassword);
                checkFocus(newPasswordConfirm);
            }
            else
            {
                
                StringBuilder query = new StringBuilder();
                query.Append("SELECT COUNT(*) FROM TAIKHOAN WHERE USERNAME LIKE '");
                query.Append(userName);
                query.Append("'");
                query.Append("AND PWD LIKE '");
                query.Append(oldPassword.Text);
                query.Append("'");

                SqlConnection conn = new SqlConnection(Program.getConnectionString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query.ToString();

                conn.Open();
                String count = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                if (count.Equals("0"))
                {
                    MaterialMessageBox.Show("Sai mật khẩu ☻", "Thông báo");
                }
                else
                {
                    if(oldPassword.Text.Equals(newPassword.Text))
                    {
                        MaterialMessageBox.Show("Bạn nhập 2 mật khẩu trùng nhau", "Thông báo");
                    }
                    else
                    {
                        if (newPassword.Text.Equals(newPasswordConfirm.Text))
                        {
                            cmd.CommandText = "EXEC SP_CHANGEPASSWORD @OLDPASSWORD , @NEWPASSWORD , @USERNAME ";
                            cmd.Parameters.Add("@OLDPASSWORD", SqlDbType.VarChar, 100).Value = oldPassword.Text.ToString();
                            cmd.Parameters.Add("@NEWPASSWORD", SqlDbType.VarChar, 100).Value = newPassword.Text.ToString();
                            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 100).Value = userName;

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            // clear field
                            oldPassword.Text = "";
                            newPassword.Text = "";
                            newPasswordConfirm.Text = "";
                            this.Close();

                            MaterialMessageBox.Show("Mật khẩu đã được đổi", "Thông báo");
                        }
                    }
                }
            }
        }

        private void checkFocus(MaterialSingleLineTextField textBox)
        {
            if (textBox.Text.Equals(""))
            {
                textBox.Focus();
            }
        }
    }
}
