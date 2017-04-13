using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public static class GameCore
    {
        private static Int32 inGameMatches = 20;
        private static int takeNow;

        public static int InGameMatches { get { return inGameMatches; } set { inGameMatches = value; } }



        internal static Boolean Compute(DropDownList playersList, DropDownList oponentsList, Image image1, Label label1)
        {
            takeNow = playersList.SelectedIndex + 1;
            InGameMatches -= takeNow;
            label1.Text = InGameMatches.ToString();
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