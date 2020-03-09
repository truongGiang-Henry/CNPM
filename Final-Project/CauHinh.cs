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

using System.Configuration;

namespace Final_Project
{
    public partial class CauHinh : Form
    {
        Configuration config;
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        String sectionName = "connectionStrings";
        public CauHinh()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CauHinh_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings["Final_Project.Properties.Settings.QLPTConnectionString"].ConnectionString != "")
            {
                Login f1 = new Login();
                f1.Show();
                this.Hide();

            }
        }

        private void ButtonServer_Click(object sender, EventArgs e)
        {
            connectionStringBuilder.DataSource = serverTextBox.Text;
            connectionStringBuilder.InitialCatalog = DBTextBox.Text;
            connectionStringBuilder.UserID = userIdTextBox.Text;
            connectionStringBuilder.Password = passwordTextBox.Text;
            connectionStringBuilder.IntegratedSecurity = true;

            config.ConnectionStrings.ConnectionStrings["Final_Project.Properties.Settings.QLPTConnectionString"].ConnectionString = connectionStringBuilder.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(sectionName);

           // MessageBox.Show(config.ConnectionStrings.ConnectionStrings["Final_Project.Properties.Settings.QLPTConnectionString"].ConnectionString);
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void serName_TextChanged(object sender, EventArgs e)
        {
            serverTextBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void DBTextBox_TextChanged(object sender, EventArgs e)
        {
             DBTextBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void userIdTextBox_TextChanged(object sender, EventArgs e)
        {
            userIdTextBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ButtonServer_Click(sender, e);
            }
        }
    }
}
