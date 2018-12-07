using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3
{
    public partial class RedirectPage : System.Web.UI.Page
    {

        //this is just for redirecting based on the user role
        protected void Page_Load(object sender, EventArgs e)
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
    }
}