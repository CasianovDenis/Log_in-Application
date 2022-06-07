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
   
    public partial class Auth2 : Form
    {
        string secretkey;
        string user;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project\Log_in-Sign_up app\Log_in-Sign_up app\Database.mdf;Integrated Security=True");

        public Auth2(string username)
        {
            
            InitializeComponent();
              
            string key = Guid.NewGuid().ToString().Replace("-", "").Replace("8", "").Replace("9", "").Substring(0, 16);
            
            secretkey = key;
            user = username;

            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("Test Two Factor", username.Trim(), key, false, 3);
            usernamelabel.Text = usernamelabel.Text + username; 
            keylabel.Text = keylabel.Text+ setupInfo.ManualEntryKey;

            
        }

        private void Auth2_Load(object sender, EventArgs e)
        {
            infolabel.Text = "1.Download application Google Authenticator from google play or app store."+"\n"+
                "2.Open application and select Enter a setup key."+"\n"+
                "3.Insert you username and key in app field."+"\n"+
                "4.Insert pin in window application.";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
                     
            string pin = confirme_textBox.Text.Trim();
            
            bool status = tfa.ValidateTwoFactorPIN(secretkey, pin, TimeSpan.FromSeconds(30));
            
            if (status==true)
            {
                con.Open();
             
                SqlCommand cmd = new SqlCommand("update MyTable set auth2='1' where username='" + user + "'", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("update MyTable set secretkey='" + secretkey + "' where username='" + user + "'", con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("You successfully enable 2fa");
                con.Close();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect pin ");
        }
    }
}
