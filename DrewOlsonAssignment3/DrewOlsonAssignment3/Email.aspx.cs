﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // email server for Gmail - smtp.gmail.com
            Label2.Text = MailSender.CreateMessage(TextBox3.Text ,TextBox2.Text, TextBox1.Text);
           
        }
    }
}