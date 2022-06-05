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
    public partial class Log_In : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Log_In(string username)
        {
            con.Open();
            InitializeComponent();
            
            username_label.Text = "Username: " + username;

            string getter_email = string.Format("select email from MyTable " +
               "where username='{0}'", username);

            SqlCommand cmd = new SqlCommand(getter_email, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                email_label.Text = "Email: " + reader.GetString(0);
            }

            con.Close();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            
        }

        private void change_username_button_Click(object sender, EventArgs e)
        {
            Change_username CU = new Change_username();
            CU.ShowDialog();
        }

        private void change_email_button_Click(object sender, EventArgs e)
        {
            Change_email CE = new Change_email();
            CE.ShowDialog();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
