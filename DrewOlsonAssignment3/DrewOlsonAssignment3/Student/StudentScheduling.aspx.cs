using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3.Student
{
    public partial class StudentScheduling : System.Web.UI.Page
    {
        AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            //getting the username from the database
            var username = from x in dbcon.AppointmentTables
                          // where x.UserName.Equals(Login1.UserName)
                           select x;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string item = GridView1.SelectedDataKey[0] +
            " ; " + GridView1.SelectedDataKey[1];
            string price = GridView1.SelectedDataKey[2].ToString();

            // add data to the session 
            Session.Add(item, price);

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}