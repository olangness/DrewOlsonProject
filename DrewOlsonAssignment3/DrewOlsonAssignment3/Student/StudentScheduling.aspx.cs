﻿using System;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1())
            {
                //retrieve the database results
                string queryUserName = Session["UserName"].ToString();
                var user = (from x in dbcon.StudentTables
                            where x.StudentUserName.Equals(queryUserName)
                            select x).First();

                //make new table and add it to the real database
                AppointmentTable table = new AppointmentTable();
                table.StudentUserName = user.StudentUserName;
                table.AdvisorUserName = user.StudentAdvisorUserName;
                table.AppointmentReason = TextBox3.Text;
                table.AppointmentDate = Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" "));
                table.AppointmentTime = TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue;

                string proposedDate = Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" "));

                string queryTable = Session["UserName"].ToString();
                var tbl = (from x in dbcon.AppointmentTables
                            where x.AppointmentDate.Equals(proposedDate)
                            select x);

                if (tbl.Count() == 0)
                {
                    dbcon.AppointmentTables.Add(table);

                    StateLabel.Text = "You have a new appointment with your advisor at "
                   + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue + ". Reason: " + TextBox3.Text;


                    MailSender.CreateMessage(Session["UserName"] + "@ndsu.edu", "New appointment added", "You have a new appointment with your advisor on"
                    + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue + ". Reason: " + TextBox3.Text);

                }
                else
                {
                    StateLabel.Text = "Choose a different time.";
                }
                    
                
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

                MailSender.CreateMessage(Session["UserName"] + "@ndsu.edu", "Appointment cancelled", "You have cancelled an appointment with your advisor on"
                   + Calendar1.SelectedDate.ToString().Substring(0, Calendar1.SelectedDate.ToString().IndexOf(" ")) + " at " + TextBox1.Text + ":" + TextBox2.Text + " " + DropDownList1.SelectedValue);
            }
            // show data in the GridView
            GridView1.DataBind();

        }
    }
}