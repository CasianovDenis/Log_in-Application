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
using Log_in_Sign_up_app.Properties;
using Google.Authenticator;

namespace Log_in_Sign_up_app
{
    public partial class Authorisation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Authorisation()
        {
            
            InitializeComponent();
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.SaveCheck;
            if (checkBox1.Checked == false)
            {

                usernametextBox.Clear();
                passwordtextBox.Clear();
            }
            else
            if (checkBox1.Checked == true)
            {

                usernametextBox.Text = Properties.Settings.Default.Username;
                passwordtextBox.Text = Properties.Settings.Default.Password;
            }
        }

        private void Authorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.SaveCheck = false;
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            else
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.SaveCheck = checkBox1.Checked;
                Properties.Settings.Default.Username = usernametextBox.Text;
                Properties.Settings.Default.Password = passwordtextBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Logn_In_button_Click(object sender, EventArgs e)
        {

            con.Open();
            string query_username = string.Format("select username from MyTable " +
               "where username='{0}'", usernametextBox.Text);
            string query_password = string.Format("select password from MyTable " +
               "where  password='{0}'", passwordtextBox.Text);
            string query_auth2 = string.Format("select auth2 from MyTable " +
               "where username='{0}'", usernametextBox.Text);

            SqlCommand cmd = new SqlCommand(query_username, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                reader.Close();
                SqlCommand cmd1 = new SqlCommand(query_password, con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    reader1.Close();
                    SqlCommand cmd2 = new SqlCommand(query_auth2, con);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    
                    if (reader2.Read() == true)
                    {
                        if (reader2.GetString(0) == "1")
                        {
                            Verifieaf2 Vaf2 = new Verifieaf2(usernametextBox.Text);
                            Vaf2.ShowDialog();
                        }
                        else
                            if (reader2.GetString(0) == "0")
                        {
                            MessageBox.Show("Successful authentication");
                            Log_In LI = new Log_In(usernametextBox.Text);
                            LI.ShowDialog();
                        }
                    }
                }
                else
                    MessageBox.Show("Incorect password or username");
            }
            else
                MessageBox.Show("Incorect password or username");

            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Console.WriteLine(passwordtextBox.Text);
            
        }

        private void Sign_up_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp SU = new SignUp();
            SU.ShowDialog();
        }

        private void Restore_pass_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass FP = new ForgotPass();
            FP.ShowDialog();
        }

        
    }
}
