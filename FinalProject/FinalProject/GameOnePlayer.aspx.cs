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
            Image1.ImageUrl = "images/" + Game.InGameMatches.ToString() + ".jpg";
            Label1.Text = Game.InGameMatches.ToString();

            /*Takto zadefinovaným zajistíme, že se tlačítka zablokují jen při prvním načtení.
             * Zablokují se tedy jen při prvním načtení, kdy ještě není vybraná obtížnost.
             * Pak už budou normálně otevřené.
            */
            if (!IsPostBack && Session["IsAlreadyLoad"] == null)
            {
                Button2.Visible = true;
                Label2.Visible = true;
                DropDownListDifficulties.Visible = true;
                Button1.Enabled = false;
                DropDownList1.Enabled = false;
                Session["IsAlreadyLoad"] = true;

            }
            else {
                Button2.Visible = false;
                Label2.Visible = false;
                DropDownListDifficulties.Visible = false;
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Game.Compute(DropDownList1, Image1, Label1, Label3);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Z nějakého důvodu tady celí ten kód nikdy neproběhne nevím proč. Proto jsem vytvořil ještě to tlačítko Button2*/
            Game.ChooseDificulty(DropDownListDifficulties.SelectedIndex, Label4);
            Button1.Enabled = true;
            DropDownList1.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Game.ChooseDificulty(DropDownListDifficulties.SelectedIndex,Label4);
            Button1.Enabled = true;
            DropDownList1.Enabled = true;
        }
    }
}
