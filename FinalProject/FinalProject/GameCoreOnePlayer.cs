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

        public int InGameMatches { get { return inGameMatches; } set { inGameMatches = value; } }


        private enum Difficulty {
            Easy,
            Medium,
            Hard
        };

        private Difficulty chosenDifficulty;

        public void ChooseDificulty(int i) {
            switch (i) {
                case 0:
                    chosenDifficulty = Difficulty.Easy;
                    break;
                case 1:
                    chosenDifficulty = Difficulty.Medium;
                    break;
                case 2:
                    chosenDifficulty = Difficulty.Hard;
                    break;
            }
        }
        internal Boolean Compute(DropDownList playersList, Image image1, Label label1, DropDownList difficulty)
        {
            takeNow = playersList.SelectedIndex + 1;
            InGameMatches -= takeNow;
            UI(difficulty);
            label1.Text = InGameMatches.ToString();
            if (InGameMatches < 3)
            {
                playersList.Items.Remove(playersList.Items.FindByText("3"));
            }
            if (InGameMatches < 2)
            {
                playersList.Items.Remove(playersList.Items.FindByText("2"));
            }

            if (inGameMatches < 1)
            {
                return true;
            }

            return false;
        }

        private Boolean UI(DropDownList difficulty)
        {

            return false;
        }

    }
}