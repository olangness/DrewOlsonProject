using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


namespace DrewOlsonAssignment3
{
    public partial class MailSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public static void CreateTestMessage(string server, string msg)
        {
            MailMessage mail = new MailMessage();
            mail.Subject = "Student Advising Meeting";
            mail.From = new MailAddress("drewolson@gmail.com");// add your gmail account
            mail.To.Add("drewolson@gmail.com");// add your gmail account
            mail.Body = msg;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient(server, 587);
            smtp.EnableSsl = true;
            NetworkCredential netCre = new NetworkCredential("drewolson@gmail.com", "add your password -for your email");
            smtp.Credentials = netCre;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }

}