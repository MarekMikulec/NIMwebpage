using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class About : Page
    {
        public static GameCoreOnePlayer Game
        {
            get
            {
                var Game = HttpContext.Current.Session["game1"] as GameCoreOnePlayer;
                if (Game == null)
                {
                    Game = new GameCoreOnePlayer();
                    HttpContext.Current.Session["game1"] = Game;
                }
                return Game;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "images/main.jpg";
            Button1.Enabled = false;
            DropDownList1.Enabled = false;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game.ChooseDificulty(DropDownListDifficulties.SelectedIndex);
            Button1.Enabled = true;
            DropDownList1.Enabled = true;
            DropDownListDifficulties.Enabled = false;
            
        }
    }
}
