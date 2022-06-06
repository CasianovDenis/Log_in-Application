using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
                Smtp.EnableSsl = true;
                Smtp.Credentials = new NetworkCredential("email@mail.ru", "pasword");//real email and password
                                                                                      //was hide
                Smtp.Credentials = new NetworkCredential("kasyanov_2001@mail.ru", "bf8ZsE9Rwyrk9ViECALA");//real email and password
                                                                                                          //was hide

                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("kasyanov_2001@mail.ru");//real email was hide
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("email@mail.ru");//real email was hide
                Message.To.Add(new MailAddress(emailtextBox.Text));
                Message.Subject = "Restore password";
                Message.Body = "Password:" + reader.GetString(0) + "\n" +
                    "If is not you request,please change password in application.";

                Smtp.Send(Message);
                MessageBox.Show("You password was sent to email");
                this.Close();
            }
            else
                MessageBox.Show("Incorect email");
            con.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
