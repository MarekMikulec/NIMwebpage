using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public class GameCoreOnePlayer
    {
        private Int32 inGameMatches = 20;
        private int takeNow;
        private Int32 _UItakes = 0;

        public int InGameMatches { get { return inGameMatches; } set { inGameMatches = value; } }

        public int UItakes { get { return _UItakes; } set { _UItakes = value; } }

        private enum Difficulty
        {
            Easy,
            Medium,
            Hard
        };

        private Difficulty chosenDifficulty = Difficulty.Easy;

        public void ChooseDificulty(int i, Label l)
        {
            switch (i)
            {
                case 0:
                    chosenDifficulty = Difficulty.Easy;
                    l.Text = "Hra jednoho hráče - lehká obtížnost";
                    break;
                case 1:
                    chosenDifficulty = Difficulty.Medium;
                    l.Text = "Hra jednoho hráče - střední obtížnost";
                    break;
                case 2:
                    l.Text = "Hra jednoho hráče - těžká obtížnost";
                    chosenDifficulty = Difficulty.Hard;
                    break;
            }
            return;
        }
        internal void Compute(DropDownList playersList, Image image1, Label label1, Label label3)
        {
            takeNow = playersList.SelectedIndex + 1;
            InGameMatches -= takeNow;
            if (inGameMatches <= 0)
            {
                PlayerWins();
            }
            if (inGameMatches.Equals(0))
            {
                PlayerWins();
            }
            switch (chosenDifficulty)
            {
                case Difficulty.Easy:
                    EasyUI();
                    break;
                case Difficulty.Medium:
                    MediumUI();
                    break;
                case Difficulty.Hard:
                    HardUI();
                    break;
            }
            label3.Text = UItakes.ToString();
            inGameMatches -= UItakes;
            if (inGameMatches <= 0)
            {
                UIWins();
            }
            image1.ImageUrl = "images/" + InGameMatches.ToString() + ".jpg";
            label1.Text = InGameMatches.ToString();
            if (InGameMatches < 3)
            {
                playersList.Items.Remove(playersList.Items.FindByText("3"));
            }
            if (InGameMatches < 2)
            {
                playersList.Items.Remove(playersList.Items.FindByText("2"));
            }
        }

        private void UIWins()
        {
            System.Web.HttpContext.Current.Session["IsAlreadyLoad"] = null;
            Winner.Text = "Prohrál jste! Zkuste to znovu.";
            HttpContext.Current.Session["game1"] = null;
            Winner.Loser1 = true;
            System.Web.HttpContext.Current.Response.Redirect("/Winner");
        }

        private void PlayerWins()
        {
            System.Web.HttpContext.Current.Session["IsAlreadyLoad"] = null;
            Winner.Text = "Zvítězil jste! Gratulujeme.";
            HttpContext.Current.Session["game1"] = null;
            System.Web.HttpContext.Current.Response.Redirect("/Winner");
        }

        private void HardUI()
        {
            //touto podmínkou dáváme šanci vyhrát nad Hard, když by tady nebyla, vždy vyhraje UI
            if (inGameMatches >= 16)
            {
                Random rn = new Random();
                UItakes = rn.Next(3) + 1;
            }
            else
            {
                UItakes = inGameMatches % 4;
            }
            if (UItakes == 0)
            {
                Random rn = new Random();
                UItakes = rn.Next(3) + 1;
                //throw new Exception("Algorithm error");
            }
        }

        private void MediumUI()
        {
            switch (inGameMatches)
            {
                case 1:
                    UItakes = 1;
                    break;
                case 2:
                    UItakes = 2;
                    break;
                case 3:
                    UItakes = 3;
                    break;
                case 5:
                    UItakes = 1;
                    break;
                case 6:
                    UItakes = 2;
                    break;
                case 7:
                    UItakes = 3;
                    break;
                default:
                    Random rn = new Random();
                    UItakes = rn.Next(3) + 1;
                    break;
            }
        }

        private void EasyUI()
        {
            switch (inGameMatches)
            {
                case 1:
                    UItakes = 1;
                    break;
                case 2:
                    UItakes = 2;
                    break;
                case 3:
                    UItakes = 3;
                    break;
                default:
                    Random rn = new Random();
                    UItakes = rn.Next(3) + 1;
                    break;
            }
        }
    }
}