using Google.Authenticator;
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
    public partial class Verifieaf2 : Form
    {
        string user;
        string key;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Verifieaf2(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void Verifiedaf2_Load(object sender, EventArgs e)
        {
            infolabel.Text =
                "1.Open application and select pin" + "\n" +
                "2.Insert pin in window app field."+"\n"+"\n"+
                "If you are sure that the code is correct and gives an error"+"\n"+
                "try pressing the verifie button again ";
        }

        private void verifie_button_Click(object sender, EventArgs e)
        {
            con.Open();

            string query_secretkey = string.Format("select secretkey from MyTable " +
          "where username='{0}'", user);


            SqlCommand cmd = new SqlCommand(query_secretkey, con);
            SqlDataReader reader = cmd.ExecuteReader();

           if (reader.Read()==true)  key = reader.GetString(0);
            
            con.Close();
           
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();

            string pin = confirme_textBox.Text.Trim();

            bool status = tfa.ValidateTwoFactorPIN(key, pin, TimeSpan.FromSeconds(30));

            if (status == true)
            {

                MessageBox.Show("Successful authentication");
                this.Close();
                Log_In LI = new Log_In(user);
                LI.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect pin ");
           
            
        }
    }
   }

