using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace DrewOlsonAssignment3
{
    public partial class Logon : System.Web.UI.Page
    {
        AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //getting the username from the database
            var username = from x in dbcon.UserTables
                           where x.UserName.Equals(Login1.UserName)
                           select x;

            //checking username and password, adds username to the session, and authenticates the user
            if (username.Count() != 0)
            {
                Label1.Text = username.First().UserRole;
                if (username.First().UserPassword.Equals(Login1.Password))
                {
                    Session["UserName"] = username.First().UserName;
                    Session["UserRole"] = username.First().UserRole;
                    e.Authenticated = true;
                }
                
            }
            else
            {
                Label1.Text = "access denied";
            }
        }
    }
}