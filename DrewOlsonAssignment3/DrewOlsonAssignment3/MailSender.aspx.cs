﻿using System;
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

        public static string CreateMessage(string username, string sbjt, string msg)
        {
            // creates new mail message with designated email address below
            MailMessage mail = new MailMessage("ndsuadvisingalert@gmail.com", username);
            SmtpClient client = new SmtpClient();

            client.Port = 25;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("ndsuadvisingalert@gmail.com", "drewolson123");

            client.Host = "smtp.gmail.com";
            mail.Body = msg;
            mail.Subject = sbjt;

            //try catch block to report if email was successfully sent
            try { client.Send(mail); }
            catch (SmtpFailedRecipientException e) { return "Failure"; }


            return "Success";
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }

}