using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3.Advisor
{
    public partial class AdvisorHome : System.Web.UI.Page
    {
        


        protected void Page_Load(object sender, EventArgs e)
        {
            //adds a welcome statement
            AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1();
            string queryUserName = Session["UserName"].ToString();
            var user = (from x in dbcon.AdvisorTables
                        where x.AdvisorUserName.Equals(queryUserName)
                        select x).First();

            Label1.Text = user.AdvisorFirstName.ToString() + ", ";

            string studentInfo = "";
            var students = (from x in dbcon.StudentTables
                        where x.StudentAdvisorUserName.Equals(queryUserName)
                        select x);

            foreach(var student in students)
            {
                //studentInfo = studentInfo +  + "\r\n";

                ListBox1.Items.Add(student.StudentFirstName + " " + student.StudentLastName + " - "
                    + student.StudentMajor + " - " + student.StudentUserName + "@ndsu.edu");
            }
            
        }
    }
}