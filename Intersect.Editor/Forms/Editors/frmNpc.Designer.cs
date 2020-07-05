using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmNpc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNpc));
            this.grpNpcs = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstNpcs = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbSprite = new DarkUI.Controls.DarkComboBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.picNpc = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.nudSpawnDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSpawnDuration = new System.Windows.Forms.Label();
            this.nudSightRange = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSightRange = new System.Windows.Forms.Label();
            this.grpStats = new DarkUI.Controls.DarkGroupBox();
            this.nudFaith = new DarkUI.Controls.DarkNumericUpDown();
            this.lblFaith = new System.Windows.Forms.Label();
            this.nudExp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMana = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpd = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMR = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMag = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStr = new DarkUI.Controls.DarkNumericUpDown();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpElements = new DarkUI.Controls.DarkGroupBox();
            this.nudLight = new DarkUI.Controls.DarkNumericUpDown();
            this.lblLight = new System.Windows.Forms.Label();
            this.nudDark = new DarkUI.Controls.DarkNumericUpDown();
            this.nudIce = new DarkUI.Controls.DarkNumericUpDown();
            this.nudFire = new DarkUI.Controls.DarkNumericUpDown();
            this.nudNature = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWater = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWind = new DarkUI.Controls.DarkNumericUpDown();
            this.nudThunder = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEarth = new DarkUI.Controls.DarkNumericUpDown();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblThunder = new System.Windows.Forms.Label();
            this.lblEarth = new System.Windows.Forms.Label();
            this.lblIce = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.lblDark = new System.Windows.Forms.Label();
            this.grpCombat = new DarkUI.Controls.DarkGroupBox();
            this.grpAttackSpeed = new DarkUI.Controls.DarkGroupBox();
            this.nudAttackSpeedValue = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAttackSpeedValue = new System.Windows.Forms.Label();
            this.cmbAttackSpeedModifier = new DarkUI.Controls.DarkComboBox();
            this.lblAttackSpeedModifier = new System.Windows.Forms.Label();
            this.nudCritMultiplier = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCritMultiplier = new System.Windows.Forms.Label();
            this.nudScaling = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudCritChance = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbScalingStat = new DarkUI.Controls.DarkComboBox();
            this.lblScalingStat = new System.Windows.Forms.Label();
            this.lblScaling = new System.Windows.Forms.Label();
            this.cmbDamageType = new DarkUI.Controls.DarkComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.cmbAttackAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblAttackAnimation = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.grpCommonEvents = new DarkUI.Controls.DarkGroupBox();
            this.cmbOnDeathEventParty = new DarkUI.Controls.DarkComboBox();
            this.lblOnDeathEventParty = new System.Windows.Forms.Label();
            this.cmbOnDeathEventKiller = new DarkUI.Controls.DarkComboBox();
            this.lblOnDeathEventKiller = new System.Windows.Forms.Label();
            this.grpBehavior = new DarkUI.Controls.DarkGroupBox();
            this.nbrMoveRange = new DarkUI.Controls.DarkNumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFocusDamageDealer = new System.Windows.Forms.Label();
            this.chkFocusDamageDealer = new DarkUI.Controls.DarkCheckBox();
            this.nudFlee = new DarkUI.Controls.DarkNumericUpDown();
            this.lblFlee = new System.Windows.Forms.Label();
            this.lblSwarm = new System.Windows.Forms.Label();
            this.chkSwarm = new DarkUI.Controls.DarkCheckBox();
            this.grpConditions = new DarkUI.Controls.DarkGroupBox();
            this.btnAttackOnSightCond = new DarkUI.Controls.DarkButton();
            this.btnPlayerCanAttackCond = new DarkUI.Controls.DarkButton();
            this.btnPlayerFriendProtectorCond = new DarkUI.Controls.DarkButton();
            this.lblMovement = new System.Windows.Forms.Label();
            this.cmbMovement = new DarkUI.Controls.DarkComboBox();
            this.lblAggressive = new System.Windows.Forms.Label();
            this.chkAggressive = new DarkUI.Controls.DarkCheckBox();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.lblRegenHint = new System.Windows.Forms.Label();
            this.grpDrops = new DarkUI.Controls.DarkGroupBox();
            this.btnDropRemove = new DarkUI.Controls.DarkButton();
            this.btnDropAdd = new DarkUI.Controls.DarkButton();
            this.lstDrops = new System.Windows.Forms.ListBox();
            this.nudDropAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDropChance = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbDropItem = new DarkUI.Controls.DarkComboBox();
            this.lblDropAmount = new System.Windows.Forms.Label();
            this.lblDropChance = new System.Windows.Forms.Label();
            this.lblDropItem = new System.Windows.Forms.Label();
            this.grpNpcVsNpc = new DarkUI.Controls.DarkGroupBox();
            this.cmbHostileNPC = new DarkUI.Controls.DarkComboBox();
            this.lblNPC = new System.Windows.Forms.Label();
            this.btnRemoveAggro = new DarkUI.Controls.DarkButton();
            this.btnAddAggro = new DarkUI.Controls.DarkButton();
            this.lstAggro = new System.Windows.Forms.ListBox();
            this.chkAttackAllies = new DarkUI.Controls.DarkCheckBox();
            this.chkEnabled = new DarkUI.Controls.DarkCheckBox();
            this.grpSpells = new DarkUI.Controls.DarkGroupBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.cmbFreq = new DarkUI.Controls.DarkComboBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblSpell = new System.Windows.Forms.Label();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.lstSpells = new System.Windows.Forms.ListBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChronological = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.searchableDarkTreeView1 = new Intersect.Editor.Forms.Controls.SearchableDarkTreeView();
            this.grpNpcs.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSightRange)).BeginInit();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarth)).BeginInit();
            this.grpCombat.SuspendLayout();
            this.grpAttackSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            this.grpCommonEvents.SuspendLayout();
            this.grpBehavior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMoveRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlee)).BeginInit();
            this.grpConditions.SuspendLayout();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).BeginInit();
            this.grpDrops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).BeginInit();
            this.grpNpcVsNpc.SuspendLayout();
            this.grpSpells.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNpcs
            // 
            this.grpNpcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNpcs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNpcs.Controls.Add(this.btnClearSearch);
            this.grpNpcs.Controls.Add(this.txtSearch);
            this.grpNpcs.Controls.Add(this.lstNpcs);
            this.grpNpcs.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNpcs.Location = new System.Drawing.Point(16, 48);
            this.grpNpcs.Margin = new System.Windows.Forms.Padding(4);
            this.grpNpcs.Name = "grpNpcs";
            this.grpNpcs.Padding = new System.Windows.Forms.Padding(4);
            this.grpNpcs.Size = new System.Drawing.Size(271, 702);
            this.grpNpcs.TabIndex = 13;
            this.grpNpcs.TabStop = false;
            this.grpNpcs.Text = "NPCs";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(239, 22);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnClearSearch.Size = new System.Drawing.Size(24, 25);
            this.btnClearSearch.TabIndex = 34;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(8, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 22);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstNpcs
            // 
            this.lstNpcs.AllowDrop = true;
            this.lstNpcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstNpcs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstNpcs.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstNpcs.HideSelection = false;
            this.lstNpcs.ImageIndex = 0;
            this.lstNpcs.ImageList = this.imageList;
            this.lstNpcs.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstNpcs.Location = new System.Drawing.Point(8, 54);
            this.lstNpcs.Margin = new System.Windows.Forms.Padding(4);
            this.lstNpcs.Name = "lstNpcs";
            this.lstNpcs.SelectedImageIndex = 0;
            this.lstNpcs.Size = new System.Drawing.Size(255, 640);
            this.lstNpcs.TabIndex = 32;
            this.lstNpcs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstNpcs_AfterSelect);
            this.lstNpcs.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstNpcs_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder_Open_16xLG.png");
            this.imageList.Images.SetKeyName(1, "LegacyPackage_16x.png");
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.lblLevel);
            this.grpGeneral.Controls.Add(this.nudLevel);
            this.grpGeneral.Controls.Add(this.cmbSprite);
            this.grpGeneral.Controls.Add(this.lblPic);
            this.grpGeneral.Controls.Add(this.picNpc);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(3, 22);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.grpGeneral.Size = new System.Drawing.Size(276, 226);
            this.grpGeneral.TabIndex = 14;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(236, 55);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddFolder.Size = new System.Drawing.Size(24, 26);
            this.btnAddFolder.TabIndex = 67;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(8, 60);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(52, 17);
            this.lblFolder.TabIndex = 66;
            this.lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            this.cmbFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFolder.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFolder.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbFolder.ButtonIcon")));
            this.cmbFolder.DrawDropdownHoverOutline = false;
            this.cmbFolder.DrawFocusRectangle = false;
            this.cmbFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Location = new System.Drawing.Point(80, 55);
            this.cmbFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(149, 23);
            this.cmbFolder.TabIndex = 65;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(8, 96);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 17);
            this.lblLevel.TabIndex = 64;
            this.lblLevel.Text = "Level:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(80, 92);
            this.nudLevel.Margin = new System.Windows.Forms.Padding(4);
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(180, 22);
            this.nudLevel.TabIndex = 63;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // cmbSprite
            // 
            this.cmbSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSprite.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSprite.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSprite.ButtonIcon")));
            this.cmbSprite.DrawDropdownHoverOutline = false;
            this.cmbSprite.DrawFocusRectangle = false;
            this.cmbSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSprite.FormattingEnabled = true;
            this.cmbSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbSprite.Location = new System.Drawing.Point(100, 162);
            this.cmbSprite.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(159, 23);
            this.cmbSprite.TabIndex = 11;
            this.cmbSprite.Text = "None";
            this.cmbSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSprite.SelectedIndexChanged += new System.EventHandler(this.cmbSprite_SelectedIndexChanged);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(96, 143);
            this.lblPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(49, 17);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "Sprite:";
            // 
            // picNpc
            // 
            this.picNpc.BackColor = System.Drawing.Color.Black;
            this.picNpc.Location = new System.Drawing.Point(8, 133);
            this.picNpc.Margin = new System.Windows.Forms.Padding(4);
            this.picNpc.Name = "picNpc";
            this.picNpc.Size = new System.Drawing.Size(85, 79);
            this.picNpc.TabIndex = 4;
            this.picNpc.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(80, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // nudSpawnDuration
            // 
            this.nudSpawnDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpawnDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawnDuration.Location = new System.Drawing.Point(163, 121);
            this.nudSpawnDuration.Margin = new System.Windows.Forms.Padding(4);
            this.nudSpawnDuration.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpawnDuration.Name = "nudSpawnDuration";
            this.nudSpawnDuration.Size = new System.Drawing.Size(119, 22);
            this.nudSpawnDuration.TabIndex = 61;
            this.nudSpawnDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpawnDuration.ValueChanged += new System.EventHandler(this.nudSpawnDuration_ValueChanged);
            // 
            // lblSpawnDuration
            // 
            this.lblSpawnDuration.AutoSize = true;
            this.lblSpawnDuration.Location = new System.Drawing.Point(13, 124);
            this.lblSpawnDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpawnDuration.Name = "lblSpawnDuration";
            this.lblSpawnDuration.Size = new System.Drawing.Size(112, 17);
            this.lblSpawnDuration.TabIndex = 7;
            this.lblSpawnDuration.Text = "Spawn Duration:";
            // 
            // nudSightRange
            // 
            this.nudSightRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSightRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSightRange.Location = new System.Drawing.Point(120, 54);
            this.nudSightRange.Margin = new System.Windows.Forms.Padding(4);
            this.nudSightRange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSightRange.Name = "nudSightRange";
            this.nudSightRange.Size = new System.Drawing.Size(161, 22);
            this.nudSightRange.TabIndex = 62;
            this.nudSightRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSightRange.ValueChanged += new System.EventHandler(this.nudSightRange_ValueChanged);
            // 
            // lblSightRange
            // 
            this.lblSightRange.AutoSize = true;
            this.lblSightRange.Location = new System.Drawing.Point(13, 57);
            this.lblSightRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSightRange.Name = "lblSightRange";
            this.lblSightRange.Size = new System.Drawing.Size(90, 17);
            this.lblSightRange.TabIndex = 12;
            this.lblSightRange.Text = "Sight Range:";
            // 
            // grpStats
            // 
            this.grpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStats.Controls.Add(this.nudFaith);
            this.grpStats.Controls.Add(this.lblFaith);
            this.grpStats.Controls.Add(this.nudExp);
            this.grpStats.Controls.Add(this.nudMana);
            this.grpStats.Controls.Add(this.nudHp);
            this.grpStats.Controls.Add(this.nudSpd);
            this.grpStats.Controls.Add(this.nudMR);
            this.grpStats.Controls.Add(this.nudDef);
            this.grpStats.Controls.Add(this.nudMag);
            this.grpStats.Controls.Add(this.nudStr);
            this.grpStats.Controls.Add(this.lblSpd);
            this.grpStats.Controls.Add(this.lblMR);
            this.grpStats.Controls.Add(this.lblDef);
            this.grpStats.Controls.Add(this.lblMag);
            this.grpStats.Controls.Add(this.lblStr);
            this.grpStats.Controls.Add(this.lblMana);
            this.grpStats.Controls.Add(this.lblHP);
            this.grpStats.Controls.Add(this.lblExp);
            this.grpStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStats.Location = new System.Drawing.Point(4, 248);
            this.grpStats.Margin = new System.Windows.Forms.Padding(4);
            this.grpStats.Name = "grpStats";
            this.grpStats.Padding = new System.Windows.Forms.Padding(4);
            this.grpStats.Size = new System.Drawing.Size(275, 219);
            this.grpStats.TabIndex = 15;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats:";
            // 
            // nudFaith
            // 
            this.nudFaith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFaith.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFaith.Location = new System.Drawing.Point(140, 156);
            this.nudFaith.Margin = new System.Windows.Forms.Padding(4);
            this.nudFaith.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFaith.Name = "nudFaith";
            this.nudFaith.Size = new System.Drawing.Size(103, 22);
            this.nudFaith.TabIndex = 47;
            this.nudFaith.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFaith.ValueChanged += new System.EventHandler(this.nudFaith_ValueChanged);
            // 
            // lblFaith
            // 
            this.lblFaith.AutoSize = true;
            this.lblFaith.Location = new System.Drawing.Point(136, 140);
            this.lblFaith.Name = "lblFaith";
            this.lblFaith.Size = new System.Drawing.Size(43, 17);
            this.lblFaith.TabIndex = 46;
            this.lblFaith.Text = "Faith:";
            // 
            // nudExp
            // 
            this.nudExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExp.Location = new System.Drawing.Point(140, 194);
            this.nudExp.Margin = new System.Windows.Forms.Padding(4);
            this.nudExp.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(103, 22);
            this.nudExp.TabIndex = 45;
            this.nudExp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudExp.ValueChanged += new System.EventHandler(this.nudExp_ValueChanged);
            // 
            // nudMana
            // 
            this.nudMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMana.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMana.Location = new System.Drawing.Point(140, 33);
            this.nudMana.Margin = new System.Windows.Forms.Padding(4);
            this.nudMana.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMana.Name = "nudMana";
            this.nudMana.Size = new System.Drawing.Size(103, 22);
            this.nudMana.TabIndex = 44;
            this.nudMana.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMana.ValueChanged += new System.EventHandler(this.nudMana_ValueChanged);
            // 
            // nudHp
            // 
            this.nudHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHp.Location = new System.Drawing.Point(16, 33);
            this.nudHp.Margin = new System.Windows.Forms.Padding(4);
            this.nudHp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHp.Name = "nudHp";
            this.nudHp.Size = new System.Drawing.Size(103, 22);
            this.nudHp.TabIndex = 43;
            this.nudHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHp.ValueChanged += new System.EventHandler(this.nudHp_ValueChanged);
            // 
            // nudSpd
            // 
            this.nudSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpd.Location = new System.Drawing.Point(17, 154);
            this.nudSpd.Margin = new System.Windows.Forms.Padding(4);
            this.nudSpd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(103, 22);
            this.nudSpd.TabIndex = 42;
            this.nudSpd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpd.ValueChanged += new System.EventHandler(this.nudSpd_ValueChanged);
            // 
            // nudMR
            // 
            this.nudMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMR.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMR.Location = new System.Drawing.Point(140, 115);
            this.nudMR.Margin = new System.Windows.Forms.Padding(4);
            this.nudMR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMR.Name = "nudMR";
            this.nudMR.Size = new System.Drawing.Size(105, 22);
            this.nudMR.TabIndex = 41;
            this.nudMR.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMR.ValueChanged += new System.EventHandler(this.nudMR_ValueChanged);
            // 
            // nudDef
            // 
            this.nudDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDef.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDef.Location = new System.Drawing.Point(16, 113);
            this.nudDef.Margin = new System.Windows.Forms.Padding(4);
            this.nudDef.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDef.Name = "nudDef";
            this.nudDef.Size = new System.Drawing.Size(105, 22);
            this.nudDef.TabIndex = 40;
            this.nudDef.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDef.ValueChanged += new System.EventHandler(this.nudDef_ValueChanged);
            // 
            // nudMag
            // 
            this.nudMag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMag.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMag.Location = new System.Drawing.Point(140, 73);
            this.nudMag.Margin = new System.Windows.Forms.Padding(4);
            this.nudMag.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMag.Name = "nudMag";
            this.nudMag.Size = new System.Drawing.Size(103, 22);
            this.nudMag.TabIndex = 39;
            this.nudMag.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMag.ValueChanged += new System.EventHandler(this.nudMag_ValueChanged);
            // 
            // nudStr
            // 
            this.nudStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStr.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStr.Location = new System.Drawing.Point(17, 71);
            this.nudStr.Margin = new System.Windows.Forms.Padding(4);
            this.nudStr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(103, 22);
            this.nudStr.TabIndex = 38;
            this.nudStr.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStr.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged);
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Location = new System.Drawing.Point(13, 138);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(91, 17);
            this.lblSpd.TabIndex = 37;
            this.lblSpd.Text = "Move Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(139, 95);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(92, 17);
            this.lblMR.TabIndex = 36;
            this.lblMR.Text = "Magic Resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(12, 93);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(50, 17);
            this.lblDef.TabIndex = 35;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(141, 52);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(49, 17);
            this.lblMag.TabIndex = 34;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(12, 51);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(66, 17);
            this.lblStr.TabIndex = 33;
            this.lblStr.Text = "Strength:";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(144, 12);
            this.lblMana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(47, 17);
            this.lblMana.TabIndex = 15;
            this.lblMana.Text = "Mana:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(13, 13);
            this.lblHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(31, 17);
            this.lblHP.TabIndex = 14;
            this.lblHP.Text = "HP:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(138, 177);
            this.lblExp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(35, 17);
            this.lblExp.TabIndex = 11;
            this.lblExp.Text = "Exp:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpElements);
            this.pnlContainer.Controls.Add(this.grpCombat);
            this.pnlContainer.Controls.Add(this.grpCommonEvents);
            this.pnlContainer.Controls.Add(this.grpBehavior);
            this.pnlContainer.Controls.Add(this.grpRegen);
            this.pnlContainer.Controls.Add(this.grpDrops);
            this.pnlContainer.Controls.Add(this.grpNpcVsNpc);
            this.pnlContainer.Controls.Add(this.grpSpells);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpStats);
            this.pnlContainer.Location = new System.Drawing.Point(300, 48);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(619, 728);
            this.pnlContainer.TabIndex = 17;
            // 
            // grpElements
            // 
            this.grpElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpElements.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpElements.Controls.Add(this.nudLight);
            this.grpElements.Controls.Add(this.lblLight);
            this.grpElements.Controls.Add(this.nudDark);
            this.grpElements.Controls.Add(this.nudIce);
            this.grpElements.Controls.Add(this.nudFire);
            this.grpElements.Controls.Add(this.nudNature);
            this.grpElements.Controls.Add(this.nudWater);
            this.grpElements.Controls.Add(this.nudWind);
            this.grpElements.Controls.Add(this.nudThunder);
            this.grpElements.Controls.Add(this.nudEarth);
            this.grpElements.Controls.Add(this.lblNature);
            this.grpElements.Controls.Add(this.lblWater);
            this.grpElements.Controls.Add(this.lblWind);
            this.grpElements.Controls.Add(this.lblThunder);
            this.grpElements.Controls.Add(this.lblEarth);
            this.grpElements.Controls.Add(this.lblIce);
            this.grpElements.Controls.Add(this.lblFire);
            this.grpElements.Controls.Add(this.lblDark);
            this.grpElements.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpElements.Location = new System.Drawing.Point(5, 480);
            this.grpElements.Margin = new System.Windows.Forms.Padding(4);
            this.grpElements.Name = "grpElements";
            this.grpElements.Padding = new System.Windows.Forms.Padding(4);
            this.grpElements.Size = new System.Drawing.Size(275, 157);
            this.grpElements.TabIndex = 48;
            this.grpElements.TabStop = false;
            this.grpElements.Text = "Elements:";
            // 
            // nudLight
            // 
            this.nudLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLight.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLight.Location = new System.Drawing.Point(95, 123);
            this.nudLight.Margin = new System.Windows.Forms.Padding(4);
            this.nudLight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudLight.Name = "nudLight";
            this.nudLight.Size = new System.Drawing.Size(62, 22);
            this.nudLight.TabIndex = 47;
            this.nudLight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLight.ValueChanged += new System.EventHandler(this.nudLight_ValueChanged);
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Location = new System.Drawing.Point(92, 103);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(43, 17);
            this.lblLight.TabIndex = 46;
            this.lblLight.Text = "Light:";
            // 
            // nudDark
            // 
            this.nudDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDark.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDark.Location = new System.Drawing.Point(172, 123);
            this.nudDark.Margin = new System.Windows.Forms.Padding(4);
            this.nudDark.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudDark.Name = "nudDark";
            this.nudDark.Size = new System.Drawing.Size(60, 22);
            this.nudDark.TabIndex = 45;
            this.nudDark.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDark.ValueChanged += new System.EventHandler(this.nudDark_ValueChanged);
            // 
            // nudIce
            // 
            this.nudIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudIce.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIce.Location = new System.Drawing.Point(95, 33);
            this.nudIce.Margin = new System.Windows.Forms.Padding(4);
            this.nudIce.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIce.Name = "nudIce";
            this.nudIce.Size = new System.Drawing.Size(62, 22);
            this.nudIce.TabIndex = 44;
            this.nudIce.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudIce.ValueChanged += new System.EventHandler(this.nudIce_ValueChanged);
            // 
            // nudFire
            // 
            this.nudFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFire.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFire.Location = new System.Drawing.Point(16, 33);
            this.nudFire.Margin = new System.Windows.Forms.Padding(4);
            this.nudFire.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFire.Name = "nudFire";
            this.nudFire.Size = new System.Drawing.Size(61, 22);
            this.nudFire.TabIndex = 43;
            this.nudFire.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFire.ValueChanged += new System.EventHandler(this.nudFire_ValueChanged);
            // 
            // nudNature
            // 
            this.nudNature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudNature.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudNature.Location = new System.Drawing.Point(15, 124);
            this.nudNature.Margin = new System.Windows.Forms.Padding(4);
            this.nudNature.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudNature.Name = "nudNature";
            this.nudNature.Size = new System.Drawing.Size(62, 22);
            this.nudNature.TabIndex = 42;
            this.nudNature.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNature.ValueChanged += new System.EventHandler(this.nudNature_ValueChanged);
            // 
            // nudWater
            // 
            this.nudWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWater.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWater.Location = new System.Drawing.Point(170, 75);
            this.nudWater.Margin = new System.Windows.Forms.Padding(4);
            this.nudWater.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(62, 22);
            this.nudWater.TabIndex = 41;
            this.nudWater.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWater.ValueChanged += new System.EventHandler(this.nudWater_ValueChanged);
            // 
            // nudWind
            // 
            this.nudWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWind.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWind.Location = new System.Drawing.Point(95, 79);
            this.nudWind.Margin = new System.Windows.Forms.Padding(4);
            this.nudWind.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWind.Name = "nudWind";
            this.nudWind.Size = new System.Drawing.Size(62, 22);
            this.nudWind.TabIndex = 40;
            this.nudWind.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWind.ValueChanged += new System.EventHandler(this.nudWind_ValueChanged);
            // 
            // nudThunder
            // 
            this.nudThunder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudThunder.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudThunder.Location = new System.Drawing.Point(172, 34);
            this.nudThunder.Margin = new System.Windows.Forms.Padding(4);
            this.nudThunder.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThunder.Name = "nudThunder";
            this.nudThunder.Size = new System.Drawing.Size(60, 22);
            this.nudThunder.TabIndex = 39;
            this.nudThunder.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudThunder.ValueChanged += new System.EventHandler(this.nudThunder_ValueChanged);
            // 
            // nudEarth
            // 
            this.nudEarth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudEarth.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudEarth.Location = new System.Drawing.Point(17, 79);
            this.nudEarth.Margin = new System.Windows.Forms.Padding(4);
            this.nudEarth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEarth.Name = "nudEarth";
            this.nudEarth.Size = new System.Drawing.Size(60, 22);
            this.nudEarth.TabIndex = 38;
            this.nudEarth.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudEarth.ValueChanged += new System.EventHandler(this.nudEarth_ValueChanged);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(14, 103);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(55, 17);
            this.lblNature.TabIndex = 37;
            this.lblNature.Text = "Nature:";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(168, 59);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(50, 17);
            this.lblWater.TabIndex = 36;
            this.lblWater.Text = "Water:";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(92, 58);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(44, 17);
            this.lblWind.TabIndex = 35;
            this.lblWind.Text = "Wind:";
            // 
            // lblThunder
            // 
            this.lblThunder.AutoSize = true;
            this.lblThunder.Location = new System.Drawing.Point(169, 13);
            this.lblThunder.Name = "lblThunder";
            this.lblThunder.Size = new System.Drawing.Size(66, 17);
            this.lblThunder.TabIndex = 34;
            this.lblThunder.Text = "Thunder:";
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Location = new System.Drawing.Point(12, 59);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(46, 17);
            this.lblEarth.TabIndex = 33;
            this.lblEarth.Text = "Earth:";
            // 
            // lblIce
            // 
            this.lblIce.AutoSize = true;
            this.lblIce.Location = new System.Drawing.Point(92, 12);
            this.lblIce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIce.Name = "lblIce";
            this.lblIce.Size = new System.Drawing.Size(30, 17);
            this.lblIce.TabIndex = 15;
            this.lblIce.Text = "Ice:";
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Location = new System.Drawing.Point(13, 13);
            this.lblFire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(36, 17);
            this.lblFire.TabIndex = 14;
            this.lblFire.Text = "Fire:";
            // 
            // lblDark
            // 
            this.lblDark.AutoSize = true;
            this.lblDark.Location = new System.Drawing.Point(169, 103);
            this.lblDark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDark.Name = "lblDark";
            this.lblDark.Size = new System.Drawing.Size(42, 17);
            this.lblDark.TabIndex = 11;
            this.lblDark.Text = "Dark:";
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCombat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCombat.Controls.Add(this.grpAttackSpeed);
            this.grpCombat.Controls.Add(this.nudCritMultiplier);
            this.grpCombat.Controls.Add(this.lblCritMultiplier);
            this.grpCombat.Controls.Add(this.nudScaling);
            this.grpCombat.Controls.Add(this.nudDamage);
            this.grpCombat.Controls.Add(this.nudCritChance);
            this.grpCombat.Controls.Add(this.cmbScalingStat);
            this.grpCombat.Controls.Add(this.lblScalingStat);
            this.grpCombat.Controls.Add(this.lblScaling);
            this.grpCombat.Controls.Add(this.cmbDamageType);
            this.grpCombat.Controls.Add(this.lblDamageType);
            this.grpCombat.Controls.Add(this.lblCritChance);
            this.grpCombat.Controls.Add(this.cmbAttackAnimation);
            this.grpCombat.Controls.Add(this.lblAttackAnimation);
            this.grpCombat.Controls.Add(this.lblDamage);
            this.grpCombat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCombat.Location = new System.Drawing.Point(287, 403);
            this.grpCombat.Margin = new System.Windows.Forms.Padding(4);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Padding = new System.Windows.Forms.Padding(4);
            this.grpCombat.Size = new System.Drawing.Size(301, 506);
            this.grpCombat.TabIndex = 17;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat";
            // 
            // grpAttackSpeed
            // 
            this.grpAttackSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAttackSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAttackSpeed.Controls.Add(this.nudAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedValue);
            this.grpAttackSpeed.Controls.Add(this.cmbAttackSpeedModifier);
            this.grpAttackSpeed.Controls.Add(this.lblAttackSpeedModifier);
            this.grpAttackSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAttackSpeed.Location = new System.Drawing.Point(16, 382);
            this.grpAttackSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.grpAttackSpeed.Name = "grpAttackSpeed";
            this.grpAttackSpeed.Padding = new System.Windows.Forms.Padding(4);
            this.grpAttackSpeed.Size = new System.Drawing.Size(256, 106);
            this.grpAttackSpeed.TabIndex = 64;
            this.grpAttackSpeed.TabStop = false;
            this.grpAttackSpeed.Text = "Attack Speed";
            // 
            // nudAttackSpeedValue
            // 
            this.nudAttackSpeedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAttackSpeedValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAttackSpeedValue.Location = new System.Drawing.Point(80, 71);
            this.nudAttackSpeedValue.Margin = new System.Windows.Forms.Padding(4);
            this.nudAttackSpeedValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAttackSpeedValue.Name = "nudAttackSpeedValue";
            this.nudAttackSpeedValue.Size = new System.Drawing.Size(152, 22);
            this.nudAttackSpeedValue.TabIndex = 56;
            this.nudAttackSpeedValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAttackSpeedValue.ValueChanged += new System.EventHandler(this.nudAttackSpeedValue_ValueChanged);
            // 
            // lblAttackSpeedValue
            // 
            this.lblAttackSpeedValue.AutoSize = true;
            this.lblAttackSpeedValue.Location = new System.Drawing.Point(12, 74);
            this.lblAttackSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttackSpeedValue.Name = "lblAttackSpeedValue";
            this.lblAttackSpeedValue.Size = new System.Drawing.Size(48, 17);
            this.lblAttackSpeedValue.TabIndex = 29;
            this.lblAttackSpeedValue.Text = "Value:";
            // 
            // cmbAttackSpeedModifier
            // 
            this.cmbAttackSpeedModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAttackSpeedModifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAttackSpeedModifier.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAttackSpeedModifier.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAttackSpeedModifier.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbAttackSpeedModifier.ButtonIcon")));
            this.cmbAttackSpeedModifier.DrawDropdownHoverOutline = false;
            this.cmbAttackSpeedModifier.DrawFocusRectangle = false;
            this.cmbAttackSpeedModifier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttackSpeedModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttackSpeedModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttackSpeedModifier.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAttackSpeedModifier.FormattingEnabled = true;
            this.cmbAttackSpeedModifier.Location = new System.Drawing.Point(80, 30);
            this.cmbAttackSpeedModifier.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAttackSpeedModifier.Name = "cmbAttackSpeedModifier";
            this.cmbAttackSpeedModifier.Size = new System.Drawing.Size(151, 23);
            this.cmbAttackSpeedModifier.TabIndex = 28;
            this.cmbAttackSpeedModifier.Text = null;
            this.cmbAttackSpeedModifier.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackSpeedModifier.SelectedIndexChanged += new System.EventHandler(this.cmbAttackSpeedModifier_SelectedIndexChanged);
            // 
            // lblAttackSpeedModifier
            // 
            this.lblAttackSpeedModifier.AutoSize = true;
            this.lblAttackSpeedModifier.Location = new System.Drawing.Point(12, 33);
            this.lblAttackSpeedModifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttackSpeedModifier.Name = "lblAttackSpeedModifier";
            this.lblAttackSpeedModifier.Size = new System.Drawing.Size(62, 17);
            this.lblAttackSpeedModifier.TabIndex = 0;
            this.lblAttackSpeedModifier.Text = "Modifier:";
            // 
            // nudCritMultiplier
            // 
            this.nudCritMultiplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritMultiplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCritMultiplier.Location = new System.Drawing.Point(17, 135);
            this.nudCritMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.nudCritMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCritMultiplier.Name = "nudCritMultiplier";
            this.nudCritMultiplier.Size = new System.Drawing.Size(255, 22);
            this.nudCritMultiplier.TabIndex = 63;
            this.nudCritMultiplier.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritMultiplier.ValueChanged += new System.EventHandler(this.nudCritMultiplier_ValueChanged);
            // 
            // lblCritMultiplier
            // 
            this.lblCritMultiplier.AutoSize = true;
            this.lblCritMultiplier.Location = new System.Drawing.Point(13, 118);
            this.lblCritMultiplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCritMultiplier.Name = "lblCritMultiplier";
            this.lblCritMultiplier.Size = new System.Drawing.Size(182, 17);
            this.lblCritMultiplier.TabIndex = 62;
            this.lblCritMultiplier.Text = "Crit Multiplier (Default 1.5x):";
            // 
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(16, 293);
            this.nudScaling.Margin = new System.Windows.Forms.Padding(4);
            this.nudScaling.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(255, 22);
            this.nudScaling.TabIndex = 61;
            this.nudScaling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudScaling.ValueChanged += new System.EventHandler(this.nudScaling_ValueChanged);
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(16, 42);
            this.nudDamage.Margin = new System.Windows.Forms.Padding(4);
            this.nudDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(256, 22);
            this.nudDamage.TabIndex = 60;
            this.nudDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDamage.ValueChanged += new System.EventHandler(this.nudDamage_ValueChanged);
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(17, 87);
            this.nudCritChance.Margin = new System.Windows.Forms.Padding(4);
            this.nudCritChance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(255, 22);
            this.nudCritChance.TabIndex = 59;
            this.nudCritChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritChance.ValueChanged += new System.EventHandler(this.nudCritChance_ValueChanged);
            // 
            // cmbScalingStat
            // 
            this.cmbScalingStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbScalingStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbScalingStat.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbScalingStat.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbScalingStat.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbScalingStat.ButtonIcon")));
            this.cmbScalingStat.DrawDropdownHoverOutline = false;
            this.cmbScalingStat.DrawFocusRectangle = false;
            this.cmbScalingStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbScalingStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScalingStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScalingStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbScalingStat.FormattingEnabled = true;
            this.cmbScalingStat.Location = new System.Drawing.Point(17, 236);
            this.cmbScalingStat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(253, 23);
            this.cmbScalingStat.TabIndex = 58;
            this.cmbScalingStat.Text = null;
            this.cmbScalingStat.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbScalingStat.SelectedIndexChanged += new System.EventHandler(this.cmbScalingStat_SelectedIndexChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(13, 215);
            this.lblScalingStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(87, 17);
            this.lblScalingStat.TabIndex = 57;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // lblScaling
            // 
            this.lblScaling.AutoSize = true;
            this.lblScaling.Location = new System.Drawing.Point(12, 268);
            this.lblScaling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaling.Name = "lblScaling";
            this.lblScaling.Size = new System.Drawing.Size(110, 17);
            this.lblScaling.TabIndex = 56;
            this.lblScaling.Text = "Scaling Amount:";
            // 
            // cmbDamageType
            // 
            this.cmbDamageType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDamageType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDamageType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDamageType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDamageType.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbDamageType.ButtonIcon")));
            this.cmbDamageType.DrawDropdownHoverOutline = false;
            this.cmbDamageType.DrawFocusRectangle = false;
            this.cmbDamageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDamageType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDamageType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDamageType.FormattingEnabled = true;
            this.cmbDamageType.Items.AddRange(new object[] {
            "Physical",
            "Magic",
            "True",
            "Faith",
            "Fire",
            "Ice",
            "Thunder",
            "Earth",
            "Wind",
            "Water",
            "Nature",
            "Light",
            "Dark"});
            this.cmbDamageType.Location = new System.Drawing.Point(17, 186);
            this.cmbDamageType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(253, 23);
            this.cmbDamageType.TabIndex = 54;
            this.cmbDamageType.Text = "Physical";
            this.cmbDamageType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDamageType.SelectedIndexChanged += new System.EventHandler(this.cmbDamageType_SelectedIndexChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(13, 165);
            this.lblDamageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(101, 17);
            this.lblDamageType.TabIndex = 53;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(12, 71);
            this.lblCritChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(111, 17);
            this.lblCritChance.TabIndex = 52;
            this.lblCritChance.Text = "Crit Chance (%):";
            // 
            // cmbAttackAnimation
            // 
            this.cmbAttackAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAttackAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAttackAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAttackAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAttackAnimation.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbAttackAnimation.ButtonIcon")));
            this.cmbAttackAnimation.DrawDropdownHoverOutline = false;
            this.cmbAttackAnimation.DrawFocusRectangle = false;
            this.cmbAttackAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttackAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttackAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttackAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAttackAnimation.FormattingEnabled = true;
            this.cmbAttackAnimation.Location = new System.Drawing.Point(16, 338);
            this.cmbAttackAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAttackAnimation.Name = "cmbAttackAnimation";
            this.cmbAttackAnimation.Size = new System.Drawing.Size(255, 23);
            this.cmbAttackAnimation.TabIndex = 50;
            this.cmbAttackAnimation.Text = null;
            this.cmbAttackAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAttackAnimation_SelectedIndexChanged);
            // 
            // lblAttackAnimation
            // 
            this.lblAttackAnimation.AutoSize = true;
            this.lblAttackAnimation.Location = new System.Drawing.Point(12, 320);
            this.lblAttackAnimation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttackAnimation.Name = "lblAttackAnimation";
            this.lblAttackAnimation.Size = new System.Drawing.Size(117, 17);
            this.lblAttackAnimation.TabIndex = 49;
            this.lblAttackAnimation.Text = "Attack Animation:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(12, 22);
            this.lblDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(101, 17);
            this.lblDamage.TabIndex = 48;
            this.lblDamage.Text = "Base Damage:";
            // 
            // grpCommonEvents
            // 
            this.grpCommonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCommonEvents.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCommonEvents.Controls.Add(this.cmbOnDeathEventParty);
            this.grpCommonEvents.Controls.Add(this.lblOnDeathEventParty);
            this.grpCommonEvents.Controls.Add(this.cmbOnDeathEventKiller);
            this.grpCommonEvents.Controls.Add(this.lblOnDeathEventKiller);
            this.grpCommonEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCommonEvents.Location = new System.Drawing.Point(287, 1249);
            this.grpCommonEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCommonEvents.Name = "grpCommonEvents";
            this.grpCommonEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCommonEvents.Size = new System.Drawing.Size(305, 130);
            this.grpCommonEvents.TabIndex = 32;
            this.grpCommonEvents.TabStop = false;
            this.grpCommonEvents.Text = "Common Events";
            // 
            // cmbOnDeathEventParty
            // 
            this.cmbOnDeathEventParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbOnDeathEventParty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbOnDeathEventParty.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbOnDeathEventParty.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbOnDeathEventParty.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbOnDeathEventParty.ButtonIcon")));
            this.cmbOnDeathEventParty.DrawDropdownHoverOutline = false;
            this.cmbOnDeathEventParty.DrawFocusRectangle = false;
            this.cmbOnDeathEventParty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOnDeathEventParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnDeathEventParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOnDeathEventParty.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbOnDeathEventParty.FormattingEnabled = true;
            this.cmbOnDeathEventParty.Location = new System.Drawing.Point(16, 98);
            this.cmbOnDeathEventParty.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOnDeathEventParty.Name = "cmbOnDeathEventParty";
            this.cmbOnDeathEventParty.Size = new System.Drawing.Size(241, 23);
            this.cmbOnDeathEventParty.TabIndex = 21;
            this.cmbOnDeathEventParty.Text = null;
            this.cmbOnDeathEventParty.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbOnDeathEventParty.SelectedIndexChanged += new System.EventHandler(this.cmbOnDeathEventParty_SelectedIndexChanged);
            // 
            // lblOnDeathEventParty
            // 
            this.lblOnDeathEventParty.AutoSize = true;
            this.lblOnDeathEventParty.Location = new System.Drawing.Point(12, 79);
            this.lblOnDeathEventParty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnDeathEventParty.Name = "lblOnDeathEventParty";
            this.lblOnDeathEventParty.Size = new System.Drawing.Size(140, 17);
            this.lblOnDeathEventParty.TabIndex = 20;
            this.lblOnDeathEventParty.Text = "On Death (for party):";
            // 
            // cmbOnDeathEventKiller
            // 
            this.cmbOnDeathEventKiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbOnDeathEventKiller.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbOnDeathEventKiller.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbOnDeathEventKiller.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbOnDeathEventKiller.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbOnDeathEventKiller.ButtonIcon")));
            this.cmbOnDeathEventKiller.DrawDropdownHoverOutline = false;
            this.cmbOnDeathEventKiller.DrawFocusRectangle = false;
            this.cmbOnDeathEventKiller.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOnDeathEventKiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnDeathEventKiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOnDeathEventKiller.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbOnDeathEventKiller.FormattingEnabled = true;
            this.cmbOnDeathEventKiller.Location = new System.Drawing.Point(16, 44);
            this.cmbOnDeathEventKiller.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOnDeathEventKiller.Name = "cmbOnDeathEventKiller";
            this.cmbOnDeathEventKiller.Size = new System.Drawing.Size(241, 23);
            this.cmbOnDeathEventKiller.TabIndex = 19;
            this.cmbOnDeathEventKiller.Text = null;
            this.cmbOnDeathEventKiller.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbOnDeathEventKiller.SelectedIndexChanged += new System.EventHandler(this.cmbOnDeathEventKiller_SelectedIndexChanged);
            // 
            // lblOnDeathEventKiller
            // 
            this.lblOnDeathEventKiller.AutoSize = true;
            this.lblOnDeathEventKiller.Location = new System.Drawing.Point(12, 25);
            this.lblOnDeathEventKiller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnDeathEventKiller.Name = "lblOnDeathEventKiller";
            this.lblOnDeathEventKiller.Size = new System.Drawing.Size(137, 17);
            this.lblOnDeathEventKiller.TabIndex = 18;
            this.lblOnDeathEventKiller.Text = "On Death (for killer):";
            // 
            // grpBehavior
            // 
            this.grpBehavior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpBehavior.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpBehavior.Controls.Add(this.nbrMoveRange);
            this.grpBehavior.Controls.Add(this.label1);
            this.grpBehavior.Controls.Add(this.lblFocusDamageDealer);
            this.grpBehavior.Controls.Add(this.chkFocusDamageDealer);
            this.grpBehavior.Controls.Add(this.nudSpawnDuration);
            this.grpBehavior.Controls.Add(this.lblSpawnDuration);
            this.grpBehavior.Controls.Add(this.nudFlee);
            this.grpBehavior.Controls.Add(this.lblFlee);
            this.grpBehavior.Controls.Add(this.lblSwarm);
            this.grpBehavior.Controls.Add(this.chkSwarm);
            this.grpBehavior.Controls.Add(this.grpConditions);
            this.grpBehavior.Controls.Add(this.lblMovement);
            this.grpBehavior.Controls.Add(this.cmbMovement);
            this.grpBehavior.Controls.Add(this.lblAggressive);
            this.grpBehavior.Controls.Add(this.chkAggressive);
            this.grpBehavior.Controls.Add(this.nudSightRange);
            this.grpBehavior.Controls.Add(this.lblSightRange);
            this.grpBehavior.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpBehavior.Location = new System.Drawing.Point(287, 31);
            this.grpBehavior.Margin = new System.Windows.Forms.Padding(4);
            this.grpBehavior.Name = "grpBehavior";
            this.grpBehavior.Padding = new System.Windows.Forms.Padding(4);
            this.grpBehavior.Size = new System.Drawing.Size(301, 372);
            this.grpBehavior.TabIndex = 32;
            this.grpBehavior.TabStop = false;
            this.grpBehavior.Text = "Behavior:";
            // 
            // nbrMoveRange
            // 
            this.nbrMoveRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nbrMoveRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nbrMoveRange.Location = new System.Drawing.Point(133, 137);
            this.nbrMoveRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nbrMoveRange.Name = "nbrMoveRange";
            this.nbrMoveRange.Size = new System.Drawing.Size(87, 20);
            this.nbrMoveRange.TabIndex = 74;
            this.nbrMoveRange.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbrMoveRange.ValueChanged += new System.EventHandler(this.nbrMoveRange_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Movement Range:";
            // 
            // lblFocusDamageDealer
            // 
            this.lblFocusDamageDealer.AutoSize = true;
            this.lblFocusDamageDealer.Location = new System.Drawing.Point(10, 159);
            this.lblFocusDamageDealer.Name = "lblFocusDamageDealer";
            this.lblFocusDamageDealer.Size = new System.Drawing.Size(205, 17);
            this.lblFocusDamageDealer.TabIndex = 72;
            this.lblFocusDamageDealer.Text = "Focus Highest Damage Dealer:";
            // 
            // chkFocusDamageDealer
            // 
            this.chkFocusDamageDealer.AutoSize = true;
            this.chkFocusDamageDealer.Location = new System.Drawing.Point(171, 158);
            this.chkFocusDamageDealer.Name = "chkFocusDamageDealer";
            this.chkFocusDamageDealer.Size = new System.Drawing.Size(18, 17);
            this.chkFocusDamageDealer.TabIndex = 71;
            this.chkFocusDamageDealer.CheckedChanged += new System.EventHandler(this.chkFocusDamageDealer_CheckedChanged);
            // 
            // nudFlee
            // 
            this.nudFlee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFlee.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFlee.Location = new System.Drawing.Point(120, 154);
            this.nudFlee.Margin = new System.Windows.Forms.Padding(4);
            this.nudFlee.Name = "nudFlee";
            this.nudFlee.Size = new System.Drawing.Size(36, 20);
            this.nudFlee.TabIndex = 70;
            this.nudFlee.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFlee.ValueChanged += new System.EventHandler(this.nudFlee_ValueChanged);
            // 
            // lblFlee
            // 
            this.lblFlee.AutoSize = true;
            this.lblFlee.Location = new System.Drawing.Point(13, 156);
            this.lblFlee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlee.Name = "lblFlee";
            this.lblFlee.Size = new System.Drawing.Size(100, 17);
            this.lblFlee.TabIndex = 69;
            this.lblFlee.Text = "Flee Health %:";
            // 
            // lblSwarm
            // 
            this.lblSwarm.AutoSize = true;
            this.lblSwarm.Location = new System.Drawing.Point(153, 25);
            this.lblSwarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSwarm.Name = "lblSwarm";
            this.lblSwarm.Size = new System.Drawing.Size(50, 17);
            this.lblSwarm.TabIndex = 68;
            this.lblSwarm.Text = "Swarm";
            // 
            // chkSwarm
            // 
            this.chkSwarm.AutoSize = true;
            this.chkSwarm.Location = new System.Drawing.Point(213, 25);
            this.chkSwarm.Margin = new System.Windows.Forms.Padding(4);
            this.chkSwarm.Name = "chkSwarm";
            this.chkSwarm.Size = new System.Drawing.Size(18, 17);
            this.chkSwarm.TabIndex = 67;
            this.chkSwarm.CheckedChanged += new System.EventHandler(this.chkSwarm_CheckedChanged);
            // 
            // grpConditions
            // 
            this.grpConditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpConditions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpConditions.Controls.Add(this.btnAttackOnSightCond);
            this.grpConditions.Controls.Add(this.btnPlayerCanAttackCond);
            this.grpConditions.Controls.Add(this.btnPlayerFriendProtectorCond);
            this.grpConditions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpConditions.Location = new System.Drawing.Point(17, 222);
            this.grpConditions.Margin = new System.Windows.Forms.Padding(4);
            this.grpConditions.Name = "grpConditions";
            this.grpConditions.Padding = new System.Windows.Forms.Padding(4);
            this.grpConditions.Size = new System.Drawing.Size(276, 133);
            this.grpConditions.TabIndex = 66;
            this.grpConditions.TabStop = false;
            this.grpConditions.Text = "Conditions:";
            // 
            // btnAttackOnSightCond
            // 
            this.btnAttackOnSightCond.Location = new System.Drawing.Point(8, 59);
            this.btnAttackOnSightCond.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttackOnSightCond.Name = "btnAttackOnSightCond";
            this.btnAttackOnSightCond.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAttackOnSightCond.Size = new System.Drawing.Size(260, 28);
            this.btnAttackOnSightCond.TabIndex = 47;
            this.btnAttackOnSightCond.Text = "Should Not Attack Player On Sight";
            this.btnAttackOnSightCond.Click += new System.EventHandler(this.btnAttackOnSightCond_Click);
            // 
            // btnPlayerCanAttackCond
            // 
            this.btnPlayerCanAttackCond.Location = new System.Drawing.Point(8, 95);
            this.btnPlayerCanAttackCond.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayerCanAttackCond.Name = "btnPlayerCanAttackCond";
            this.btnPlayerCanAttackCond.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPlayerCanAttackCond.Size = new System.Drawing.Size(260, 28);
            this.btnPlayerCanAttackCond.TabIndex = 46;
            this.btnPlayerCanAttackCond.Text = "Player Can Attack (Default: True)";
            this.btnPlayerCanAttackCond.Click += new System.EventHandler(this.btnPlayerCanAttackCond_Click);
            // 
            // btnPlayerFriendProtectorCond
            // 
            this.btnPlayerFriendProtectorCond.Location = new System.Drawing.Point(8, 23);
            this.btnPlayerFriendProtectorCond.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayerFriendProtectorCond.Name = "btnPlayerFriendProtectorCond";
            this.btnPlayerFriendProtectorCond.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPlayerFriendProtectorCond.Size = new System.Drawing.Size(260, 28);
            this.btnPlayerFriendProtectorCond.TabIndex = 44;
            this.btnPlayerFriendProtectorCond.Text = "Player Friend/Protector";
            this.btnPlayerFriendProtectorCond.Click += new System.EventHandler(this.btnPlayerFriendProtectorCond_Click);
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(13, 90);
            this.lblMovement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(77, 17);
            this.lblMovement.TabIndex = 65;
            this.lblMovement.Text = "Movement:";
            // 
            // cmbMovement
            // 
            this.cmbMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMovement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMovement.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMovement.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMovement.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbMovement.ButtonIcon")));
            this.cmbMovement.DrawDropdownHoverOutline = false;
            this.cmbMovement.DrawFocusRectangle = false;
            this.cmbMovement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMovement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMovement.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMovement.FormattingEnabled = true;
            this.cmbMovement.Items.AddRange(new object[] {
            "Move Randomly",
            "Turn Randomly",
            "No Movement"});
            this.cmbMovement.Location = new System.Drawing.Point(120, 86);
            this.cmbMovement.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMovement.Name = "cmbMovement";
            this.cmbMovement.Size = new System.Drawing.Size(160, 23);
            this.cmbMovement.TabIndex = 64;
            this.cmbMovement.Text = "Move Randomly";
            this.cmbMovement.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbMovement.SelectedIndexChanged += new System.EventHandler(this.cmbMovement_SelectedIndexChanged);
            // 
            // lblAggressive
            // 
            this.lblAggressive.AutoSize = true;
            this.lblAggressive.Location = new System.Drawing.Point(13, 25);
            this.lblAggressive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAggressive.Name = "lblAggressive";
            this.lblAggressive.Size = new System.Drawing.Size(78, 17);
            this.lblAggressive.TabIndex = 63;
            this.lblAggressive.Text = "Aggressive";
            // 
            // chkAggressive
            // 
            this.chkAggressive.AutoSize = true;
            this.chkAggressive.Location = new System.Drawing.Point(104, 23);
            this.chkAggressive.Margin = new System.Windows.Forms.Padding(4);
            this.chkAggressive.Name = "chkAggressive";
            this.chkAggressive.Size = new System.Drawing.Size(18, 17);
            this.chkAggressive.TabIndex = 1;
            this.chkAggressive.CheckedChanged += new System.EventHandler(this.chkAggressive_CheckedChanged);
            // 
            // grpRegen
            // 
            this.grpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRegen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRegen.Controls.Add(this.nudMpRegen);
            this.grpRegen.Controls.Add(this.nudHpRegen);
            this.grpRegen.Controls.Add(this.lblHpRegen);
            this.grpRegen.Controls.Add(this.lblManaRegen);
            this.grpRegen.Controls.Add(this.lblRegenHint);
            this.grpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRegen.Location = new System.Drawing.Point(4, 618);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegen.Size = new System.Drawing.Size(275, 122);
            this.grpRegen.TabIndex = 31;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen";
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(11, 85);
            this.nudMpRegen.Margin = new System.Windows.Forms.Padding(4);
            this.nudMpRegen.Name = "nudMpRegen";
            this.nudMpRegen.Size = new System.Drawing.Size(115, 22);
            this.nudMpRegen.TabIndex = 31;
            this.nudMpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMpRegen.ValueChanged += new System.EventHandler(this.nudMpRegen_ValueChanged);
            // 
            // nudHpRegen
            // 
            this.nudHpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHpRegen.Location = new System.Drawing.Point(11, 38);
            this.nudHpRegen.Margin = new System.Windows.Forms.Padding(4);
            this.nudHpRegen.Name = "nudHpRegen";
            this.nudHpRegen.Size = new System.Drawing.Size(115, 22);
            this.nudHpRegen.TabIndex = 30;
            this.nudHpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHpRegen.ValueChanged += new System.EventHandler(this.nudHpRegen_ValueChanged);
            // 
            // lblHpRegen
            // 
            this.lblHpRegen.AutoSize = true;
            this.lblHpRegen.Location = new System.Drawing.Point(7, 21);
            this.lblHpRegen.Name = "lblHpRegen";
            this.lblHpRegen.Size = new System.Drawing.Size(57, 17);
            this.lblHpRegen.TabIndex = 26;
            this.lblHpRegen.Text = "HP: (%)";
            // 
            // lblManaRegen
            // 
            this.lblManaRegen.AutoSize = true;
            this.lblManaRegen.Location = new System.Drawing.Point(7, 66);
            this.lblManaRegen.Name = "lblManaRegen";
            this.lblManaRegen.Size = new System.Drawing.Size(73, 17);
            this.lblManaRegen.TabIndex = 27;
            this.lblManaRegen.Text = "Mana: (%)";
            // 
            // lblRegenHint
            // 
            this.lblRegenHint.Location = new System.Drawing.Point(136, 29);
            this.lblRegenHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegenHint.Name = "lblRegenHint";
            this.lblRegenHint.Size = new System.Drawing.Size(133, 89);
            this.lblRegenHint.TabIndex = 0;
            this.lblRegenHint.Text = "% of HP/Mana to restore per tick.\r\n\r\nTick timer saved in server config.json.";
            // 
            // grpDrops
            // 
            this.grpDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDrops.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDrops.Controls.Add(this.btnDropRemove);
            this.grpDrops.Controls.Add(this.btnDropAdd);
            this.grpDrops.Controls.Add(this.lstDrops);
            this.grpDrops.Controls.Add(this.nudDropAmount);
            this.grpDrops.Controls.Add(this.nudDropChance);
            this.grpDrops.Controls.Add(this.cmbDropItem);
            this.grpDrops.Controls.Add(this.lblDropAmount);
            this.grpDrops.Controls.Add(this.lblDropChance);
            this.grpDrops.Controls.Add(this.lblDropItem);
            this.grpDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDrops.Location = new System.Drawing.Point(291, 917);
            this.grpDrops.Margin = new System.Windows.Forms.Padding(4);
            this.grpDrops.Name = "grpDrops";
            this.grpDrops.Padding = new System.Windows.Forms.Padding(4);
            this.grpDrops.Size = new System.Drawing.Size(301, 327);
            this.grpDrops.TabIndex = 30;
            this.grpDrops.TabStop = false;
            this.grpDrops.Text = "Drops";
            // 
            // btnDropRemove
            // 
            this.btnDropRemove.Location = new System.Drawing.Point(168, 283);
            this.btnDropRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropRemove.Name = "btnDropRemove";
            this.btnDropRemove.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDropRemove.Size = new System.Drawing.Size(100, 28);
            this.btnDropRemove.TabIndex = 64;
            this.btnDropRemove.Text = "Remove";
            this.btnDropRemove.Click += new System.EventHandler(this.btnDropRemove_Click);
            // 
            // btnDropAdd
            // 
            this.btnDropAdd.Location = new System.Drawing.Point(8, 283);
            this.btnDropAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropAdd.Name = "btnDropAdd";
            this.btnDropAdd.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDropAdd.Size = new System.Drawing.Size(100, 28);
            this.btnDropAdd.TabIndex = 63;
            this.btnDropAdd.Text = "Add";
            this.btnDropAdd.Click += new System.EventHandler(this.btnDropAdd_Click);
            // 
            // lstDrops
            // 
            this.lstDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstDrops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstDrops.FormattingEnabled = true;
            this.lstDrops.ItemHeight = 16;
            this.lstDrops.Location = new System.Drawing.Point(12, 23);
            this.lstDrops.Margin = new System.Windows.Forms.Padding(4);
            this.lstDrops.Name = "lstDrops";
            this.lstDrops.Size = new System.Drawing.Size(255, 82);
            this.lstDrops.TabIndex = 62;
            this.lstDrops.SelectedIndexChanged += new System.EventHandler(this.lstDrops_SelectedIndexChanged);
            // 
            // nudDropAmount
            // 
            this.nudDropAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropAmount.Location = new System.Drawing.Point(8, 187);
            this.nudDropAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudDropAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDropAmount.Name = "nudDropAmount";
            this.nudDropAmount.Size = new System.Drawing.Size(260, 22);
            this.nudDropAmount.TabIndex = 61;
            this.nudDropAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDropAmount.ValueChanged += new System.EventHandler(this.nudDropAmount_ValueChanged);
            // 
            // nudDropChance
            // 
            this.nudDropChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropChance.DecimalPlaces = 2;
            this.nudDropChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDropChance.Location = new System.Drawing.Point(8, 244);
            this.nudDropChance.Margin = new System.Windows.Forms.Padding(4);
            this.nudDropChance.Name = "nudDropChance";
            this.nudDropChance.Size = new System.Drawing.Size(260, 22);
            this.nudDropChance.TabIndex = 60;
            this.nudDropChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDropChance.ValueChanged += new System.EventHandler(this.nudDropChance_ValueChanged);
            // 
            // cmbDropItem
            // 
            this.cmbDropItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDropItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDropItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDropItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDropItem.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbDropItem.ButtonIcon")));
            this.cmbDropItem.DrawDropdownHoverOutline = false;
            this.cmbDropItem.DrawFocusRectangle = false;
            this.cmbDropItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDropItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDropItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDropItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDropItem.FormattingEnabled = true;
            this.cmbDropItem.Location = new System.Drawing.Point(8, 135);
            this.cmbDropItem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDropItem.Name = "cmbDropItem";
            this.cmbDropItem.Size = new System.Drawing.Size(259, 23);
            this.cmbDropItem.TabIndex = 17;
            this.cmbDropItem.Text = null;
            this.cmbDropItem.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDropItem.SelectedIndexChanged += new System.EventHandler(this.cmbDropItem_SelectedIndexChanged);
            // 
            // lblDropAmount
            // 
            this.lblDropAmount.AutoSize = true;
            this.lblDropAmount.Location = new System.Drawing.Point(4, 167);
            this.lblDropAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDropAmount.Name = "lblDropAmount";
            this.lblDropAmount.Size = new System.Drawing.Size(60, 17);
            this.lblDropAmount.TabIndex = 15;
            this.lblDropAmount.Text = "Amount:";
            // 
            // lblDropChance
            // 
            this.lblDropChance.AutoSize = true;
            this.lblDropChance.Location = new System.Drawing.Point(4, 223);
            this.lblDropChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDropChance.Name = "lblDropChance";
            this.lblDropChance.Size = new System.Drawing.Size(86, 17);
            this.lblDropChance.TabIndex = 13;
            this.lblDropChance.Text = "Chance (%):";
            // 
            // lblDropItem
            // 
            this.lblDropItem.AutoSize = true;
            this.lblDropItem.Location = new System.Drawing.Point(4, 114);
            this.lblDropItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDropItem.Name = "lblDropItem";
            this.lblDropItem.Size = new System.Drawing.Size(38, 17);
            this.lblDropItem.TabIndex = 11;
            this.lblDropItem.Text = "Item:";
            // 
            // grpNpcVsNpc
            // 
            this.grpNpcVsNpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpNpcVsNpc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpNpcVsNpc.Controls.Add(this.cmbHostileNPC);
            this.grpNpcVsNpc.Controls.Add(this.lblNPC);
            this.grpNpcVsNpc.Controls.Add(this.btnRemoveAggro);
            this.grpNpcVsNpc.Controls.Add(this.btnAddAggro);
            this.grpNpcVsNpc.Controls.Add(this.lstAggro);
            this.grpNpcVsNpc.Controls.Add(this.chkAttackAllies);
            this.grpNpcVsNpc.Controls.Add(this.chkEnabled);
            this.grpNpcVsNpc.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpNpcVsNpc.Location = new System.Drawing.Point(0, 1039);
            this.grpNpcVsNpc.Margin = new System.Windows.Forms.Padding(4);
            this.grpNpcVsNpc.Name = "grpNpcVsNpc";
            this.grpNpcVsNpc.Padding = new System.Windows.Forms.Padding(4);
            this.grpNpcVsNpc.Size = new System.Drawing.Size(275, 336);
            this.grpNpcVsNpc.TabIndex = 29;
            this.grpNpcVsNpc.TabStop = false;
            this.grpNpcVsNpc.Text = "NPC vs NPC Combat/Hostility ";
            // 
            // cmbHostileNPC
            // 
            this.cmbHostileNPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbHostileNPC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbHostileNPC.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbHostileNPC.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbHostileNPC.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbHostileNPC.ButtonIcon")));
            this.cmbHostileNPC.DrawDropdownHoverOutline = false;
            this.cmbHostileNPC.DrawFocusRectangle = false;
            this.cmbHostileNPC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHostileNPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostileNPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHostileNPC.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbHostileNPC.FormattingEnabled = true;
            this.cmbHostileNPC.Location = new System.Drawing.Point(12, 103);
            this.cmbHostileNPC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHostileNPC.Name = "cmbHostileNPC";
            this.cmbHostileNPC.Size = new System.Drawing.Size(253, 23);
            this.cmbHostileNPC.TabIndex = 45;
            this.cmbHostileNPC.Text = null;
            this.cmbHostileNPC.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblNPC
            // 
            this.lblNPC.AutoSize = true;
            this.lblNPC.Location = new System.Drawing.Point(8, 82);
            this.lblNPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNPC.Name = "lblNPC";
            this.lblNPC.Size = new System.Drawing.Size(40, 17);
            this.lblNPC.TabIndex = 44;
            this.lblNPC.Text = "NPC:";
            // 
            // btnRemoveAggro
            // 
            this.btnRemoveAggro.Location = new System.Drawing.Point(167, 297);
            this.btnRemoveAggro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAggro.Name = "btnRemoveAggro";
            this.btnRemoveAggro.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemoveAggro.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveAggro.TabIndex = 43;
            this.btnRemoveAggro.Text = "Remove";
            this.btnRemoveAggro.Click += new System.EventHandler(this.btnRemoveAggro_Click);
            // 
            // btnAddAggro
            // 
            this.btnAddAggro.Location = new System.Drawing.Point(12, 297);
            this.btnAddAggro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAggro.Name = "btnAddAggro";
            this.btnAddAggro.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddAggro.Size = new System.Drawing.Size(100, 28);
            this.btnAddAggro.TabIndex = 42;
            this.btnAddAggro.Text = "Add";
            this.btnAddAggro.Click += new System.EventHandler(this.btnAddAggro_Click);
            // 
            // lstAggro
            // 
            this.lstAggro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstAggro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAggro.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstAggro.FormattingEnabled = true;
            this.lstAggro.ItemHeight = 16;
            this.lstAggro.Items.AddRange(new object[] {
            "NPC:"});
            this.lstAggro.Location = new System.Drawing.Point(12, 150);
            this.lstAggro.Margin = new System.Windows.Forms.Padding(4);
            this.lstAggro.Name = "lstAggro";
            this.lstAggro.Size = new System.Drawing.Size(254, 130);
            this.lstAggro.TabIndex = 41;
            // 
            // chkAttackAllies
            // 
            this.chkAttackAllies.AutoSize = true;
            this.chkAttackAllies.Location = new System.Drawing.Point(11, 52);
            this.chkAttackAllies.Margin = new System.Windows.Forms.Padding(4);
            this.chkAttackAllies.Name = "chkAttackAllies";
            this.chkAttackAllies.Size = new System.Drawing.Size(114, 21);
            this.chkAttackAllies.TabIndex = 1;
            this.chkAttackAllies.Text = "Attack Allies?";
            this.chkAttackAllies.CheckedChanged += new System.EventHandler(this.chkAttackAllies_CheckedChanged);
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(11, 23);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(90, 21);
            this.chkEnabled.TabIndex = 0;
            this.chkEnabled.Text = "Enabled?";
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // grpSpells
            // 
            this.grpSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpells.Controls.Add(this.cmbSpell);
            this.grpSpells.Controls.Add(this.cmbFreq);
            this.grpSpells.Controls.Add(this.lblFreq);
            this.grpSpells.Controls.Add(this.lblSpell);
            this.grpSpells.Controls.Add(this.btnRemove);
            this.grpSpells.Controls.Add(this.btnAdd);
            this.grpSpells.Controls.Add(this.lstSpells);
            this.grpSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpells.Location = new System.Drawing.Point(4, 739);
            this.grpSpells.Margin = new System.Windows.Forms.Padding(4);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Padding = new System.Windows.Forms.Padding(4);
            this.grpSpells.Size = new System.Drawing.Size(276, 294);
            this.grpSpells.TabIndex = 28;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
            // 
            // cmbSpell
            // 
            this.cmbSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSpell.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbSpell.ButtonIcon")));
            this.cmbSpell.DrawDropdownHoverOutline = false;
            this.cmbSpell.DrawFocusRectangle = false;
            this.cmbSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpell.FormattingEnabled = true;
            this.cmbSpell.Location = new System.Drawing.Point(17, 180);
            this.cmbSpell.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(237, 23);
            this.cmbSpell.TabIndex = 43;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // cmbFreq
            // 
            this.cmbFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFreq.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFreq.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFreq.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFreq.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbFreq.ButtonIcon")));
            this.cmbFreq.DrawDropdownHoverOutline = false;
            this.cmbFreq.DrawFocusRectangle = false;
            this.cmbFreq.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFreq.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFreq.FormattingEnabled = true;
            this.cmbFreq.Items.AddRange(new object[] {
            "Not Very Often",
            "Not Often",
            "Normal",
            "Often",
            "Very Often"});
            this.cmbFreq.Location = new System.Drawing.Point(63, 256);
            this.cmbFreq.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFreq.Name = "cmbFreq";
            this.cmbFreq.Size = new System.Drawing.Size(192, 23);
            this.cmbFreq.TabIndex = 42;
            this.cmbFreq.Text = "Not Very Often";
            this.cmbFreq.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFreq.SelectedIndexChanged += new System.EventHandler(this.cmbFreq_SelectedIndexChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(13, 260);
            this.lblFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(41, 17);
            this.lblFreq.TabIndex = 41;
            this.lblFreq.Text = "Freq:";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(13, 159);
            this.lblSpell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(43, 17);
            this.lblSpell.TabIndex = 39;
            this.lblSpell.Text = "Spell:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(156, 217);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 217);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstSpells
            // 
            this.lstSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSpells.FormattingEnabled = true;
            this.lstSpells.ItemHeight = 16;
            this.lstSpells.Location = new System.Drawing.Point(16, 18);
            this.lstSpells.Margin = new System.Windows.Forms.Padding(4);
            this.lstSpells.Name = "lstSpells";
            this.lstSpells.Size = new System.Drawing.Size(239, 130);
            this.lstSpells.TabIndex = 29;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(627, 785);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancel.Size = new System.Drawing.Size(253, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 784);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSave.Size = new System.Drawing.Size(253, 33);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnChronological,
            this.toolStripSeparator4,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(932, 31);
            this.toolStrip.TabIndex = 45;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(29, 28);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(29, 28);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnChronological
            // 
            this.btnChronological.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChronological.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnChronological.Image = ((System.Drawing.Image)(resources.GetObject("btnChronological.Image")));
            this.btnChronological.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChronological.Name = "btnChronological";
            this.btnChronological.Size = new System.Drawing.Size(29, 28);
            this.btnChronological.Text = "Order Chronologically";
            this.btnChronological.Click += new System.EventHandler(this.btnChronological_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(29, 28);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(29, 28);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(29, 28);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // searchableDarkTreeView1
            // 
            this.searchableDarkTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.searchableDarkTreeView1.ItemProvider = null;
            this.searchableDarkTreeView1.Location = new System.Drawing.Point(15, 33);
            this.searchableDarkTreeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchableDarkTreeView1.Name = "searchableDarkTreeView1";
            this.searchableDarkTreeView1.SearchText = "";
            this.searchableDarkTreeView1.SelectedId = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.searchableDarkTreeView1.Size = new System.Drawing.Size(320, 591);
            this.searchableDarkTreeView1.TabIndex = 46;
            this.searchableDarkTreeView1.Visible = false;
            // 
            // FrmNpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(932, 831);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpNpcs);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.searchableDarkTreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmNpc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNpc_FormClosed);
            this.Load += new System.EventHandler(this.frmNpc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpNpcs.ResumeLayout(false);
            this.grpNpcs.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSightRange)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpElements.ResumeLayout(false);
            this.grpElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarth)).EndInit();
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            this.grpAttackSpeed.ResumeLayout(false);
            this.grpAttackSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
            this.grpCommonEvents.ResumeLayout(false);
            this.grpCommonEvents.PerformLayout();
            this.grpBehavior.ResumeLayout(false);
            this.grpBehavior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrMoveRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlee)).EndInit();
            this.grpConditions.ResumeLayout(false);
            this.grpRegen.ResumeLayout(false);
            this.grpRegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpRegen)).EndInit();
            this.grpDrops.ResumeLayout(false);
            this.grpDrops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).EndInit();
            this.grpNpcVsNpc.ResumeLayout(false);
            this.grpNpcVsNpc.PerformLayout();
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkGroupBox grpNpcs;
        private DarkGroupBox grpGeneral;
        private DarkComboBox cmbSprite;
        private System.Windows.Forms.Label lblSpawnDuration;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.PictureBox picNpc;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkGroupBox grpStats;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblSightRange;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkGroupBox grpSpells;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.ListBox lstSpells;
        private System.Windows.Forms.Label lblSpell;
        private DarkComboBox cmbFreq;
        private System.Windows.Forms.Label lblFreq;
        private DarkGroupBox grpNpcVsNpc;
        private System.Windows.Forms.Label lblNPC;
        private DarkButton btnRemoveAggro;
        private DarkButton btnAddAggro;
        private System.Windows.Forms.ListBox lstAggro;
        private DarkCheckBox chkAttackAllies;
        private DarkCheckBox chkEnabled;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpCombat;
        private DarkComboBox cmbScalingStat;
        private System.Windows.Forms.Label lblScalingStat;
        private System.Windows.Forms.Label lblScaling;
        private DarkComboBox cmbDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Label lblCritChance;
        private DarkComboBox cmbAttackAnimation;
        private System.Windows.Forms.Label lblAttackAnimation;
        private System.Windows.Forms.Label lblDamage;
        private DarkComboBox cmbHostileNPC;
        private DarkComboBox cmbSpell;
        private DarkNumericUpDown nudSpd;
        private DarkNumericUpDown nudMR;
        private DarkNumericUpDown nudDef;
        private DarkNumericUpDown nudMag;
        private DarkNumericUpDown nudStr;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.Label lblStr;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudDamage;
        private DarkNumericUpDown nudCritChance;
        private DarkNumericUpDown nudSightRange;
        private DarkNumericUpDown nudSpawnDuration;
        private DarkNumericUpDown nudMana;
        private DarkNumericUpDown nudHp;
        private DarkNumericUpDown nudExp;
        private System.Windows.Forms.Label lblLevel;
        private DarkNumericUpDown nudLevel;
        private DarkGroupBox grpDrops;
        private DarkButton btnDropRemove;
        private DarkButton btnDropAdd;
        private System.Windows.Forms.ListBox lstDrops;
        private DarkNumericUpDown nudDropAmount;
        private DarkNumericUpDown nudDropChance;
        private DarkComboBox cmbDropItem;
        private System.Windows.Forms.Label lblDropAmount;
        private System.Windows.Forms.Label lblDropChance;
        private System.Windows.Forms.Label lblDropItem;
        private DarkGroupBox grpRegen;
        private DarkNumericUpDown nudMpRegen;
        private DarkNumericUpDown nudHpRegen;
        private System.Windows.Forms.Label lblHpRegen;
        private System.Windows.Forms.Label lblManaRegen;
        private System.Windows.Forms.Label lblRegenHint;
        private DarkGroupBox grpCommonEvents;
        private DarkGroupBox grpBehavior;
        private System.Windows.Forms.Label lblSwarm;
        private DarkCheckBox chkSwarm;
        private DarkGroupBox grpConditions;
        private DarkButton btnAttackOnSightCond;
        private DarkButton btnPlayerCanAttackCond;
        private DarkButton btnPlayerFriendProtectorCond;
        private System.Windows.Forms.Label lblMovement;
        private DarkComboBox cmbMovement;
        private System.Windows.Forms.Label lblAggressive;
        private DarkCheckBox chkAggressive;
        private DarkComboBox cmbOnDeathEventParty;
        private System.Windows.Forms.Label lblOnDeathEventParty;
        private DarkComboBox cmbOnDeathEventKiller;
        private System.Windows.Forms.Label lblOnDeathEventKiller;
        private DarkNumericUpDown nudFlee;
        private System.Windows.Forms.Label lblFlee;
        private System.Windows.Forms.Label lblFocusDamageDealer;
        private DarkCheckBox chkFocusDamageDealer;
        private DarkNumericUpDown nudCritMultiplier;
        private System.Windows.Forms.Label lblCritMultiplier;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        public System.Windows.Forms.TreeView lstNpcs;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripButton btnChronological;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Controls.SearchableDarkTreeView searchableDarkTreeView1;
        private DarkGroupBox grpAttackSpeed;
        private DarkNumericUpDown nudAttackSpeedValue;
        private System.Windows.Forms.Label lblAttackSpeedValue;
        private DarkComboBox cmbAttackSpeedModifier;
        private System.Windows.Forms.Label lblAttackSpeedModifier;
        private DarkNumericUpDown nudFaith;
        private System.Windows.Forms.Label lblFaith;
        private DarkGroupBox grpElements;
        private DarkNumericUpDown nudLight;
        private System.Windows.Forms.Label lblLight;
        private DarkNumericUpDown nudDark;
        private DarkNumericUpDown nudIce;
        private DarkNumericUpDown nudFire;
        private DarkNumericUpDown nudNature;
        private DarkNumericUpDown nudWater;
        private DarkNumericUpDown nudWind;
        private DarkNumericUpDown nudThunder;
        private DarkNumericUpDown nudEarth;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblThunder;
        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.Label lblIce;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label lblDark;
        private DarkNumericUpDown nbrMoveRange;
        private System.Windows.Forms.Label label1;
    }
}