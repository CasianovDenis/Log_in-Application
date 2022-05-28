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

namespace Log_in_Sign_up_app
{
    public partial class Change_email : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Change_email()
        {
            InitializeComponent();
        }

        private void Change_email_Load(object sender, EventArgs e)
        {

        }
        private void change_button_Click(object sender, EventArgs e)
        {

            if (existusername() == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update MyTable set email='" + New_email_textBox.Text + "' where email='" + old_email_textBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Email change succesfully");
                con.Close();
                this.Close();
            }

        }

        private bool existusername()
        {
            con.Open();
            bool flag = false;

            string query_username = string.Format("select email from MyTable " +
              "where email='{0}'", New_email_textBox.Text);

            SqlCommand cmd2 = new SqlCommand(query_username, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                flag = false;
                exist_email_label.Visible = true;
            }
            else
            {
                flag = true;
                exist_email_label.Visible = false;
                reader2.Close();
                cmd2.Cancel();
            }
            con.Close();
            return flag;
        }
    }
}
