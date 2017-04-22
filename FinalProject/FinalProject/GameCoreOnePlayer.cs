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
        private Int32 UItakes = 0;

        public int InGameMatches { get { return inGameMatches; } set { inGameMatches = value; } }

        public int UItakes1 { get { return UItakes; } set { UItakes = value; } }

        private enum Difficulty {
            Easy,
            Medium,
            Hard
        };

        private Difficulty chosenDifficulty = Difficulty.Easy;

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
            return;
        }
        internal Boolean Compute(DropDownList playersList, Image image1, Label label1, Label label3)
        {
            takeNow = playersList.SelectedIndex + 1;
            InGameMatches -= takeNow;
            if(inGameMatches.Equals(0))
            {
                PlayerWins();
            }
            switch (chosenDifficulty) {
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
            if (inGameMatches.Equals(0))
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

            if (inGameMatches < 1)
            {
                return true;
            }

            return false;
        }

        private void UIWins()
        {
            //throw new NotImplementedException();
        }

        private void PlayerWins()
        {
            //throw new NotImplementedException();
        }

        private void HardUI()
        {
            //throw new NotImplementedException();
        }

        private void MediumUI()
        {
            //throw new NotImplementedException();
        }

        private void EasyUI()
        {
            switch (inGameMatches) {
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