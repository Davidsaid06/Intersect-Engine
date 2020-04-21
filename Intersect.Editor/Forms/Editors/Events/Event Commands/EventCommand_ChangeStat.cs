using System;
using System.Windows.Forms;
using Intersect.Enums;

using Intersect.Editor.Localization;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeStat : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ChangeStatCommand mMyCommand;

        public EventCommandChangeStat(ChangeStatCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            if (mMyCommand.Amount <= 0 || mMyCommand.Amount > Options.MaxStatValue)
            {
                mMyCommand.Amount = 1;
            }

            mMyCommand.Index = cmbStat.SelectedIndex;

            nudAmount.Maximum = Options.MaxStatValue;
            nudAmount.Value = mMyCommand.Amount;
            InitLocalization();
        }

        private void InitLocalization()
        {
            grpChangeStat.Text = Strings.EventChangeStat.title;
            lblAmount.Text = Strings.EventChangeStat.label;
            btnSave.Text = Strings.EventChangeStat.okay;
            btnCancel.Text = Strings.EventChangeStat.cancel;

            for (var i = 0; i < (int)Stats.StatCount; i++)
            {
                cmbStat.Items.Add(Strings.Combat.stats[i]);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.Amount = (int) nudAmount.Value;
            mMyCommand.Index = cmbStat.SelectedIndex;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
