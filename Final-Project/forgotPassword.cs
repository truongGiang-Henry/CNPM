using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project
{
    public partial class ForgotPassword : MaterialForm
    {
        public ForgotPassword()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (userName.Text.Equals("") || email.Text.Equals(""))
            {
                CheckValid(userName);
                CheckValid(email);
            }
            else
            {
                // build query to check if user exists
                StringBuilder queryId = new StringBuilder();
                queryId.Append("SELECT COUNT(*) FROM TAIKHOAN WHERE USERNAME LIKE '");
                queryId.Append(userName.Text);
                queryId.Append("'");

                // create connection
                SqlConnection conn = new SqlConnection(Program.getConnectionString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryId.ToString();

                // execute command
                conn.Open();
                String count = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                if (count.Equals("0"))
                {
                    MaterialMessageBox.Show("Không tìm thấy username hãy thử lại", "Thông báo");
                    userName.Focus();
                }
                else
                {
                    // build a random password
                    StringBuilder passBuilder = new StringBuilder();
                    passBuilder.Append(RandomString(4, true));
                    passBuilder.Append(new Random().Next(1000, 9999));
                    passBuilder.Append(RandomString(2, false));

                    // build query to set new password
                    StringBuilder query = new StringBuilder();
                    query.Append("UPDATE TAIKHOAN SET PWD = '");
                    query.Append(passBuilder);
                    query.Append("'");
                    query.Append("WHERE USERNAME LIKE '");
                    query.Append(userName.Text);
                    query.Append("'");

                    // create new query for command
                    cmd.CommandText = query.ToString();

                    // open connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // create mail message
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("tailieucodez@gmail.com");
                    msg.To.Add(email.Text);
                    msg.Subject = "[RECOVER PASSWORD]";
                    msg.Body = ("userName : " + userName.Text + "<br>" + "Recovery password: " + passBuilder);
                    msg.IsBodyHtml = true;

                    // create SMTP client
                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";

                    // create Network Credential
                    NetworkCredential ntwd = new NetworkCredential();
                    ntwd.UserName = "tailieucodez@gmail.com";
                    ntwd.Password = "Tailieucodez123";

                    // set specification for smtp client
                    smt.UseDefaultCredentials = true;
                    smt.Credentials = ntwd;
                    smt.Port = 587;
                    smt.EnableSsl = true;
                    smt.Send(msg);

                    MaterialMessageBox.Show("Mật khẩu khôi phục đã được gửi", "Thông báo");
                    this.Close();
                }
            }
        }

        // Generate a random string with a given size  
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            // if lowercase == true return a lowercase
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
                
            return builder.ToString();
        }

        private void CheckValid(MaterialSingleLineTextField textBox)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("bạn cần điền đủ thông tin");
                textBox.Focus();
            }
        }
    }
}
