using System;
using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.Enums;

namespace Intersect.Client.Interface.Game
{
    class StatsWindow
    {

        private List<ImagePanel> mExpBar = new List<ImagePanel>();

        private List<ImagePanel> mExpBarContainer = new List<ImagePanel>();

        private List<Label> mExpLabel = new List<Label>();

        private List<Label> mExpValue = new List<Label>();

        private List<Label> mLevelValue = new List<Label>();

        private Label mPrimary;

        private Label mSecondary;

        private Button mChangeStatTypeButton;

        private int StatType =0;

        //Labels
        private Label mStatText;

        //Controls
        private WindowControl mStatsWindow;
        public StatsWindow(Canvas gameCanvas)
        {
            mStatsWindow = new WindowControl(gameCanvas, "Stats", false, "StatsWindow");
            mStatsWindow.DisableResizing();

            initComponents();


            mStatsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }

        public void initComponents()
        {

            mPrimary = new Label(mStatsWindow, "PrimaryText");
            mPrimary.SetTextColor(new Color(0, 0, 0, 0), Label.ControlState.Normal);
            mPrimary.Text = "Primary Jobs";

            mSecondary = new Label(mStatsWindow, "SecondaryText");
            mSecondary.SetTextColor(new Color(0, 0, 0, 0), Label.ControlState.Normal);
            mSecondary.Text = "Secondary Jobs";

            mChangeStatTypeButton = new Button(mStatsWindow, "ChangeStatsTypeButton");
            mChangeStatTypeButton.Text = "Weapon Stats";
            mChangeStatTypeButton.SetToolTipText("See Weapon Stats");
            mChangeStatTypeButton.Clicked += change_stat_Clicked;

            if (Globals.Me.mCustomStat != null)
            {
                for (var i = 0; i < Globals.Me.mCustomStat.Length; i++)
                {
                    if (Globals.Me.mCustomStat[i].StatType != 4)
                    {
                        //Health bars
                        mExpBarContainer.Add(new ImagePanel(mStatsWindow, "ExpBarContainer" + i));
                        mExpLabel.Add(new Label(mStatsWindow, "ExpLabel" + i));
                        mExpLabel[i].SetTextColor(new Color(0, 0, 0, 0), Label.ControlState.Normal);
                        mExpLabel[i].Text = Globals.Me.mCustomStat[i].StatName;
                        mExpValue.Add(new Label(mStatsWindow, "ExpValue" + i));
                        mExpValue[i].SetTextColor(new Color(0, 0, 0, 0), Label.ControlState.Normal);
                        mLevelValue.Add(new Label(mStatsWindow, "LevelValue" + i));
                        mLevelValue[i].SetTextColor(new Color(0, 0, 0, 0), Label.ControlState.Normal);
                        mExpBar.Add(new ImagePanel(mExpBarContainer[i], "ExpBar" + i));

                        if (Globals.Me.mCustomStat[i].StatType == 2 || Globals.Me.mCustomStat[i].StatType == 3)
                        {
                            mExpBarContainer[i].Hide();
                            mExpLabel[i].Hide();
                            mExpValue[i].Hide();
                            mLevelValue[i].Hide();
                            mExpBar[i].Hide();
                        }
                    }


                }

            }



        }

        //Methods
        public void Update()
        {
            if (mStatsWindow.IsHidden)
            {
                return;
            }

            if (mExpBarContainer.Count ==0)
            {
                initComponents();
            }

            for (var i = 0; i < Globals.Me.mCustomStat.Length; i++)
            {
                if (Globals.Me.mCustomStat[i].StatType != 4)
                {

                    if (mExpBar[i].Texture != null)
                    {
                        var statWidthRatio = 1f;
                        if (Globals.Me.mCustomStat[i].NextExp > 0)
                        {
                            var exp = Globals.Me.mCustomStat[i].CurrentExp;
                            var maxExp = Globals.Me.mCustomStat[i].NextExp;
                            var ratioExp = (float)exp / (float)maxExp;
                            statWidthRatio = Math.Min(1, Math.Max(0, ratioExp));
                        }

                        mExpBar[i]
                            .SetTextureRect(
                                0, 0, Convert.ToInt32(mExpBar[i].Texture.GetWidth() * statWidthRatio),
                                mExpBar[i].Texture.GetHeight()
                            );

                        mExpBar[i]
                            .SetSize(
                                Convert.ToInt32(statWidthRatio * mExpBarContainer[i].Width), mExpBarContainer[i].Height
                            );
                    }

                    mExpValue[i].Text = Globals.Me.mCustomStat[i].CurrentExp + "/" + Globals.Me.mCustomStat[i].NextExp;
                    mLevelValue[i].Text = Globals.Me.mCustomStat[i].StatValue;

                }


            }
        }

        public void Show()
        {
            mStatsWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mStatsWindow.IsHidden;
        }

        public void Hide()
        {
            mStatsWindow.IsHidden = true;
        }

        void change_stat_Clicked(Base sender, ClickedEventArgs arguments)
        {
            if (StatType == 0) 
            {
                for (var i = 0; i < Globals.Me.mCustomStat.Length; i++)
                {
                    if (Globals.Me.mCustomStat[i].StatType != 4)
                    {
                        if (Globals.Me.mCustomStat[i].StatType == 0 || Globals.Me.mCustomStat[i].StatType == 1)
                        {
                            mExpBarContainer[i].Hide();
                            mExpLabel[i].Hide();
                            mExpValue[i].Hide();
                            mLevelValue[i].Hide();
                            mExpBar[i].Hide();
                        }
                        else
                        {
                            mExpBarContainer[i].Show();
                            mExpLabel[i].Show();
                            mExpValue[i].Show();
                            mLevelValue[i].Show();
                            mExpBar[i].Show();
                        }
                    }

                }
                mPrimary.Text = "Short Range";
                mSecondary.Text = "Large Range";
                mChangeStatTypeButton.Text = "Job Stats";
                mChangeStatTypeButton.SetToolTipText("See Job Stats");
                StatType = 1;
            }
            else
            {
                for (var i = 0; i < Globals.Me.mCustomStat.Length; i++)
                {
                    if (Globals.Me.mCustomStat[i].StatType != 4)
                    {
                        if (Globals.Me.mCustomStat[i].StatType == 2 || Globals.Me.mCustomStat[i].StatType == 3)
                        {
                            mExpBarContainer[i].Hide();
                            mExpLabel[i].Hide();
                            mExpValue[i].Hide();
                            mLevelValue[i].Hide();
                            mExpBar[i].Hide();
                        }
                        else
                        {
                            mExpBarContainer[i].Show();
                            mExpLabel[i].Show();
                            mExpValue[i].Show();
                            mLevelValue[i].Show();
                            mExpBar[i].Show();
                        }
                    }
                }
                mPrimary.Text = "Primary Jobs";
                mSecondary.Text = "Secondary Jobs";
                mChangeStatTypeButton.Text = "Weapon Stats";
                mChangeStatTypeButton.SetToolTipText("See Weapon Stats");
                StatType = 0;
            }
        }


    }
}
