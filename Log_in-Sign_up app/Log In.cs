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
            InitializeComponent();

            label1.Text = "Hello "+username;
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
        }
    }
}
