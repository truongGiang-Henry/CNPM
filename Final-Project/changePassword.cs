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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (oldPasssword.Text.Equals("") || newPassword.Text.Equals("") || newPasswordConfirm.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin vui lòng kiểm tra!");
                checkFocus(oldPasssword);
                checkFocus(newPassword);
                checkFocus(newPasswordConfirm);
            }
            else
            {
                String userName = Login.getUserName();
                StringBuilder query = new StringBuilder();
                query.Append("SELECT COUNT(*) FROM TAIKHOAN WHERE USERNAME LIKE '");
                query.Append(userName);
                query.Append("'");
                query.Append("AND PWD LIKE '");
                query.Append(oldPasssword.Text);
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
    }
}
