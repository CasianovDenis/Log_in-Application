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
using System.Threading;

namespace Log_in_Sign_up_app
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void create_acc_button_Click(object sender, EventArgs e)
        {
            bool flag=false;

            con.Open();

            if (existemail() == true)
            {
                incorect_format_label.Visible = false;
                exist_email_label.Visible = false;
                

                if (securepass() == true)
                {

                    if (existusername() == true)
                    {

                        SqlCommand cmd = new SqlCommand("INSERT INTO MyTable(ID,Email,Username,Password) values('" + null + "','" + emailtextBox.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        flag = true;
                    }

                }
            }


            con.Close();

            if (flag == true)
            {
                MessageBox.Show("Account Created Succesfully");
                this.Close();
            }
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool existemail()
        {
            bool flag = false;
            //try get exist username or email
            string text = emailtextBox.Text;
            char[] email = text.ToCharArray();
            for (int index = 0; index < email.Length; index++)
            {
                if (email[index] == '@')
                {

                    string query_email = string.Format("select email from MyTable " +
              "where  email='{0}'", emailtextBox.Text);

                    SqlCommand cmd1 = new SqlCommand(query_email, con);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read() == true)
                    {
                        //get error if exist this email in database

                        exist_email_label.Visible = true;
                        flag = false;

                    }
                    else
                    {
                        exist_email_label.Visible = false;
                        flag = true;
                        reader1.Close();
                        cmd1.Cancel();
                        
                    }


                }
                else
                {
                    if (exist_email_label.Visible == true) incorect_format_label.Visible = false;
                    else
                        incorect_format_label.Visible = true;
                }

            }
            return flag;
        }

        private bool securepass()
        {
            bool flag = false;
            int count = 0;
            string text = passwordTextBox.Text;
            char[] pass = text.ToCharArray();
            if (pass.Length >= 6)
            {
                for (int index = 0; index < pass.Length; index++)
                {
                    if (Char.IsUpper(pass[index]) == true)
                    {
                        count++;
                    }

                    else
                         if (Char.IsNumber(pass[index]) == true)
                    {
                        count++;
                    }
                }
            }
            else
            if (pass.Length < 6)
            {
                flag = false;
                password_eror_label.Visible = true;
            }

            if (count >= 2) { password_eror_label.Visible = false; flag = true; return flag; }
            else
            {
                password_eror_label.Visible = true;
                flag = false; return flag;
            }
        }

        private bool existusername()
        {
            bool flag = false;

            string query_username = string.Format("select username from MyTable " +
              "where username='{0}'", usernameTextBox.Text);

            SqlCommand cmd2 = new SqlCommand(query_username, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                flag = false;
                username_eror_label.Visible = true;
            }
            else
            {
                flag = true;
                username_eror_label.Visible = false;
                reader2.Close();
                cmd2.Cancel();
            }
            return flag;
        }
    }
}
