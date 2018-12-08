using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3.Student
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1();
            string queryUserName = Session["UserName"].ToString();
            var user = (from x in dbcon.StudentTables
                        where x.StudentUserName.Equals(queryUserName)
                        select x).First();

            Label1.Text = user.StudentFirstName.ToString() + ", ";

            queryUserName = user.StudentAdvisorUserName;
            var advisor = (from x in dbcon.AdvisorTables
                            where x.AdvisorUserName.Equals(queryUserName)
                            select x).First();

            //studentInfo = studentInfo +  + "\r\n";

            Label2.Text = advisor.AdvisorFirstName + " " + advisor.AdvisorLastName + " - " + advisor.AdvisorOfficeLocation;

        }
    }
}