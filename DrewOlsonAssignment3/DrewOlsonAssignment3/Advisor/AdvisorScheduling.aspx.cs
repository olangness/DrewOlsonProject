using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3.Advisor
{
    public partial class AdvisorScheduling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1())
            {
                //retrieve the database results
                string queryUserName = Session["UserName"].ToString();
                var student = (from x in dbcon.StudentTables
                               where x.StudentAdvisorUserName.Equals(queryUserName)
                               select x).First();

                //make new table and add it to the real database
                AppointmentTable table = new AppointmentTable();
                table.StudentUserName = TextBox4.Text;
                table.AdvisorUserName = student.StudentAdvisorUserName;
                table.AppointmentReason = TextBox3.Text;
                table.AppointmentDate = Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" "));
                table.AppointmentTime = TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue;



                string proposedDate = Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" "));
                var tbl = (from x in dbcon.AppointmentTables
                           where x.AppointmentDate.Equals(proposedDate)
                           select x);
                if (tbl.Count() == 0)
                {
                    dbcon.AppointmentTables.Add(table);
                }
                else
                    Label1.Text = "Choose a different time.";

                Label1.Text = "You have a new appointment with your student " + student.StudentFirstName + " " + student.StudentLastName + " at "
                     + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue + ". Reason: " + TextBox3.Text;


                MailSender.CreateMessage(Session["UserName"] + "@ndsu.edu", "New appointment added", "You have a new appointment with your student " + student.StudentFirstName + " " + student.StudentLastName + " at "
                    + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue + ". Reason: " + TextBox3.Text);

                dbcon.SaveChanges();
            }
            // show data in the GridView
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //remove appointment
            using (AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1())
            {


                //make new table and add it to the real database
                int item = Convert.ToInt32(
                     GridView1.SelectedDataKey.Value.ToString());

                var toRemove = (from x in dbcon.AppointmentTables
                                where x.AppointmentID == item
                                select x).First();




                dbcon.AppointmentTables.Remove(toRemove);


                dbcon.SaveChanges();

                MailSender.CreateMessage(Session["UserName"] + "@ndsu.edu", "Appointment cancelled", "You have cancelled an appointment with your  student " + toRemove.StudentUserName + " at "
       + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue);
            }
            // show data in the GridView
            GridView1.DataBind();


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}