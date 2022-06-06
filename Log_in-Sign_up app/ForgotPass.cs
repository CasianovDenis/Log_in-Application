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
    public partial class ForgotPass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void restore_pass_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query_restore_pass = string.Format("select password from MyTable " +
               "where email='{0}'", emailtextBox.Text);


            SqlCommand cmd = new SqlCommand(query_restore_pass, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
               display_pass_label.Text="You password: " + reader.GetString(0);
                display_pass_label.Visible = true;

            }
            else
                MessageBox.Show("Incorect email or account not created");
            con.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
