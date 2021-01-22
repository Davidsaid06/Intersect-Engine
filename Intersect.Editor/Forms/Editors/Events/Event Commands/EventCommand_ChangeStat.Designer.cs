using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeStat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandChangeStat));
            this.grpChangeStat = new DarkUI.Controls.DarkGroupBox();
            this.nudAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbStat = new DarkUI.Controls.DarkComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChangeStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeStat
            // 
            this.grpChangeStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpChangeStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeStat.Controls.Add(this.label1);
            this.grpChangeStat.Controls.Add(this.cmbStat);
            this.grpChangeStat.Controls.Add(this.nudAmount);
            this.grpChangeStat.Controls.Add(this.lblAmount);
            this.grpChangeStat.Controls.Add(this.btnCancel);
            this.grpChangeStat.Controls.Add(this.btnSave);
            this.grpChangeStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeStat.Location = new System.Drawing.Point(4, 4);
            this.grpChangeStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChangeStat.Name = "grpChangeStat";
            this.grpChangeStat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpChangeStat.Size = new System.Drawing.Size(345, 156);
            this.grpChangeStat.TabIndex = 17;
            this.grpChangeStat.TabStop = false;
            this.grpChangeStat.Text = "Change Stat:";
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAmount.Location = new System.Drawing.Point(119, 78);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(219, 22);
            this.nudAmount.TabIndex = 22;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(5, 80);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 17);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Set Stat:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 122);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancel.Size = new System.Drawing.Size(100, 26);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 122);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSave.Size = new System.Drawing.Size(100, 26);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStat
            // 
            this.cmbStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbStat.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbStat.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbStat.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbStat.ButtonIcon")));
            this.cmbStat.DrawDropdownHoverOutline = false;
            this.cmbStat.DrawFocusRectangle = false;
            this.cmbStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Location = new System.Drawing.Point(119, 33);
            this.cmbStat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(218, 23);
            this.cmbStat.TabIndex = 25;
            this.cmbStat.Text = null;
            this.cmbStat.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Stat:";
            // 
            // EventCommandChangeStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeStat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventCommandChangeStat";
            this.Size = new System.Drawing.Size(357, 164);
            this.grpChangeStat.ResumeLayout(false);
            this.grpChangeStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeStat;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label lblAmount;
        private DarkNumericUpDown nudAmount;
        private System.Windows.Forms.Label label1;
        private DarkComboBox cmbStat;
    }
}
