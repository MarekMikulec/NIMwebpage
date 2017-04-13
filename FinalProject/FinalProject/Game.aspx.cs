using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Contact : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {


            Image1.ImageUrl = "images/main.jpg";
            Label1.Text = GameCore.InGameMatches.ToString();
            Button2.Enabled = false;
            DropDownList2.Enabled = false;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean end = GameCore.Compute(DropDownList1, DropDownList2, Image1, Label1);
            Button1.Enabled = false;
            DropDownList1.Enabled = false;
            Button2.Enabled = true;
            DropDownList2.Enabled = true;
            if (end) { Response.Redirect("/Winner1.html"); }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Boolean end = GameCore.Compute(DropDownList2, DropDownList1, Image1, Label1);
            Button1.Enabled = true;
            DropDownList1.Enabled = true;
            Button2.Enabled = false;
            DropDownList2.Enabled = false;
            if (end) { Response.Redirect("/Winner2.html"); }
        }
        
    }
}