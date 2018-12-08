using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrewOlsonAssignment3
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal total = 0.0m;

            if (Session.Count != 0)
            {
                foreach (string x in Session.Keys)
                {
                    ListBox1.Items.Add(x + " " + Session[x]);
                    total += Convert.ToDecimal(Session[x]);
                }
            }
            ListBox1.Items.Add("________________________________");
            ListBox1.Items.Add("Total " + total.ToString("c"));
        }
    }
}