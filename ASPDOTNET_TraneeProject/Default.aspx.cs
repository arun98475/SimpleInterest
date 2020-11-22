using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectTrials.App_Start;

namespace ProjectTrials
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AllSettings Setting = (AllSettings)Application["Settings"];

            if (Setting.PageRefreshCounter == 0)
            {
                Setting.PageRefreshCounter = 1;
                AllManager.SaveSettings(Setting);
            }

            else
            { 
                Setting.PageRefreshCounter = 0;
                AllManager.SaveSettings(Setting);
             }

            AllSettings Settings = (AllSettings)Application["Settings"];
           if (Setting.PageRefreshCounter == 0)
                LabelDefaultText1.Text = Settings.DefaultText1;
            else
                LabelDefaultText1.Text = Settings.DefaultText2;

        }
    }
}