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
    public partial class Change_username : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Change_username()
        {
            InitializeComponent();
        }

        private void Change_username_Load(object sender, EventArgs e)
        {

        }

        private void change_button_Click(object sender, EventArgs e)
        {
           
            if (existusername() == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update MyTable set username='" + New_username_textBox.Text + "' where username='" + old_username_textBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Username change succesfully");
                con.Close();
                this.Close();
            }
            
        }

        private bool existusername()
        {
            con.Open();
            bool flag = false;

            string query_username = string.Format("select username from MyTable " +
              "where username='{0}'", New_username_textBox.Text);

            SqlCommand cmd2 = new SqlCommand(query_username, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                flag = false;
                exist_username_label.Visible = true;
            }
            else
            {
                flag = true;
               exist_username_label.Visible = false;
                reader2.Close();
                cmd2.Cancel();
            }
            con.Close();
            return flag;
        }
    }
}
