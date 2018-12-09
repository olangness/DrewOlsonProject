using System;
using System.Collections.Generic;
using System.Data;
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
            using (AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1())
            {
                string queryUserName = Session["UserName"].ToString();
                var user = (from x in dbcon.StudentTables
                            where x.StudentUserName.Equals(queryUserName)
                            select x).First();

                AppointmentTable table = new AppointmentTable();
                // table.AdvisorUserName = user.StudentAdvisorUserName;
                // table.StudentUserName = user.StudentUserName;
                table.StudentUserName = "Bob";
                table.AdvisorUserName = "Guy";
                table.AppointmentReason = "";
                table.AppointmentDate = Calendar1.SelectedDate;
                table.AppointmentTime = TextBox1.Text + ":" + TextBox2.Text;

                dbcon.AppointmentTables.Add(table);
                





                
                dbcon.SaveChanges();
            }
            // show data in the GridView
            GridView1.DataBind();


        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}