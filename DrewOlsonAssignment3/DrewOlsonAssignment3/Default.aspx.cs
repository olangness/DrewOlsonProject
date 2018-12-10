using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (AdvisingDatabaseEntities1 dbcon = new AdvisingDatabaseEntities1())
            {
                if (GridView1.SelectedDataKey.Value != null)
                {
                    // add data to the dbcon
                    
                    // select the row
                    int item = Convert.ToInt32(
                    GridView1.SelectedDataKey.Value.ToString());
                    dbcon.SaveChanges();
                }

            }
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (AdvisingDatabaseEntities1 dbcon =
            new AdvisingDatabaseEntities1())
            {
                Message abc = new Message();
             //   abc.Date =
                    DateTime.Now.ToShortDateString();
            //    abc.Name = TextBox1.Text;
            //    abc.Email = TextBox2.Text;
            //    abc.Message1 = TextBox3.Text;
                // add data to the table
             //   dbcon.Messages.Add(abc);
                dbcon.SaveChanges();
            }
            // show data in the GridView
            GridView1.DataBind();

        }
    }
}