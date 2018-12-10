using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UserRole"].Equals("Student"))
            {

                Response.Redirect("~/Student/StudentHome.aspx");
            }
            else
            {
                Response.Redirect("~/Advisor/AdvisorHome.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["UserRole"].Equals("Student"))
            {

                Response.Redirect("~/Student/StudentScheduling.aspx");
            }
            else
            {
                Response.Redirect("~/Advisor/AdvisorScheduling.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Email.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.ndsu.edu/its/email_services/");
        }
    }
}