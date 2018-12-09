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

        public static void CreateTestMessage(string server, string username, string sbjt, string msg)
        {
            //MailMessage mail = new MailMessage();
            //mail.Subject = "Student Advising Meeting";
            //mail.From = new MailAddress("ndsuadvisingalert@gmailcom");// add your gmail account
            //mail.To.Add("ndsuadvisingalert@gmailcom");// add your gmail account
            //mail.Body = msg;
            //mail.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient(server, 587);
            //smtp.EnableSsl = true;
            //NetworkCredential netCre = new NetworkCredential("ndsuadvisingalert@gmailcom", "add your password -for your email");
            //smtp.Credentials = netCre;

            //try
            //{
            //    smtp.Send(mail);
            //}
            //catch (Exception ex)
            //{

            //}

            MailMessage mail = new MailMessage("ndsuadvisingalert@gmailcom", username);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            mail.Subject = sbjt;
            mail.Body = msg;
            SmtpClient smtp = new SmtpClient(server, 587);
            smtp.EnableSsl = true;
            client.Send(mail);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }

}