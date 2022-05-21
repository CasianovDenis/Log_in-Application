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

namespace Log_in_Sign_up_app
{
    public partial class Authorisation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Authorisation()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked=Properties.Settings.Default.SaveCheck;
            textBox1.Text = Properties.Settings.Default.Username;
            textBox2.Text = Properties.Settings.Default.Password;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.SaveCheck = checkBox1.Checked;
                Properties.Settings.Default.Username = textBox1.Text;
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            con.Open();
            string query_username = string.Format("select username from MyTable " +
               "where username='{0}'", textBox1.Text);
            string query_password = string.Format("select password from MyTable " +
               "where  password='{0}'", textBox2.Text);

            SqlCommand cmd = new SqlCommand(query_username, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                reader.Close();
                SqlCommand cmd1 = new SqlCommand(query_password, con);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read() == true)
                {
                    MessageBox.Show("Successful authentication");
                    Log_In LI = new Log_In(textBox1.Text);
                    LI.ShowDialog();
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

            Console.WriteLine(textBox2.Text);
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp SU = new SignUp();
            SU.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass FP = new ForgotPass();
            FP.ShowDialog();
        }
    }
}
