using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Winner : System.Web.UI.Page
    {
        private static String text;

        public static String Text
        {

            get
            {
                return text;
            }

            set { text = value; }
        }

        public static bool Loser1 { get { return Loser; } set { Loser = value; } }

        private static Boolean Loser = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Text;
            if (Loser == true) {
                Image1.ImageUrl = "images/Sad.png";
                Loser = false;
            }

        }


    }
}