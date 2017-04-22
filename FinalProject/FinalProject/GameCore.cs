using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public class GameCore
    {
        private Int32 inGameMatches = 20;
        private int takeNow;
        
        public int InGameMatches { get { return inGameMatches; } set { inGameMatches = value; } }

     

        public void RestartGame(DropDownList playersList, DropDownList oponentsList)
        {
            InGameMatches = 20;
            playersList.Items.Add(new ListItem("2"));
            playersList.Items.Add(new ListItem("3"));
            oponentsList.Items.Add(new ListItem("2"));
            oponentsList.Items.Add(new ListItem("3"));
        }

        internal Boolean Compute(DropDownList playersList, DropDownList oponentsList, Image image1, Label label1)
        {
            takeNow = playersList.SelectedIndex + 1;
            InGameMatches -= takeNow;
            label1.Text = InGameMatches.ToString();
            image1.ImageUrl = "images/" + InGameMatches.ToString() + ".jpg"; 
            if (InGameMatches < 3)
            {
                playersList.Items.Remove(playersList.Items.FindByText("3"));
                oponentsList.Items.Remove(oponentsList.Items.FindByText("3"));
            }
            if (InGameMatches < 2)
            {
                playersList.Items.Remove(playersList.Items.FindByText("2"));
                oponentsList.Items.Remove(oponentsList.Items.FindByText("2"));
            }

            if (inGameMatches < 1)
            {
                return true;
            }

            return false;

        }

        
    }
}