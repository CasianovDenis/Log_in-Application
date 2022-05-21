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

        private void button1_Click(object sender, EventArgs e)
        {

                        
           con.Open();
            
            SqlCommand cmd = new SqlCommand("INSERT INTO MyTable(ID,Username,Password) values('" + null +"','"+usernameTextBox.Text +"','"+passwordTextBox.Text+"')",con);
            cmd.ExecuteNonQuery();
             con.Close();
            MessageBox.Show("Account Created Succesfully");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
