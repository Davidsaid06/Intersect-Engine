using System;
using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Core.Controls;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;

namespace Intersect.Client.Interface.Game
{
    class TimeWindow
    {

        //Controls
        public ImagePanel mTimeWindow;

        public ImagePanel mTimeImageSun;
        public ImagePanel mTimeImageMoon;

        //Item List
        private Label mHour;

        private Label mDay;

        private Label mWeather;


        public TimeWindow(Canvas gameCanvas)
        {
            mTimeWindow = new ImagePanel(gameCanvas, "TimeWindow");

            mTimeImageSun = new ImagePanel(mTimeWindow, "TimeImageSun");

            mTimeImageMoon = new ImagePanel(mTimeWindow, "TimeImageMoon");

            mTimeWindow.ShouldCacheToTexture = true;

            mHour = new Label(mTimeWindow, "TimeText");
            mHour.Text = Strings.Debug.time.ToString(Time.GetTime());
            string iDate = "01/01/2000 "+ Time.GetTime();
            string iDateNight = "01/01/2000 6:00 PM";
            string iDateDay = "01/01/2000 6:00 AM";

            DateTime oDate = Convert.ToDateTime(iDate);
            DateTime oDateNight = Convert.ToDateTime(iDateNight);
            DateTime oDateDay = Convert.ToDateTime(iDateDay);
            if (oDate.TimeOfDay > oDateDay.TimeOfDay && oDate.TimeOfDay < oDateNight.TimeOfDay)
            {
                mTimeImageSun.Show();
                mTimeImageMoon.Hide();
            }
            else
            {
                mTimeImageSun.Hide();
                mTimeImageMoon.Show();
            }
            

            int day = Globals.Me.mCustomStat[18].NextExp;

            mDay = new Label(mTimeWindow, "DayText");
            switch (day)
            {
                case 0:
                    mDay.Text = "Dhitday";
                    mDay.SetToolTipText("Dhitday, day inspired on Dhitia, the goddess of fire.");
                    break;
                case 1:
                    mDay.Text = "Nyiday";
                    mDay.SetToolTipText("Nyiday, day inspired on Nyion, the god of ice.");
                    break;
                case 2:
                    mDay.Text = "Rozday";
                    mDay.SetToolTipText("Rozday, day inspired on Rozheia, the goddess of Thunder.");
                    break;
                case 3:
                    mDay.Text = "Gevday";
                    mDay.SetToolTipText("Gevday, day inspired on Geva, the Goddess of Earth.");
                    break;
                case 4:
                    mDay.Text = "Wydday";
                    mDay.SetToolTipText("Wydday, day inspired on Wydon, the god of Wind.");
                    break;
                case 5:
                    mDay.Text = "Shelday";
                    mDay.SetToolTipText("Shelday, day inspired on Sheljun, the god of Water.");
                    break;
                case 6:
                    mDay.Text = "Nauday";
                    mDay.SetToolTipText("Nauday, day inspired on Nauren, Goddess of Nature.");
                    break;
                default:
                    mDay.Text = "No Day";
                    mDay.SetToolTipText("No Day");
                    break;
            }

            mWeather = new Label(mTimeWindow, "WeatherText");
            mWeather.Text = Globals.Me.mCustomStat[18].CurrentExp+"°C";

            mTimeWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());



        }

        public void Update()
        {
            if (Globals.Me == null)
            {
                return;
            }
            mHour.Text = Globals.Me.mCustomStat[18].StatValue;
            string iDate = "01/01/2000 " + Globals.Me.mCustomStat[18].StatValue;
            string iDateNight = "01/01/2000 6:00 PM";
            string iDateDay = "01/01/2000 6:00 AM";

            DateTime oDate = Convert.ToDateTime(iDate);
            DateTime oDateNight = Convert.ToDateTime(iDateNight);
            DateTime oDateDay = Convert.ToDateTime(iDateDay);
            if (oDate.TimeOfDay > oDateDay.TimeOfDay && oDate.TimeOfDay < oDateNight.TimeOfDay)
            {
                mTimeImageSun.Show();
                mTimeImageMoon.Hide();
            }
            else
            {
                mTimeImageSun.Hide();
                mTimeImageMoon.Show();
            }


            int day = Globals.Me.mCustomStat[18].NextExp;

            switch (day)
            {
                case 0:
                    mDay.Text = "Dhitday";
                    mDay.SetToolTipText("Dhitday, day inspired on Dhitia, the goddess of fire.");
                    break;
                case 1:
                    mDay.Text = "Nyiday";
                    mDay.SetToolTipText("Nyiday, day inspired on Nyion, the god of ice.");
                    break;
                case 2:
                    mDay.Text = "Rozday";
                    mDay.SetToolTipText("Rozday, day inspired on Rozheia, the goddess of Thunder.");
                    break;
                case 3:
                    mDay.Text = "Gevday";
                    mDay.SetToolTipText("Gevday, day inspired on Geva, the Goddess of Earth.");
                    break;
                case 4:
                    mDay.Text = "Wydday";
                    mDay.SetToolTipText("Wydday, day inspired on Wydon, the god of Wind.");
                    break;
                case 5:
                    mDay.Text = "Shelday";
                    mDay.SetToolTipText("Shelday, day inspired on Sheljun, the god of Water.");
                    break;
                case 6:
                    mDay.Text = "Nauday";
                    mDay.SetToolTipText("Nauday, day inspired on Nauren, Goddess of Nature.");
                    break;
                default:
                    mDay.Text = "No Day";
                    mDay.SetToolTipText("No Day");
                    break;
            }
            mWeather.Text = Globals.Me.mCustomStat[18].CurrentExp + "°C";
        }

    }
}
