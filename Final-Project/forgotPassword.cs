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

namespace Final_Project
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (userName.Text.Equals("") || email.Text.Equals(""))
            {
                checkValid(userName);
                checkValid(email);
            }
            else
            {
                // build query to check if user exists
                StringBuilder queryId = new StringBuilder();
                queryId.Append("SELECT ID FROM TAIKHOAN WHERE USERNAME LIKE '");
                queryId.Append(userName);
                queryId.Append("'");

                // create connection
                SqlConnection connTmp = new SqlConnection(Program.getConnectionString());
                SqlCommand cmdTmp = connTmp.CreateCommand();
                cmdTmp.CommandText = queryId.ToString();

                // execute command
                connTmp.Open();
                var id = cmdTmp.ExecuteScalar();
                connTmp.Close();

                if (id != null)
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

                    // create connection
                    SqlConnection conn = new SqlConnection(Program.getConnectionString());
                    SqlCommand cmd = conn.CreateCommand();
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

                    MessageBox.Show("Mật khẩu khôi phục đã được gửi");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy username hãy thử lại");
                    userName.Focus();
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
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
                
            return builder.ToString();
        }

        private void checkValid(TextBox textBox)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("bạn cần điền đủ thông tin");
                textBox.Focus();
            }
        }
    }
}
