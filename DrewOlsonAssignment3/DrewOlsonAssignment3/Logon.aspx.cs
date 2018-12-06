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
            Label1.Text = dbcon.UserTables.Count().ToString();
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var username = from x in dbcon.UserTables
                           where x.UserName.Equals(Login1.UserName)
                           select x;

            if (username != null)
            {
                Label1.Text = "You made it in brother";
            }
            else
            {
                Label1.Text = "access denied";
            }
        }
    }
}