using System.ComponentModel;
using System.Windows.Forms;
using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.grpItems = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstItems = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.cmbRarity = new DarkUI.Controls.DarkComboBox();
            this.lblRarity = new System.Windows.Forms.Label();
            this.nudCooldown = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCooldown = new System.Windows.Forms.Label();
            this.btnEditRequirements = new DarkUI.Controls.DarkButton();
            this.chkStackable = new DarkUI.Controls.DarkCheckBox();
            this.nudPrice = new DarkUI.Controls.DarkNumericUpDown();
            this.chkBound = new DarkUI.Controls.DarkCheckBox();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.cmbPic = new DarkUI.Controls.DarkComboBox();
            this.lblAnim = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new DarkUI.Controls.DarkComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.grpEquipment = new DarkUI.Controls.DarkGroupBox();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHPRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.lblRegenHint = new System.Windows.Forms.Label();
            this.grpVitalBonuses = new DarkUI.Controls.DarkGroupBox();
            this.nudCapacity = new DarkUI.Controls.DarkNumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.lblPercentage1 = new System.Windows.Forms.Label();
            this.nudMPPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHPPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.lblPlus1 = new System.Windows.Forms.Label();
            this.nudManaBonus = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHealthBonus = new DarkUI.Controls.DarkNumericUpDown();
            this.lblManaBonus = new System.Windows.Forms.Label();
            this.lblHealthBonus = new System.Windows.Forms.Label();
            this.cmbEquipmentAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblEquipmentAnimation = new System.Windows.Forms.Label();
            this.nudEffectPercent = new DarkUI.Controls.DarkNumericUpDown();
            this.grpStatBonuses = new DarkUI.Controls.DarkGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFaithPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFaith = new DarkUI.Controls.DarkNumericUpDown();
            this.lblFaith = new System.Windows.Forms.Label();
            this.lblPercentage5 = new System.Windows.Forms.Label();
            this.lblPercentage4 = new System.Windows.Forms.Label();
            this.lblPercentage8 = new System.Windows.Forms.Label();
            this.lblPercentage7 = new System.Windows.Forms.Label();
            this.lblPercentage6 = new System.Windows.Forms.Label();
            this.nudSpdPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMRPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDefPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStrPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlus5 = new System.Windows.Forms.Label();
            this.lblPlus4 = new System.Windows.Forms.Label();
            this.lblPlus8 = new System.Windows.Forms.Label();
            this.lblPlus7 = new System.Windows.Forms.Label();
            this.lblPlus6 = new System.Windows.Forms.Label();
            this.nudRange = new DarkUI.Controls.DarkNumericUpDown();
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
            this.lblRange = new System.Windows.Forms.Label();
            this.cmbFemalePaperdoll = new DarkUI.Controls.DarkComboBox();
            this.lblFemalePaperdoll = new System.Windows.Forms.Label();
            this.picFemalePaperdoll = new System.Windows.Forms.PictureBox();
            this.lblEffectPercent = new System.Windows.Forms.Label();
            this.cmbEquipmentBonus = new DarkUI.Controls.DarkComboBox();
            this.lblBonusEffect = new System.Windows.Forms.Label();
            this.cmbEquipmentSlot = new DarkUI.Controls.DarkComboBox();
            this.lblEquipmentSlot = new System.Windows.Forms.Label();
            this.cmbMalePaperdoll = new DarkUI.Controls.DarkComboBox();
            this.lblMalePaperdoll = new System.Windows.Forms.Label();
            this.picMalePaperdoll = new System.Windows.Forms.PictureBox();
            this.grpWeaponProperties = new DarkUI.Controls.DarkGroupBox();
            this.nudCritMultiplier = new DarkUI.Controls.DarkNumericUpDown();
            this.lblCritMultiplier = new System.Windows.Forms.Label();
            this.grpAttackSpeed = new DarkUI.Controls.DarkGroupBox();
            this.nudAttackSpeedValue = new DarkUI.Controls.DarkNumericUpDown();
            this.lblAttackSpeedValue = new System.Windows.Forms.Label();
            this.cmbAttackSpeedModifier = new DarkUI.Controls.DarkComboBox();
            this.lblAttackSpeedModifier = new System.Windows.Forms.Label();
            this.nudScaling = new DarkUI.Controls.DarkNumericUpDown();
            this.nudCritChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbProjectile = new DarkUI.Controls.DarkComboBox();
            this.cmbScalingStat = new DarkUI.Controls.DarkComboBox();
            this.lblScalingStat = new System.Windows.Forms.Label();
            this.lblScalingAmount = new System.Windows.Forms.Label();
            this.cmbDamageType = new DarkUI.Controls.DarkComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.cmbAttackAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblAttackAnimation = new System.Windows.Forms.Label();
            this.chk2Hand = new DarkUI.Controls.DarkCheckBox();
            this.lblToolType = new System.Windows.Forms.Label();
            this.cmbToolType = new DarkUI.Controls.DarkComboBox();
            this.lblProjectile = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.grpEvent = new DarkUI.Controls.DarkGroupBox();
            this.cmbEvent = new DarkUI.Controls.DarkComboBox();
            this.grpConsumable = new DarkUI.Controls.DarkGroupBox();
            this.lblPercentage3 = new System.Windows.Forms.Label();
            this.nudIntervalPercentage = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPlus3 = new System.Windows.Forms.Label();
            this.nudInterval = new DarkUI.Controls.DarkNumericUpDown();
            this.lblVital = new System.Windows.Forms.Label();
            this.cmbConsume = new DarkUI.Controls.DarkComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.grpSpell = new DarkUI.Controls.DarkGroupBox();
            this.chkDestroy = new DarkUI.Controls.DarkCheckBox();
            this.chkQuickCast = new DarkUI.Controls.DarkCheckBox();
            this.cmbTeachSpell = new DarkUI.Controls.DarkComboBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.lblDark = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.lblEarth = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.nudDark = new DarkUI.Controls.DarkNumericUpDown();
            this.nudLight = new DarkUI.Controls.DarkNumericUpDown();
            this.nudThunder = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWind = new DarkUI.Controls.DarkNumericUpDown();
            this.nudNature = new DarkUI.Controls.DarkNumericUpDown();
            this.nudWater = new DarkUI.Controls.DarkNumericUpDown();
            this.nudEarth = new DarkUI.Controls.DarkNumericUpDown();
            this.nudIce = new DarkUI.Controls.DarkNumericUpDown();
            this.nudFire = new DarkUI.Controls.DarkNumericUpDown();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblThunder = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblIce = new System.Windows.Forms.Label();
            this.lblFire = new System.Windows.Forms.Label();
            this.grpBags = new DarkUI.Controls.DarkGroupBox();
            this.nudBag = new DarkUI.Controls.DarkNumericUpDown();
            this.lblBag = new System.Windows.Forms.Label();
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
            this.nudDurability = new DarkUI.Controls.DarkNumericUpDown();
            this.lblDurability = new System.Windows.Forms.Label();
            this.nudWeaponSkillPoints = new DarkUI.Controls.DarkNumericUpDown();
            this.lblWeaponSkillPoints = new System.Windows.Forms.Label();
            this.grpItems.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.grpEquipment.SuspendLayout();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPRegen)).BeginInit();
            this.grpVitalBonuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManaBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffectPercent)).BeginInit();
            this.grpStatBonuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaithPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemalePaperdoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMalePaperdoll)).BeginInit();
            this.grpWeaponProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).BeginInit();
            this.grpAttackSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            this.grpEvent.SuspendLayout();
            this.grpConsumable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.grpSpell.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).BeginInit();
            this.grpBags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBag)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponSkillPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItems
            // 
            this.grpItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpItems.Controls.Add(this.btnClearSearch);
            this.grpItems.Controls.Add(this.txtSearch);
            this.grpItems.Controls.Add(this.lstItems);
            this.grpItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpItems.Location = new System.Drawing.Point(16, 42);
            this.grpItems.Margin = new System.Windows.Forms.Padding(4);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(4);
            this.grpItems.Size = new System.Drawing.Size(271, 586);
            this.grpItems.TabIndex = 1;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(239, 21);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnClearSearch.Size = new System.Drawing.Size(24, 25);
            this.btnClearSearch.TabIndex = 31;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(8, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 22);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstItems
            // 
            this.lstItems.AllowDrop = true;
            this.lstItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstItems.HideSelection = false;
            this.lstItems.ImageIndex = 0;
            this.lstItems.ImageList = this.imageList;
            this.lstItems.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstItems.Location = new System.Drawing.Point(8, 53);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectedImageIndex = 0;
            this.lstItems.Size = new System.Drawing.Size(255, 526);
            this.lstItems.TabIndex = 29;
            this.lstItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstItems_AfterSelect);
            this.lstItems.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstItems_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder_Open_16xLG.png");
            this.imageList.Images.SetKeyName(1, "LegacyPackage_16x.png");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(659, 593);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCancel.Size = new System.Drawing.Size(253, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 593);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSave.Size = new System.Drawing.Size(253, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.cmbRarity);
            this.grpGeneral.Controls.Add(this.lblRarity);
            this.grpGeneral.Controls.Add(this.nudCooldown);
            this.grpGeneral.Controls.Add(this.lblCooldown);
            this.grpGeneral.Controls.Add(this.btnEditRequirements);
            this.grpGeneral.Controls.Add(this.chkStackable);
            this.grpGeneral.Controls.Add(this.nudPrice);
            this.grpGeneral.Controls.Add(this.chkBound);
            this.grpGeneral.Controls.Add(this.cmbAnimation);
            this.grpGeneral.Controls.Add(this.lblDesc);
            this.grpGeneral.Controls.Add(this.txtDesc);
            this.grpGeneral.Controls.Add(this.cmbPic);
            this.grpGeneral.Controls.Add(this.lblAnim);
            this.grpGeneral.Controls.Add(this.lblPrice);
            this.grpGeneral.Controls.Add(this.lblPic);
            this.grpGeneral.Controls.Add(this.picItem);
            this.grpGeneral.Controls.Add(this.lblType);
            this.grpGeneral.Controls.Add(this.cmbType);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(3, 1);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.grpGeneral.Size = new System.Drawing.Size(585, 262);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(240, 46);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddFolder.Size = new System.Drawing.Size(24, 26);
            this.btnAddFolder.TabIndex = 49;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(11, 51);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(52, 17);
            this.lblFolder.TabIndex = 48;
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
            this.cmbFolder.Location = new System.Drawing.Point(71, 46);
            this.cmbFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(163, 23);
            this.cmbFolder.TabIndex = 47;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // cmbRarity
            // 
            this.cmbRarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbRarity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbRarity.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbRarity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbRarity.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbRarity.ButtonIcon")));
            this.cmbRarity.DrawDropdownHoverOutline = false;
            this.cmbRarity.DrawFocusRectangle = false;
            this.cmbRarity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRarity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRarity.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbRarity.FormattingEnabled = true;
            this.cmbRarity.Items.AddRange(new object[] {
            "None",
            "Common",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary"});
            this.cmbRarity.Location = new System.Drawing.Point(349, 202);
            this.cmbRarity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRarity.Name = "cmbRarity";
            this.cmbRarity.Size = new System.Drawing.Size(227, 23);
            this.cmbRarity.TabIndex = 41;
            this.cmbRarity.Text = "None";
            this.cmbRarity.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbRarity.SelectedIndexChanged += new System.EventHandler(this.cmbRarity_SelectedIndexChanged);
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(345, 182);
            this.lblRarity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(49, 17);
            this.lblRarity.TabIndex = 40;
            this.lblRarity.Text = "Rarity:";
            // 
            // nudCooldown
            // 
            this.nudCooldown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCooldown.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCooldown.Location = new System.Drawing.Point(349, 160);
            this.nudCooldown.Margin = new System.Windows.Forms.Padding(4);
            this.nudCooldown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCooldown.Name = "nudCooldown";
            this.nudCooldown.Size = new System.Drawing.Size(228, 22);
            this.nudCooldown.TabIndex = 39;
            this.nudCooldown.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCooldown.ValueChanged += new System.EventHandler(this.nudCooldown_ValueChanged);
            // 
            // lblCooldown
            // 
            this.lblCooldown.AutoSize = true;
            this.lblCooldown.Location = new System.Drawing.Point(345, 140);
            this.lblCooldown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCooldown.Name = "lblCooldown";
            this.lblCooldown.Size = new System.Drawing.Size(105, 17);
            this.lblCooldown.TabIndex = 38;
            this.lblCooldown.Text = "Cooldown (ms):";
            // 
            // btnEditRequirements
            // 
            this.btnEditRequirements.Location = new System.Drawing.Point(349, 228);
            this.btnEditRequirements.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRequirements.Name = "btnEditRequirements";
            this.btnEditRequirements.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEditRequirements.Size = new System.Drawing.Size(228, 28);
            this.btnEditRequirements.TabIndex = 0;
            this.btnEditRequirements.Text = "Edit Usage Requirements";
            this.btnEditRequirements.Click += new System.EventHandler(this.btnEditRequirements_Click);
            // 
            // chkStackable
            // 
            this.chkStackable.AutoSize = true;
            this.chkStackable.Location = new System.Drawing.Point(104, 237);
            this.chkStackable.Margin = new System.Windows.Forms.Padding(4);
            this.chkStackable.Name = "chkStackable";
            this.chkStackable.Size = new System.Drawing.Size(100, 21);
            this.chkStackable.TabIndex = 27;
            this.chkStackable.Text = "Stackable?";
            this.chkStackable.CheckedChanged += new System.EventHandler(this.chkStackable_CheckedChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudPrice.Location = new System.Drawing.Point(349, 75);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(228, 22);
            this.nudPrice.TabIndex = 37;
            this.nudPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPrice.ValueChanged += new System.EventHandler(this.nudPrice_ValueChanged);
            // 
            // chkBound
            // 
            this.chkBound.AutoSize = true;
            this.chkBound.Location = new System.Drawing.Point(17, 238);
            this.chkBound.Margin = new System.Windows.Forms.Padding(4);
            this.chkBound.Name = "chkBound";
            this.chkBound.Size = new System.Drawing.Size(79, 21);
            this.chkBound.TabIndex = 26;
            this.chkBound.Text = "Bound?";
            this.chkBound.CheckedChanged += new System.EventHandler(this.chkBound_CheckedChanged);
            // 
            // cmbAnimation
            // 
            this.cmbAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAnimation.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbAnimation.ButtonIcon")));
            this.cmbAnimation.DrawDropdownHoverOutline = false;
            this.cmbAnimation.DrawFocusRectangle = false;
            this.cmbAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimation.FormattingEnabled = true;
            this.cmbAnimation.Location = new System.Drawing.Point(349, 117);
            this.cmbAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(227, 23);
            this.cmbAnimation.TabIndex = 14;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAnimation_SelectedIndexChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 100);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(44, 17);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "Desc:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(16, 120);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(247, 114);
            this.txtDesc.TabIndex = 12;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // cmbPic
            // 
            this.cmbPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbPic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbPic.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbPic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbPic.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbPic.ButtonIcon")));
            this.cmbPic.DrawDropdownHoverOutline = false;
            this.cmbPic.DrawFocusRectangle = false;
            this.cmbPic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPic.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbPic.FormattingEnabled = true;
            this.cmbPic.Items.AddRange(new object[] {
            "None"});
            this.cmbPic.Location = new System.Drawing.Point(349, 31);
            this.cmbPic.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPic.Name = "cmbPic";
            this.cmbPic.Size = new System.Drawing.Size(227, 23);
            this.cmbPic.TabIndex = 11;
            this.cmbPic.Text = "None";
            this.cmbPic.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbPic.SelectedIndexChanged += new System.EventHandler(this.cmbPic_SelectedIndexChanged);
            // 
            // lblAnim
            // 
            this.lblAnim.AutoSize = true;
            this.lblAnim.Location = new System.Drawing.Point(345, 98);
            this.lblAnim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnim.Name = "lblAnim";
            this.lblAnim.Size = new System.Drawing.Size(70, 17);
            this.lblAnim.TabIndex = 9;
            this.lblAnim.Text = "Animation";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(345, 54);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(345, 10);
            this.lblPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(31, 17);
            this.lblPic.TabIndex = 6;
            this.lblPic.Text = "Pic:";
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(294, 16);
            this.picItem.Margin = new System.Windows.Forms.Padding(4);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(43, 41);
            this.picItem.TabIndex = 4;
            this.picItem.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 80);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbType.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbType.ButtonIcon")));
            this.cmbType.DrawDropdownHoverOutline = false;
            this.cmbType.DrawFocusRectangle = false;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "None",
            "Equipment",
            "Consumable",
            "Currency",
            "Spell",
            "Event",
            "Bag"});
            this.cmbType.Location = new System.Drawing.Point(71, 76);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(197, 23);
            this.cmbType.TabIndex = 2;
            this.cmbType.Text = "None";
            this.cmbType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 18);
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
            this.txtName.Location = new System.Drawing.Point(71, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpEquipment
            // 
            this.grpEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEquipment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEquipment.Controls.Add(this.nudWeaponSkillPoints);
            this.grpEquipment.Controls.Add(this.lblWeaponSkillPoints);
            this.grpEquipment.Controls.Add(this.nudDurability);
            this.grpEquipment.Controls.Add(this.lblDurability);
            this.grpEquipment.Controls.Add(this.grpRegen);
            this.grpEquipment.Controls.Add(this.grpVitalBonuses);
            this.grpEquipment.Controls.Add(this.cmbEquipmentAnimation);
            this.grpEquipment.Controls.Add(this.lblEquipmentAnimation);
            this.grpEquipment.Controls.Add(this.nudEffectPercent);
            this.grpEquipment.Controls.Add(this.grpStatBonuses);
            this.grpEquipment.Controls.Add(this.cmbFemalePaperdoll);
            this.grpEquipment.Controls.Add(this.lblFemalePaperdoll);
            this.grpEquipment.Controls.Add(this.picFemalePaperdoll);
            this.grpEquipment.Controls.Add(this.lblEffectPercent);
            this.grpEquipment.Controls.Add(this.cmbEquipmentBonus);
            this.grpEquipment.Controls.Add(this.lblBonusEffect);
            this.grpEquipment.Controls.Add(this.cmbEquipmentSlot);
            this.grpEquipment.Controls.Add(this.lblEquipmentSlot);
            this.grpEquipment.Controls.Add(this.cmbMalePaperdoll);
            this.grpEquipment.Controls.Add(this.lblMalePaperdoll);
            this.grpEquipment.Controls.Add(this.picMalePaperdoll);
            this.grpEquipment.Controls.Add(this.grpWeaponProperties);
            this.grpEquipment.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEquipment.Location = new System.Drawing.Point(3, 332);
            this.grpEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Padding = new System.Windows.Forms.Padding(4);
            this.grpEquipment.Size = new System.Drawing.Size(585, 900);
            this.grpEquipment.TabIndex = 12;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Equipment";
            this.grpEquipment.Visible = false;
            // 
            // grpRegen
            // 
            this.grpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRegen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRegen.Controls.Add(this.nudMpRegen);
            this.grpRegen.Controls.Add(this.nudHPRegen);
            this.grpRegen.Controls.Add(this.lblHpRegen);
            this.grpRegen.Controls.Add(this.lblManaRegen);
            this.grpRegen.Controls.Add(this.lblRegenHint);
            this.grpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRegen.Location = new System.Drawing.Point(17, 478);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegen.Size = new System.Drawing.Size(269, 111);
            this.grpRegen.TabIndex = 59;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen";
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(141, 38);
            this.nudMpRegen.Margin = new System.Windows.Forms.Padding(4);
            this.nudMpRegen.Name = "nudMpRegen";
            this.nudMpRegen.Size = new System.Drawing.Size(116, 22);
            this.nudMpRegen.TabIndex = 31;
            this.nudMpRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMpRegen.ValueChanged += new System.EventHandler(this.nudMpRegen_ValueChanged);
            // 
            // nudHPRegen
            // 
            this.nudHPRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPRegen.Location = new System.Drawing.Point(11, 38);
            this.nudHPRegen.Margin = new System.Windows.Forms.Padding(4);
            this.nudHPRegen.Name = "nudHPRegen";
            this.nudHPRegen.Size = new System.Drawing.Size(116, 22);
            this.nudHPRegen.TabIndex = 30;
            this.nudHPRegen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHPRegen.ValueChanged += new System.EventHandler(this.nudHPRegen_ValueChanged);
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
            this.lblManaRegen.Location = new System.Drawing.Point(137, 21);
            this.lblManaRegen.Name = "lblManaRegen";
            this.lblManaRegen.Size = new System.Drawing.Size(73, 17);
            this.lblManaRegen.TabIndex = 27;
            this.lblManaRegen.Text = "Mana: (%)";
            // 
            // lblRegenHint
            // 
            this.lblRegenHint.Location = new System.Drawing.Point(9, 66);
            this.lblRegenHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegenHint.Name = "lblRegenHint";
            this.lblRegenHint.Size = new System.Drawing.Size(255, 38);
            this.lblRegenHint.TabIndex = 0;
            this.lblRegenHint.Text = "% of HP/Mana to restore per tick.\r\nTick timer saved in server config.json.";
            // 
            // grpVitalBonuses
            // 
            this.grpVitalBonuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpVitalBonuses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpVitalBonuses.Controls.Add(this.nudCapacity);
            this.grpVitalBonuses.Controls.Add(this.lblWeight);
            this.grpVitalBonuses.Controls.Add(this.lblPercentage2);
            this.grpVitalBonuses.Controls.Add(this.lblPercentage1);
            this.grpVitalBonuses.Controls.Add(this.nudMPPercentage);
            this.grpVitalBonuses.Controls.Add(this.nudHPPercentage);
            this.grpVitalBonuses.Controls.Add(this.lblPlus2);
            this.grpVitalBonuses.Controls.Add(this.lblPlus1);
            this.grpVitalBonuses.Controls.Add(this.nudManaBonus);
            this.grpVitalBonuses.Controls.Add(this.nudHealthBonus);
            this.grpVitalBonuses.Controls.Add(this.lblManaBonus);
            this.grpVitalBonuses.Controls.Add(this.lblHealthBonus);
            this.grpVitalBonuses.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpVitalBonuses.Location = new System.Drawing.Point(20, 52);
            this.grpVitalBonuses.Margin = new System.Windows.Forms.Padding(4);
            this.grpVitalBonuses.Name = "grpVitalBonuses";
            this.grpVitalBonuses.Padding = new System.Windows.Forms.Padding(4);
            this.grpVitalBonuses.Size = new System.Drawing.Size(267, 126);
            this.grpVitalBonuses.TabIndex = 58;
            this.grpVitalBonuses.TabStop = false;
            this.grpVitalBonuses.Text = "Vital Bonuses";
            // 
            // nudCapacity
            // 
            this.nudCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCapacity.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCapacity.Location = new System.Drawing.Point(73, 98);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.nudCapacity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudCapacity.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(72, 22);
            this.nudCapacity.TabIndex = 72;
            this.nudCapacity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCapacity.ValueChanged += new System.EventHandler(this.nudCapacity_ValueChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(15, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(56, 17);
            this.lblWeight.TabIndex = 71;
            this.lblWeight.Text = "Weight:";
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Location = new System.Drawing.Point(239, 69);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage2.TabIndex = 70;
            this.lblPercentage2.Text = "%";
            // 
            // lblPercentage1
            // 
            this.lblPercentage1.AutoSize = true;
            this.lblPercentage1.Location = new System.Drawing.Point(239, 36);
            this.lblPercentage1.Name = "lblPercentage1";
            this.lblPercentage1.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage1.TabIndex = 69;
            this.lblPercentage1.Text = "%";
            // 
            // nudMPPercentage
            // 
            this.nudMPPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMPPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMPPercentage.Location = new System.Drawing.Point(176, 68);
            this.nudMPPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudMPPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMPPercentage.Name = "nudMPPercentage";
            this.nudMPPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudMPPercentage.TabIndex = 68;
            this.nudMPPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMPPercentage.ValueChanged += new System.EventHandler(this.nudMPPercentage_ValueChanged);
            // 
            // nudHPPercentage
            // 
            this.nudHPPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPPercentage.Location = new System.Drawing.Point(176, 34);
            this.nudHPPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudHPPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHPPercentage.Name = "nudHPPercentage";
            this.nudHPPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudHPPercentage.TabIndex = 67;
            this.nudHPPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHPPercentage.ValueChanged += new System.EventHandler(this.nudHPPercentage_ValueChanged);
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Location = new System.Drawing.Point(152, 69);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(16, 17);
            this.lblPlus2.TabIndex = 66;
            this.lblPlus2.Text = "+";
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Location = new System.Drawing.Point(152, 36);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(16, 17);
            this.lblPlus1.TabIndex = 65;
            this.lblPlus1.Text = "+";
            // 
            // nudManaBonus
            // 
            this.nudManaBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudManaBonus.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudManaBonus.Location = new System.Drawing.Point(16, 71);
            this.nudManaBonus.Margin = new System.Windows.Forms.Padding(4);
            this.nudManaBonus.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudManaBonus.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudManaBonus.Name = "nudManaBonus";
            this.nudManaBonus.Size = new System.Drawing.Size(127, 22);
            this.nudManaBonus.TabIndex = 49;
            this.nudManaBonus.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudManaBonus.ValueChanged += new System.EventHandler(this.nudManaBonus_ValueChanged);
            // 
            // nudHealthBonus
            // 
            this.nudHealthBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHealthBonus.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHealthBonus.Location = new System.Drawing.Point(16, 34);
            this.nudHealthBonus.Margin = new System.Windows.Forms.Padding(4);
            this.nudHealthBonus.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudHealthBonus.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudHealthBonus.Name = "nudHealthBonus";
            this.nudHealthBonus.Size = new System.Drawing.Size(127, 22);
            this.nudHealthBonus.TabIndex = 48;
            this.nudHealthBonus.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudHealthBonus.ValueChanged += new System.EventHandler(this.nudHealthBonus_ValueChanged);
            // 
            // lblManaBonus
            // 
            this.lblManaBonus.AutoSize = true;
            this.lblManaBonus.Location = new System.Drawing.Point(12, 55);
            this.lblManaBonus.Name = "lblManaBonus";
            this.lblManaBonus.Size = new System.Drawing.Size(47, 17);
            this.lblManaBonus.TabIndex = 44;
            this.lblManaBonus.Text = "Mana:";
            // 
            // lblHealthBonus
            // 
            this.lblHealthBonus.AutoSize = true;
            this.lblHealthBonus.Location = new System.Drawing.Point(11, 14);
            this.lblHealthBonus.Name = "lblHealthBonus";
            this.lblHealthBonus.Size = new System.Drawing.Size(53, 17);
            this.lblHealthBonus.TabIndex = 43;
            this.lblHealthBonus.Text = "Health:";
            // 
            // cmbEquipmentAnimation
            // 
            this.cmbEquipmentAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEquipmentAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEquipmentAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEquipmentAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEquipmentAnimation.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEquipmentAnimation.ButtonIcon")));
            this.cmbEquipmentAnimation.DrawDropdownHoverOutline = false;
            this.cmbEquipmentAnimation.DrawFocusRectangle = false;
            this.cmbEquipmentAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquipmentAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEquipmentAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEquipmentAnimation.FormattingEnabled = true;
            this.cmbEquipmentAnimation.Items.AddRange(new object[] {
            "None"});
            this.cmbEquipmentAnimation.Location = new System.Drawing.Point(295, 626);
            this.cmbEquipmentAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEquipmentAnimation.Name = "cmbEquipmentAnimation";
            this.cmbEquipmentAnimation.Size = new System.Drawing.Size(275, 23);
            this.cmbEquipmentAnimation.TabIndex = 57;
            this.cmbEquipmentAnimation.Text = "None";
            this.cmbEquipmentAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEquipmentAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentAnimation_SelectedIndexChanged);
            // 
            // lblEquipmentAnimation
            // 
            this.lblEquipmentAnimation.AutoSize = true;
            this.lblEquipmentAnimation.Location = new System.Drawing.Point(291, 607);
            this.lblEquipmentAnimation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentAnimation.Name = "lblEquipmentAnimation";
            this.lblEquipmentAnimation.Size = new System.Drawing.Size(145, 17);
            this.lblEquipmentAnimation.TabIndex = 56;
            this.lblEquipmentAnimation.Text = "Equipment Animation:";
            // 
            // nudEffectPercent
            // 
            this.nudEffectPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudEffectPercent.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudEffectPercent.Location = new System.Drawing.Point(137, 628);
            this.nudEffectPercent.Margin = new System.Windows.Forms.Padding(4);
            this.nudEffectPercent.Name = "nudEffectPercent";
            this.nudEffectPercent.Size = new System.Drawing.Size(152, 22);
            this.nudEffectPercent.TabIndex = 55;
            this.nudEffectPercent.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudEffectPercent.ValueChanged += new System.EventHandler(this.nudEffectPercent_ValueChanged);
            // 
            // grpStatBonuses
            // 
            this.grpStatBonuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpStatBonuses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpStatBonuses.Controls.Add(this.label1);
            this.grpStatBonuses.Controls.Add(this.nudFaithPercentage);
            this.grpStatBonuses.Controls.Add(this.label2);
            this.grpStatBonuses.Controls.Add(this.nudFaith);
            this.grpStatBonuses.Controls.Add(this.lblFaith);
            this.grpStatBonuses.Controls.Add(this.lblPercentage5);
            this.grpStatBonuses.Controls.Add(this.lblPercentage4);
            this.grpStatBonuses.Controls.Add(this.lblPercentage8);
            this.grpStatBonuses.Controls.Add(this.lblPercentage7);
            this.grpStatBonuses.Controls.Add(this.lblPercentage6);
            this.grpStatBonuses.Controls.Add(this.nudSpdPercentage);
            this.grpStatBonuses.Controls.Add(this.nudMRPercentage);
            this.grpStatBonuses.Controls.Add(this.nudDefPercentage);
            this.grpStatBonuses.Controls.Add(this.nudMagPercentage);
            this.grpStatBonuses.Controls.Add(this.nudStrPercentage);
            this.grpStatBonuses.Controls.Add(this.lblPlus5);
            this.grpStatBonuses.Controls.Add(this.lblPlus4);
            this.grpStatBonuses.Controls.Add(this.lblPlus8);
            this.grpStatBonuses.Controls.Add(this.lblPlus7);
            this.grpStatBonuses.Controls.Add(this.lblPlus6);
            this.grpStatBonuses.Controls.Add(this.nudRange);
            this.grpStatBonuses.Controls.Add(this.nudSpd);
            this.grpStatBonuses.Controls.Add(this.nudMR);
            this.grpStatBonuses.Controls.Add(this.nudDef);
            this.grpStatBonuses.Controls.Add(this.nudMag);
            this.grpStatBonuses.Controls.Add(this.nudStr);
            this.grpStatBonuses.Controls.Add(this.lblSpd);
            this.grpStatBonuses.Controls.Add(this.lblMR);
            this.grpStatBonuses.Controls.Add(this.lblDef);
            this.grpStatBonuses.Controls.Add(this.lblMag);
            this.grpStatBonuses.Controls.Add(this.lblStr);
            this.grpStatBonuses.Controls.Add(this.lblRange);
            this.grpStatBonuses.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpStatBonuses.Location = new System.Drawing.Point(17, 185);
            this.grpStatBonuses.Margin = new System.Windows.Forms.Padding(4);
            this.grpStatBonuses.Name = "grpStatBonuses";
            this.grpStatBonuses.Padding = new System.Windows.Forms.Padding(4);
            this.grpStatBonuses.Size = new System.Drawing.Size(269, 288);
            this.grpStatBonuses.TabIndex = 40;
            this.grpStatBonuses.TabStop = false;
            this.grpStatBonuses.Text = "Stat Bonuses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "%";
            // 
            // nudFaithPercentage
            // 
            this.nudFaithPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFaithPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFaithPercentage.Location = new System.Drawing.Point(173, 233);
            this.nudFaithPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudFaithPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFaithPercentage.Name = "nudFaithPercentage";
            this.nudFaithPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudFaithPercentage.TabIndex = 86;
            this.nudFaithPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFaithPercentage.ValueChanged += new System.EventHandler(this.nudFaithPercentage_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "+";
            // 
            // nudFaith
            // 
            this.nudFaith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudFaith.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudFaith.Location = new System.Drawing.Point(16, 233);
            this.nudFaith.Margin = new System.Windows.Forms.Padding(4);
            this.nudFaith.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFaith.Name = "nudFaith";
            this.nudFaith.Size = new System.Drawing.Size(129, 22);
            this.nudFaith.TabIndex = 84;
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
            this.lblFaith.Location = new System.Drawing.Point(12, 213);
            this.lblFaith.Name = "lblFaith";
            this.lblFaith.Size = new System.Drawing.Size(43, 17);
            this.lblFaith.TabIndex = 83;
            this.lblFaith.Text = "Faith:";
            // 
            // lblPercentage5
            // 
            this.lblPercentage5.AutoSize = true;
            this.lblPercentage5.Location = new System.Drawing.Point(239, 194);
            this.lblPercentage5.Name = "lblPercentage5";
            this.lblPercentage5.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage5.TabIndex = 82;
            this.lblPercentage5.Text = "%";
            // 
            // lblPercentage4
            // 
            this.lblPercentage4.AutoSize = true;
            this.lblPercentage4.Location = new System.Drawing.Point(239, 152);
            this.lblPercentage4.Name = "lblPercentage4";
            this.lblPercentage4.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage4.TabIndex = 81;
            this.lblPercentage4.Text = "%";
            // 
            // lblPercentage8
            // 
            this.lblPercentage8.AutoSize = true;
            this.lblPercentage8.Location = new System.Drawing.Point(241, 112);
            this.lblPercentage8.Name = "lblPercentage8";
            this.lblPercentage8.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage8.TabIndex = 80;
            this.lblPercentage8.Text = "%";
            // 
            // lblPercentage7
            // 
            this.lblPercentage7.AutoSize = true;
            this.lblPercentage7.Location = new System.Drawing.Point(239, 71);
            this.lblPercentage7.Name = "lblPercentage7";
            this.lblPercentage7.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage7.TabIndex = 79;
            this.lblPercentage7.Text = "%";
            // 
            // lblPercentage6
            // 
            this.lblPercentage6.AutoSize = true;
            this.lblPercentage6.Location = new System.Drawing.Point(239, 35);
            this.lblPercentage6.Name = "lblPercentage6";
            this.lblPercentage6.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage6.TabIndex = 78;
            this.lblPercentage6.Text = "%";
            // 
            // nudSpdPercentage
            // 
            this.nudSpdPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpdPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpdPercentage.Location = new System.Drawing.Point(176, 191);
            this.nudSpdPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudSpdPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpdPercentage.Name = "nudSpdPercentage";
            this.nudSpdPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudSpdPercentage.TabIndex = 77;
            this.nudSpdPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpdPercentage.ValueChanged += new System.EventHandler(this.nudSpdPercentage_ValueChanged);
            // 
            // nudMRPercentage
            // 
            this.nudMRPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMRPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMRPercentage.Location = new System.Drawing.Point(176, 149);
            this.nudMRPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudMRPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMRPercentage.Name = "nudMRPercentage";
            this.nudMRPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudMRPercentage.TabIndex = 76;
            this.nudMRPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMRPercentage.ValueChanged += new System.EventHandler(this.nudMRPercentage_ValueChanged);
            // 
            // nudDefPercentage
            // 
            this.nudDefPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDefPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDefPercentage.Location = new System.Drawing.Point(179, 110);
            this.nudDefPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudDefPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDefPercentage.Name = "nudDefPercentage";
            this.nudDefPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudDefPercentage.TabIndex = 75;
            this.nudDefPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDefPercentage.ValueChanged += new System.EventHandler(this.nudDefPercentage_ValueChanged);
            // 
            // nudMagPercentage
            // 
            this.nudMagPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagPercentage.Location = new System.Drawing.Point(176, 70);
            this.nudMagPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudMagPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMagPercentage.Name = "nudMagPercentage";
            this.nudMagPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudMagPercentage.TabIndex = 74;
            this.nudMagPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMagPercentage.ValueChanged += new System.EventHandler(this.nudMagPercentage_ValueChanged);
            // 
            // nudStrPercentage
            // 
            this.nudStrPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStrPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrPercentage.Location = new System.Drawing.Point(176, 32);
            this.nudStrPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudStrPercentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStrPercentage.Name = "nudStrPercentage";
            this.nudStrPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudStrPercentage.TabIndex = 73;
            this.nudStrPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStrPercentage.ValueChanged += new System.EventHandler(this.nudStrPercentage_ValueChanged);
            // 
            // lblPlus5
            // 
            this.lblPlus5.AutoSize = true;
            this.lblPlus5.Location = new System.Drawing.Point(152, 194);
            this.lblPlus5.Name = "lblPlus5";
            this.lblPlus5.Size = new System.Drawing.Size(16, 17);
            this.lblPlus5.TabIndex = 72;
            this.lblPlus5.Text = "+";
            // 
            // lblPlus4
            // 
            this.lblPlus4.AutoSize = true;
            this.lblPlus4.Location = new System.Drawing.Point(152, 152);
            this.lblPlus4.Name = "lblPlus4";
            this.lblPlus4.Size = new System.Drawing.Size(16, 17);
            this.lblPlus4.TabIndex = 71;
            this.lblPlus4.Text = "+";
            // 
            // lblPlus8
            // 
            this.lblPlus8.AutoSize = true;
            this.lblPlus8.Location = new System.Drawing.Point(155, 112);
            this.lblPlus8.Name = "lblPlus8";
            this.lblPlus8.Size = new System.Drawing.Size(16, 17);
            this.lblPlus8.TabIndex = 70;
            this.lblPlus8.Text = "+";
            // 
            // lblPlus7
            // 
            this.lblPlus7.AutoSize = true;
            this.lblPlus7.Location = new System.Drawing.Point(152, 71);
            this.lblPlus7.Name = "lblPlus7";
            this.lblPlus7.Size = new System.Drawing.Size(16, 17);
            this.lblPlus7.TabIndex = 69;
            this.lblPlus7.Text = "+";
            // 
            // lblPlus6
            // 
            this.lblPlus6.AutoSize = true;
            this.lblPlus6.Location = new System.Drawing.Point(152, 35);
            this.lblPlus6.Name = "lblPlus6";
            this.lblPlus6.Size = new System.Drawing.Size(16, 17);
            this.lblPlus6.TabIndex = 68;
            this.lblPlus6.Text = "+";
            // 
            // nudRange
            // 
            this.nudRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRange.Location = new System.Drawing.Point(176, 261);
            this.nudRange.Margin = new System.Windows.Forms.Padding(4);
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(83, 22);
            this.nudRange.TabIndex = 53;
            this.nudRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRange.ValueChanged += new System.EventHandler(this.nudRange_ValueChanged);
            // 
            // nudSpd
            // 
            this.nudSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpd.Location = new System.Drawing.Point(19, 191);
            this.nudSpd.Margin = new System.Windows.Forms.Padding(4);
            this.nudSpd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(129, 22);
            this.nudSpd.TabIndex = 52;
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
            this.nudMR.Location = new System.Drawing.Point(17, 149);
            this.nudMR.Margin = new System.Windows.Forms.Padding(4);
            this.nudMR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMR.Name = "nudMR";
            this.nudMR.Size = new System.Drawing.Size(131, 22);
            this.nudMR.TabIndex = 51;
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
            this.nudDef.Location = new System.Drawing.Point(17, 110);
            this.nudDef.Margin = new System.Windows.Forms.Padding(4);
            this.nudDef.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDef.Name = "nudDef";
            this.nudDef.Size = new System.Drawing.Size(131, 22);
            this.nudDef.TabIndex = 50;
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
            this.nudMag.Location = new System.Drawing.Point(17, 70);
            this.nudMag.Margin = new System.Windows.Forms.Padding(4);
            this.nudMag.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMag.Name = "nudMag";
            this.nudMag.Size = new System.Drawing.Size(131, 22);
            this.nudMag.TabIndex = 49;
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
            this.nudStr.Location = new System.Drawing.Point(17, 32);
            this.nudStr.Margin = new System.Windows.Forms.Padding(4);
            this.nudStr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(131, 22);
            this.nudStr.TabIndex = 48;
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
            this.lblSpd.Location = new System.Drawing.Point(15, 171);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(53, 17);
            this.lblSpd.TabIndex = 47;
            this.lblSpd.Text = "Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(13, 130);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(92, 17);
            this.lblMR.TabIndex = 46;
            this.lblMR.Text = "Magic Resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(13, 91);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(50, 17);
            this.lblDef.TabIndex = 45;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(13, 54);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(49, 17);
            this.lblMag.TabIndex = 44;
            this.lblMag.Text = "Magic:";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(15, 13);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(66, 17);
            this.lblStr.TabIndex = 43;
            this.lblStr.Text = "Strength:";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(15, 263);
            this.lblRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(154, 17);
            this.lblRange.TabIndex = 20;
            this.lblRange.Text = "Stat Bonus Range (+-):";
            // 
            // cmbFemalePaperdoll
            // 
            this.cmbFemalePaperdoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFemalePaperdoll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFemalePaperdoll.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFemalePaperdoll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFemalePaperdoll.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbFemalePaperdoll.ButtonIcon")));
            this.cmbFemalePaperdoll.DrawDropdownHoverOutline = false;
            this.cmbFemalePaperdoll.DrawFocusRectangle = false;
            this.cmbFemalePaperdoll.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFemalePaperdoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFemalePaperdoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFemalePaperdoll.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFemalePaperdoll.FormattingEnabled = true;
            this.cmbFemalePaperdoll.Items.AddRange(new object[] {
            "None"});
            this.cmbFemalePaperdoll.Location = new System.Drawing.Point(295, 726);
            this.cmbFemalePaperdoll.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFemalePaperdoll.Name = "cmbFemalePaperdoll";
            this.cmbFemalePaperdoll.Size = new System.Drawing.Size(223, 23);
            this.cmbFemalePaperdoll.TabIndex = 36;
            this.cmbFemalePaperdoll.Text = "None";
            this.cmbFemalePaperdoll.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFemalePaperdoll.SelectedIndexChanged += new System.EventHandler(this.cmbFemalePaperdoll_SelectedIndexChanged);
            // 
            // lblFemalePaperdoll
            // 
            this.lblFemalePaperdoll.AutoSize = true;
            this.lblFemalePaperdoll.Location = new System.Drawing.Point(291, 705);
            this.lblFemalePaperdoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFemalePaperdoll.Name = "lblFemalePaperdoll";
            this.lblFemalePaperdoll.Size = new System.Drawing.Size(122, 17);
            this.lblFemalePaperdoll.TabIndex = 35;
            this.lblFemalePaperdoll.Text = "Female Paperdoll:";
            // 
            // picFemalePaperdoll
            // 
            this.picFemalePaperdoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFemalePaperdoll.Location = new System.Drawing.Point(295, 759);
            this.picFemalePaperdoll.Margin = new System.Windows.Forms.Padding(4);
            this.picFemalePaperdoll.Name = "picFemalePaperdoll";
            this.picFemalePaperdoll.Size = new System.Drawing.Size(267, 192);
            this.picFemalePaperdoll.TabIndex = 34;
            this.picFemalePaperdoll.TabStop = false;
            // 
            // lblEffectPercent
            // 
            this.lblEffectPercent.AutoSize = true;
            this.lblEffectPercent.Location = new System.Drawing.Point(13, 630);
            this.lblEffectPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEffectPercent.Name = "lblEffectPercent";
            this.lblEffectPercent.Size = new System.Drawing.Size(126, 17);
            this.lblEffectPercent.TabIndex = 31;
            this.lblEffectPercent.Text = "Effect Amount (%):";
            // 
            // cmbEquipmentBonus
            // 
            this.cmbEquipmentBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEquipmentBonus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEquipmentBonus.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEquipmentBonus.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEquipmentBonus.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEquipmentBonus.ButtonIcon")));
            this.cmbEquipmentBonus.DrawDropdownHoverOutline = false;
            this.cmbEquipmentBonus.DrawFocusRectangle = false;
            this.cmbEquipmentBonus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquipmentBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEquipmentBonus.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEquipmentBonus.FormattingEnabled = true;
            this.cmbEquipmentBonus.Location = new System.Drawing.Point(137, 594);
            this.cmbEquipmentBonus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEquipmentBonus.Name = "cmbEquipmentBonus";
            this.cmbEquipmentBonus.Size = new System.Drawing.Size(151, 23);
            this.cmbEquipmentBonus.TabIndex = 29;
            this.cmbEquipmentBonus.Text = null;
            this.cmbEquipmentBonus.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEquipmentBonus.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentBonus_SelectedIndexChanged);
            // 
            // lblBonusEffect
            // 
            this.lblBonusEffect.AutoSize = true;
            this.lblBonusEffect.Location = new System.Drawing.Point(13, 598);
            this.lblBonusEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonusEffect.Name = "lblBonusEffect";
            this.lblBonusEffect.Size = new System.Drawing.Size(92, 17);
            this.lblBonusEffect.TabIndex = 28;
            this.lblBonusEffect.Text = "Bonus Effect:";
            // 
            // cmbEquipmentSlot
            // 
            this.cmbEquipmentSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEquipmentSlot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEquipmentSlot.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEquipmentSlot.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEquipmentSlot.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEquipmentSlot.ButtonIcon")));
            this.cmbEquipmentSlot.DrawDropdownHoverOutline = false;
            this.cmbEquipmentSlot.DrawFocusRectangle = false;
            this.cmbEquipmentSlot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEquipmentSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEquipmentSlot.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEquipmentSlot.FormattingEnabled = true;
            this.cmbEquipmentSlot.Location = new System.Drawing.Point(137, 23);
            this.cmbEquipmentSlot.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEquipmentSlot.Name = "cmbEquipmentSlot";
            this.cmbEquipmentSlot.Size = new System.Drawing.Size(147, 23);
            this.cmbEquipmentSlot.TabIndex = 24;
            this.cmbEquipmentSlot.Text = null;
            this.cmbEquipmentSlot.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEquipmentSlot.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentSlot_SelectedIndexChanged);
            // 
            // lblEquipmentSlot
            // 
            this.lblEquipmentSlot.AutoSize = true;
            this.lblEquipmentSlot.Location = new System.Drawing.Point(16, 28);
            this.lblEquipmentSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipmentSlot.Name = "lblEquipmentSlot";
            this.lblEquipmentSlot.Size = new System.Drawing.Size(107, 17);
            this.lblEquipmentSlot.TabIndex = 23;
            this.lblEquipmentSlot.Text = "Equipment Slot:";
            // 
            // cmbMalePaperdoll
            // 
            this.cmbMalePaperdoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMalePaperdoll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMalePaperdoll.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMalePaperdoll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMalePaperdoll.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbMalePaperdoll.ButtonIcon")));
            this.cmbMalePaperdoll.DrawDropdownHoverOutline = false;
            this.cmbMalePaperdoll.DrawFocusRectangle = false;
            this.cmbMalePaperdoll.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMalePaperdoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalePaperdoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMalePaperdoll.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMalePaperdoll.FormattingEnabled = true;
            this.cmbMalePaperdoll.Items.AddRange(new object[] {
            "None"});
            this.cmbMalePaperdoll.Location = new System.Drawing.Point(15, 726);
            this.cmbMalePaperdoll.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMalePaperdoll.Name = "cmbMalePaperdoll";
            this.cmbMalePaperdoll.Size = new System.Drawing.Size(223, 23);
            this.cmbMalePaperdoll.TabIndex = 22;
            this.cmbMalePaperdoll.Text = "None";
            this.cmbMalePaperdoll.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbMalePaperdoll.SelectedIndexChanged += new System.EventHandler(this.cmbPaperdoll_SelectedIndexChanged);
            // 
            // lblMalePaperdoll
            // 
            this.lblMalePaperdoll.AutoSize = true;
            this.lblMalePaperdoll.Location = new System.Drawing.Point(11, 705);
            this.lblMalePaperdoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMalePaperdoll.Name = "lblMalePaperdoll";
            this.lblMalePaperdoll.Size = new System.Drawing.Size(106, 17);
            this.lblMalePaperdoll.TabIndex = 21;
            this.lblMalePaperdoll.Text = "Male Paperdoll:";
            // 
            // picMalePaperdoll
            // 
            this.picMalePaperdoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMalePaperdoll.Location = new System.Drawing.Point(15, 759);
            this.picMalePaperdoll.Margin = new System.Windows.Forms.Padding(4);
            this.picMalePaperdoll.Name = "picMalePaperdoll";
            this.picMalePaperdoll.Size = new System.Drawing.Size(267, 192);
            this.picMalePaperdoll.TabIndex = 16;
            this.picMalePaperdoll.TabStop = false;
            // 
            // grpWeaponProperties
            // 
            this.grpWeaponProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpWeaponProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpWeaponProperties.Controls.Add(this.nudCritMultiplier);
            this.grpWeaponProperties.Controls.Add(this.lblCritMultiplier);
            this.grpWeaponProperties.Controls.Add(this.grpAttackSpeed);
            this.grpWeaponProperties.Controls.Add(this.nudScaling);
            this.grpWeaponProperties.Controls.Add(this.nudCritChance);
            this.grpWeaponProperties.Controls.Add(this.nudDamage);
            this.grpWeaponProperties.Controls.Add(this.cmbProjectile);
            this.grpWeaponProperties.Controls.Add(this.cmbScalingStat);
            this.grpWeaponProperties.Controls.Add(this.lblScalingStat);
            this.grpWeaponProperties.Controls.Add(this.lblScalingAmount);
            this.grpWeaponProperties.Controls.Add(this.cmbDamageType);
            this.grpWeaponProperties.Controls.Add(this.lblDamageType);
            this.grpWeaponProperties.Controls.Add(this.lblCritChance);
            this.grpWeaponProperties.Controls.Add(this.cmbAttackAnimation);
            this.grpWeaponProperties.Controls.Add(this.lblAttackAnimation);
            this.grpWeaponProperties.Controls.Add(this.chk2Hand);
            this.grpWeaponProperties.Controls.Add(this.lblToolType);
            this.grpWeaponProperties.Controls.Add(this.cmbToolType);
            this.grpWeaponProperties.Controls.Add(this.lblProjectile);
            this.grpWeaponProperties.Controls.Add(this.lblDamage);
            this.grpWeaponProperties.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpWeaponProperties.Location = new System.Drawing.Point(295, 17);
            this.grpWeaponProperties.Margin = new System.Windows.Forms.Padding(4);
            this.grpWeaponProperties.Name = "grpWeaponProperties";
            this.grpWeaponProperties.Padding = new System.Windows.Forms.Padding(4);
            this.grpWeaponProperties.Size = new System.Drawing.Size(276, 570);
            this.grpWeaponProperties.TabIndex = 39;
            this.grpWeaponProperties.TabStop = false;
            this.grpWeaponProperties.Text = "Weapon Properties";
            this.grpWeaponProperties.Visible = false;
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
            this.nudCritMultiplier.Location = new System.Drawing.Point(20, 137);
            this.nudCritMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.nudCritMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCritMultiplier.Name = "nudCritMultiplier";
            this.nudCritMultiplier.Size = new System.Drawing.Size(240, 22);
            this.nudCritMultiplier.TabIndex = 58;
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
            this.lblCritMultiplier.Location = new System.Drawing.Point(16, 119);
            this.lblCritMultiplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCritMultiplier.Name = "lblCritMultiplier";
            this.lblCritMultiplier.Size = new System.Drawing.Size(182, 17);
            this.lblCritMultiplier.TabIndex = 57;
            this.lblCritMultiplier.Text = "Crit Multiplier (Default 1.5x):";
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
            this.grpAttackSpeed.Location = new System.Drawing.Point(20, 457);
            this.grpAttackSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.grpAttackSpeed.Name = "grpAttackSpeed";
            this.grpAttackSpeed.Padding = new System.Windows.Forms.Padding(4);
            this.grpAttackSpeed.Size = new System.Drawing.Size(240, 106);
            this.grpAttackSpeed.TabIndex = 56;
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
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(20, 288);
            this.nudScaling.Margin = new System.Windows.Forms.Padding(4);
            this.nudScaling.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(240, 22);
            this.nudScaling.TabIndex = 55;
            this.nudScaling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudScaling.ValueChanged += new System.EventHandler(this.nudScaling_ValueChanged);
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(20, 90);
            this.nudCritChance.Margin = new System.Windows.Forms.Padding(4);
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(240, 22);
            this.nudCritChance.TabIndex = 54;
            this.nudCritChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCritChance.ValueChanged += new System.EventHandler(this.nudCritChance_ValueChanged);
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(20, 44);
            this.nudDamage.Margin = new System.Windows.Forms.Padding(4);
            this.nudDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(240, 22);
            this.nudDamage.TabIndex = 49;
            this.nudDamage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDamage.ValueChanged += new System.EventHandler(this.nudDamage_ValueChanged);
            // 
            // cmbProjectile
            // 
            this.cmbProjectile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbProjectile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbProjectile.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbProjectile.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbProjectile.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbProjectile.ButtonIcon")));
            this.cmbProjectile.DrawDropdownHoverOutline = false;
            this.cmbProjectile.DrawFocusRectangle = false;
            this.cmbProjectile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProjectile.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbProjectile.FormattingEnabled = true;
            this.cmbProjectile.Location = new System.Drawing.Point(20, 332);
            this.cmbProjectile.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProjectile.Name = "cmbProjectile";
            this.cmbProjectile.Size = new System.Drawing.Size(239, 23);
            this.cmbProjectile.TabIndex = 47;
            this.cmbProjectile.Text = null;
            this.cmbProjectile.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbProjectile.SelectedIndexChanged += new System.EventHandler(this.cmbProjectile_SelectedIndexChanged);
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
            this.cmbScalingStat.Location = new System.Drawing.Point(21, 238);
            this.cmbScalingStat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(239, 23);
            this.cmbScalingStat.TabIndex = 46;
            this.cmbScalingStat.Text = null;
            this.cmbScalingStat.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbScalingStat.SelectedIndexChanged += new System.EventHandler(this.cmbScalingStat_SelectedIndexChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(17, 217);
            this.lblScalingStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(87, 17);
            this.lblScalingStat.TabIndex = 45;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // lblScalingAmount
            // 
            this.lblScalingAmount.AutoSize = true;
            this.lblScalingAmount.Location = new System.Drawing.Point(16, 270);
            this.lblScalingAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScalingAmount.Name = "lblScalingAmount";
            this.lblScalingAmount.Size = new System.Drawing.Size(110, 17);
            this.lblScalingAmount.TabIndex = 44;
            this.lblScalingAmount.Text = "Scaling Amount:";
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
            "True"});
            this.cmbDamageType.Location = new System.Drawing.Point(21, 187);
            this.cmbDamageType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(239, 23);
            this.cmbDamageType.TabIndex = 42;
            this.cmbDamageType.Text = "Physical";
            this.cmbDamageType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDamageType.SelectedIndexChanged += new System.EventHandler(this.cmbDamageType_SelectedIndexChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(17, 166);
            this.lblDamageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(101, 17);
            this.lblDamageType.TabIndex = 41;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(16, 73);
            this.lblCritChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(111, 17);
            this.lblCritChance.TabIndex = 40;
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
            this.cmbAttackAnimation.Location = new System.Drawing.Point(20, 379);
            this.cmbAttackAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAttackAnimation.Name = "cmbAttackAnimation";
            this.cmbAttackAnimation.Size = new System.Drawing.Size(239, 23);
            this.cmbAttackAnimation.TabIndex = 38;
            this.cmbAttackAnimation.Text = null;
            this.cmbAttackAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAttackAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAttackAnimation_SelectedIndexChanged);
            // 
            // lblAttackAnimation
            // 
            this.lblAttackAnimation.AutoSize = true;
            this.lblAttackAnimation.Location = new System.Drawing.Point(16, 361);
            this.lblAttackAnimation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttackAnimation.Name = "lblAttackAnimation";
            this.lblAttackAnimation.Size = new System.Drawing.Size(117, 17);
            this.lblAttackAnimation.TabIndex = 37;
            this.lblAttackAnimation.Text = "Attack Animation:";
            // 
            // chk2Hand
            // 
            this.chk2Hand.AutoSize = true;
            this.chk2Hand.Location = new System.Drawing.Point(179, 17);
            this.chk2Hand.Margin = new System.Windows.Forms.Padding(4);
            this.chk2Hand.Name = "chk2Hand";
            this.chk2Hand.Size = new System.Drawing.Size(76, 21);
            this.chk2Hand.TabIndex = 25;
            this.chk2Hand.Text = "2 Hand";
            this.chk2Hand.CheckedChanged += new System.EventHandler(this.chk2Hand_CheckedChanged);
            // 
            // lblToolType
            // 
            this.lblToolType.AutoSize = true;
            this.lblToolType.Location = new System.Drawing.Point(17, 412);
            this.lblToolType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToolType.Name = "lblToolType";
            this.lblToolType.Size = new System.Drawing.Size(76, 17);
            this.lblToolType.TabIndex = 26;
            this.lblToolType.Text = "Tool Type:";
            // 
            // cmbToolType
            // 
            this.cmbToolType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbToolType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbToolType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbToolType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbToolType.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbToolType.ButtonIcon")));
            this.cmbToolType.DrawDropdownHoverOutline = false;
            this.cmbToolType.DrawFocusRectangle = false;
            this.cmbToolType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToolType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbToolType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbToolType.FormattingEnabled = true;
            this.cmbToolType.Location = new System.Drawing.Point(21, 430);
            this.cmbToolType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbToolType.Name = "cmbToolType";
            this.cmbToolType.Size = new System.Drawing.Size(239, 23);
            this.cmbToolType.TabIndex = 27;
            this.cmbToolType.Text = null;
            this.cmbToolType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbToolType.SelectedIndexChanged += new System.EventHandler(this.cmbToolType_SelectedIndexChanged);
            // 
            // lblProjectile
            // 
            this.lblProjectile.AutoSize = true;
            this.lblProjectile.Location = new System.Drawing.Point(16, 313);
            this.lblProjectile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectile.Name = "lblProjectile";
            this.lblProjectile.Size = new System.Drawing.Size(70, 17);
            this.lblProjectile.TabIndex = 33;
            this.lblProjectile.Text = "Projectile:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(16, 23);
            this.lblDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(101, 17);
            this.lblDamage.TabIndex = 11;
            this.lblDamage.Text = "Base Damage:";
            // 
            // grpEvent
            // 
            this.grpEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpEvent.Controls.Add(this.cmbEvent);
            this.grpEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpEvent.Location = new System.Drawing.Point(0, 327);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(4);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(4);
            this.grpEvent.Size = new System.Drawing.Size(271, 70);
            this.grpEvent.TabIndex = 42;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Event";
            this.grpEvent.Visible = false;
            // 
            // cmbEvent
            // 
            this.cmbEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEvent.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEvent.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEvent.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEvent.ButtonIcon")));
            this.cmbEvent.DrawDropdownHoverOutline = false;
            this.cmbEvent.DrawFocusRectangle = false;
            this.cmbEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(15, 30);
            this.cmbEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(241, 23);
            this.cmbEvent.TabIndex = 17;
            this.cmbEvent.Text = null;
            this.cmbEvent.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            // 
            // grpConsumable
            // 
            this.grpConsumable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpConsumable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpConsumable.Controls.Add(this.lblPercentage3);
            this.grpConsumable.Controls.Add(this.nudIntervalPercentage);
            this.grpConsumable.Controls.Add(this.lblPlus3);
            this.grpConsumable.Controls.Add(this.nudInterval);
            this.grpConsumable.Controls.Add(this.lblVital);
            this.grpConsumable.Controls.Add(this.cmbConsume);
            this.grpConsumable.Controls.Add(this.lblInterval);
            this.grpConsumable.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpConsumable.Location = new System.Drawing.Point(0, 334);
            this.grpConsumable.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsumable.Name = "grpConsumable";
            this.grpConsumable.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsumable.Size = new System.Drawing.Size(289, 154);
            this.grpConsumable.TabIndex = 12;
            this.grpConsumable.TabStop = false;
            this.grpConsumable.Text = "Consumable";
            this.grpConsumable.Visible = false;
            // 
            // lblPercentage3
            // 
            this.lblPercentage3.AutoSize = true;
            this.lblPercentage3.Location = new System.Drawing.Point(260, 112);
            this.lblPercentage3.Name = "lblPercentage3";
            this.lblPercentage3.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage3.TabIndex = 73;
            this.lblPercentage3.Text = "%";
            // 
            // nudIntervalPercentage
            // 
            this.nudIntervalPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudIntervalPercentage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIntervalPercentage.Location = new System.Drawing.Point(197, 111);
            this.nudIntervalPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.nudIntervalPercentage.Name = "nudIntervalPercentage";
            this.nudIntervalPercentage.Size = new System.Drawing.Size(57, 22);
            this.nudIntervalPercentage.TabIndex = 72;
            this.nudIntervalPercentage.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudIntervalPercentage.ValueChanged += new System.EventHandler(this.nudIntervalPercentage_ValueChanged);
            // 
            // lblPlus3
            // 
            this.lblPlus3.AutoSize = true;
            this.lblPlus3.Location = new System.Drawing.Point(173, 112);
            this.lblPlus3.Name = "lblPlus3";
            this.lblPlus3.Size = new System.Drawing.Size(16, 17);
            this.lblPlus3.TabIndex = 71;
            this.lblPlus3.Text = "+";
            // 
            // nudInterval
            // 
            this.nudInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudInterval.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudInterval.Location = new System.Drawing.Point(25, 111);
            this.nudInterval.Margin = new System.Windows.Forms.Padding(4);
            this.nudInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(141, 22);
            this.nudInterval.TabIndex = 37;
            this.nudInterval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInterval.ValueChanged += new System.EventHandler(this.nudInterval_ValueChanged);
            // 
            // lblVital
            // 
            this.lblVital.AutoSize = true;
            this.lblVital.Location = new System.Drawing.Point(21, 21);
            this.lblVital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVital.Name = "lblVital";
            this.lblVital.Size = new System.Drawing.Size(39, 17);
            this.lblVital.TabIndex = 12;
            this.lblVital.Text = "Vital:";
            // 
            // cmbConsume
            // 
            this.cmbConsume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbConsume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbConsume.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbConsume.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbConsume.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbConsume.ButtonIcon")));
            this.cmbConsume.DrawDropdownHoverOutline = false;
            this.cmbConsume.DrawFocusRectangle = false;
            this.cmbConsume.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbConsume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConsume.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbConsume.FormattingEnabled = true;
            this.cmbConsume.Items.AddRange(new object[] {
            "Health",
            "Mana",
            "Experience"});
            this.cmbConsume.Location = new System.Drawing.Point(25, 46);
            this.cmbConsume.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConsume.Name = "cmbConsume";
            this.cmbConsume.Size = new System.Drawing.Size(233, 23);
            this.cmbConsume.TabIndex = 11;
            this.cmbConsume.Text = "Health";
            this.cmbConsume.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbConsume.SelectedIndexChanged += new System.EventHandler(this.cmbConsume_SelectedIndexChanged);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(25, 87);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(58, 17);
            this.lblInterval.TabIndex = 9;
            this.lblInterval.Text = "Interval:";
            // 
            // grpSpell
            // 
            this.grpSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpell.Controls.Add(this.chkDestroy);
            this.grpSpell.Controls.Add(this.chkQuickCast);
            this.grpSpell.Controls.Add(this.cmbTeachSpell);
            this.grpSpell.Controls.Add(this.lblSpell);
            this.grpSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpell.Location = new System.Drawing.Point(0, 331);
            this.grpSpell.Margin = new System.Windows.Forms.Padding(4);
            this.grpSpell.Name = "grpSpell";
            this.grpSpell.Padding = new System.Windows.Forms.Padding(4);
            this.grpSpell.Size = new System.Drawing.Size(289, 156);
            this.grpSpell.TabIndex = 13;
            this.grpSpell.TabStop = false;
            this.grpSpell.Text = "Spell";
            this.grpSpell.Visible = false;
            // 
            // chkDestroy
            // 
            this.chkDestroy.AutoSize = true;
            this.chkDestroy.Checked = true;
            this.chkDestroy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDestroy.Location = new System.Drawing.Point(20, 117);
            this.chkDestroy.Margin = new System.Windows.Forms.Padding(4);
            this.chkDestroy.Name = "chkDestroy";
            this.chkDestroy.Size = new System.Drawing.Size(139, 21);
            this.chkDestroy.TabIndex = 29;
            this.chkDestroy.Text = "Destroy On Use?";
            this.chkDestroy.CheckedChanged += new System.EventHandler(this.chkDestroy_CheckedChanged);
            // 
            // chkQuickCast
            // 
            this.chkQuickCast.AutoSize = true;
            this.chkQuickCast.Location = new System.Drawing.Point(20, 89);
            this.chkQuickCast.Margin = new System.Windows.Forms.Padding(4);
            this.chkQuickCast.Name = "chkQuickCast";
            this.chkQuickCast.Size = new System.Drawing.Size(141, 21);
            this.chkQuickCast.TabIndex = 28;
            this.chkQuickCast.Text = "Quick Cast Spell?";
            this.chkQuickCast.CheckedChanged += new System.EventHandler(this.chkQuickCast_CheckedChanged);
            // 
            // cmbTeachSpell
            // 
            this.cmbTeachSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbTeachSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbTeachSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTeachSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbTeachSpell.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbTeachSpell.ButtonIcon")));
            this.cmbTeachSpell.DrawDropdownHoverOutline = false;
            this.cmbTeachSpell.DrawFocusRectangle = false;
            this.cmbTeachSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeachSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeachSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbTeachSpell.FormattingEnabled = true;
            this.cmbTeachSpell.Location = new System.Drawing.Point(20, 49);
            this.cmbTeachSpell.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTeachSpell.Name = "cmbTeachSpell";
            this.cmbTeachSpell.Size = new System.Drawing.Size(239, 23);
            this.cmbTeachSpell.TabIndex = 12;
            this.cmbTeachSpell.Text = null;
            this.cmbTeachSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbTeachSpell.SelectedIndexChanged += new System.EventHandler(this.cmbTeachSpell_SelectedIndexChanged);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(16, 26);
            this.lblSpell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(43, 17);
            this.lblSpell.TabIndex = 11;
            this.lblSpell.Text = "Spell:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.darkGroupBox1);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpEquipment);
            this.pnlContainer.Controls.Add(this.grpEvent);
            this.pnlContainer.Controls.Add(this.grpSpell);
            this.pnlContainer.Controls.Add(this.grpBags);
            this.pnlContainer.Controls.Add(this.grpConsumable);
            this.pnlContainer.Location = new System.Drawing.Point(295, 42);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(617, 544);
            this.pnlContainer.TabIndex = 43;
            this.pnlContainer.Visible = false;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.darkGroupBox1.Controls.Add(this.lblDark);
            this.darkGroupBox1.Controls.Add(this.lblLight);
            this.darkGroupBox1.Controls.Add(this.lblEarth);
            this.darkGroupBox1.Controls.Add(this.lblWind);
            this.darkGroupBox1.Controls.Add(this.nudDark);
            this.darkGroupBox1.Controls.Add(this.nudLight);
            this.darkGroupBox1.Controls.Add(this.nudThunder);
            this.darkGroupBox1.Controls.Add(this.nudWind);
            this.darkGroupBox1.Controls.Add(this.nudNature);
            this.darkGroupBox1.Controls.Add(this.nudWater);
            this.darkGroupBox1.Controls.Add(this.nudEarth);
            this.darkGroupBox1.Controls.Add(this.nudIce);
            this.darkGroupBox1.Controls.Add(this.nudFire);
            this.darkGroupBox1.Controls.Add(this.lblNature);
            this.darkGroupBox1.Controls.Add(this.lblThunder);
            this.darkGroupBox1.Controls.Add(this.lblWater);
            this.darkGroupBox1.Controls.Add(this.lblIce);
            this.darkGroupBox1.Controls.Add(this.lblFire);
            this.darkGroupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkGroupBox1.Location = new System.Drawing.Point(4, 265);
            this.darkGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.darkGroupBox1.Size = new System.Drawing.Size(576, 61);
            this.darkGroupBox1.TabIndex = 83;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Stat Bonuses";
            // 
            // lblDark
            // 
            this.lblDark.AutoSize = true;
            this.lblDark.Location = new System.Drawing.Point(470, 12);
            this.lblDark.Name = "lblDark";
            this.lblDark.Size = new System.Drawing.Size(42, 17);
            this.lblDark.TabIndex = 82;
            this.lblDark.Text = "Dark:";
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Location = new System.Drawing.Point(410, 12);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(43, 17);
            this.lblLight.TabIndex = 80;
            this.lblLight.Text = "Light:";
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Location = new System.Drawing.Point(177, 12);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(46, 17);
            this.lblEarth.TabIndex = 79;
            this.lblEarth.Text = "Earth:";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(236, 11);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(44, 17);
            this.lblWind.TabIndex = 78;
            this.lblWind.Text = "Wind:";
            // 
            // nudDark
            // 
            this.nudDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDark.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDark.Location = new System.Drawing.Point(471, 30);
            this.nudDark.Margin = new System.Windows.Forms.Padding(4);
            this.nudDark.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDark.Name = "nudDark";
            this.nudDark.Size = new System.Drawing.Size(57, 22);
            this.nudDark.TabIndex = 76;
            this.nudDark.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDark.ValueChanged += new System.EventHandler(this.nudDark_ValueChanged);
            // 
            // nudLight
            // 
            this.nudLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLight.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLight.Location = new System.Drawing.Point(412, 30);
            this.nudLight.Margin = new System.Windows.Forms.Padding(4);
            this.nudLight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLight.Name = "nudLight";
            this.nudLight.Size = new System.Drawing.Size(57, 22);
            this.nudLight.TabIndex = 75;
            this.nudLight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudLight.ValueChanged += new System.EventHandler(this.nudLight_ValueChanged);
            // 
            // nudThunder
            // 
            this.nudThunder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudThunder.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudThunder.Location = new System.Drawing.Point(122, 30);
            this.nudThunder.Margin = new System.Windows.Forms.Padding(4);
            this.nudThunder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudThunder.Name = "nudThunder";
            this.nudThunder.Size = new System.Drawing.Size(57, 22);
            this.nudThunder.TabIndex = 74;
            this.nudThunder.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudThunder.ValueChanged += new System.EventHandler(this.nudThunder_ValueChanged);
            // 
            // nudWind
            // 
            this.nudWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWind.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWind.Location = new System.Drawing.Point(238, 30);
            this.nudWind.Margin = new System.Windows.Forms.Padding(4);
            this.nudWind.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWind.Name = "nudWind";
            this.nudWind.Size = new System.Drawing.Size(57, 22);
            this.nudWind.TabIndex = 73;
            this.nudWind.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWind.ValueChanged += new System.EventHandler(this.nudWind_ValueChanged);
            // 
            // nudNature
            // 
            this.nudNature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudNature.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudNature.Location = new System.Drawing.Point(354, 30);
            this.nudNature.Margin = new System.Windows.Forms.Padding(4);
            this.nudNature.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudNature.Name = "nudNature";
            this.nudNature.Size = new System.Drawing.Size(57, 22);
            this.nudNature.TabIndex = 52;
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
            this.nudWater.Location = new System.Drawing.Point(296, 30);
            this.nudWater.Margin = new System.Windows.Forms.Padding(4);
            this.nudWater.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(57, 22);
            this.nudWater.TabIndex = 51;
            this.nudWater.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWater.ValueChanged += new System.EventHandler(this.nudWater_ValueChanged);
            // 
            // nudEarth
            // 
            this.nudEarth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudEarth.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudEarth.Location = new System.Drawing.Point(180, 30);
            this.nudEarth.Margin = new System.Windows.Forms.Padding(4);
            this.nudEarth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEarth.Name = "nudEarth";
            this.nudEarth.Size = new System.Drawing.Size(57, 22);
            this.nudEarth.TabIndex = 50;
            this.nudEarth.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudEarth.ValueChanged += new System.EventHandler(this.nudEarth_ValueChanged);
            // 
            // nudIce
            // 
            this.nudIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudIce.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudIce.Location = new System.Drawing.Point(64, 30);
            this.nudIce.Margin = new System.Windows.Forms.Padding(4);
            this.nudIce.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudIce.Name = "nudIce";
            this.nudIce.Size = new System.Drawing.Size(57, 22);
            this.nudIce.TabIndex = 49;
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
            this.nudFire.Location = new System.Drawing.Point(6, 30);
            this.nudFire.Margin = new System.Windows.Forms.Padding(4);
            this.nudFire.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFire.Name = "nudFire";
            this.nudFire.Size = new System.Drawing.Size(57, 22);
            this.nudFire.TabIndex = 48;
            this.nudFire.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFire.ValueChanged += new System.EventHandler(this.nudFire_ValueChanged);
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(349, 11);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(55, 17);
            this.lblNature.TabIndex = 47;
            this.lblNature.Text = "Nature:";
            // 
            // lblThunder
            // 
            this.lblThunder.AutoSize = true;
            this.lblThunder.Location = new System.Drawing.Point(113, 11);
            this.lblThunder.Name = "lblThunder";
            this.lblThunder.Size = new System.Drawing.Size(66, 17);
            this.lblThunder.TabIndex = 46;
            this.lblThunder.Text = "Thunder:";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(293, 12);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(50, 17);
            this.lblWater.TabIndex = 45;
            this.lblWater.Text = "Water:";
            // 
            // lblIce
            // 
            this.lblIce.AutoSize = true;
            this.lblIce.Location = new System.Drawing.Point(61, 14);
            this.lblIce.Name = "lblIce";
            this.lblIce.Size = new System.Drawing.Size(30, 17);
            this.lblIce.TabIndex = 44;
            this.lblIce.Text = "Ice:";
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Location = new System.Drawing.Point(4, 14);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(36, 17);
            this.lblFire.TabIndex = 43;
            this.lblFire.Text = "Fire:";
            // 
            // grpBags
            // 
            this.grpBags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpBags.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpBags.Controls.Add(this.nudBag);
            this.grpBags.Controls.Add(this.lblBag);
            this.grpBags.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpBags.Location = new System.Drawing.Point(4, 334);
            this.grpBags.Margin = new System.Windows.Forms.Padding(4);
            this.grpBags.Name = "grpBags";
            this.grpBags.Padding = new System.Windows.Forms.Padding(4);
            this.grpBags.Size = new System.Drawing.Size(296, 70);
            this.grpBags.TabIndex = 44;
            this.grpBags.TabStop = false;
            this.grpBags.Text = "Bag:";
            this.grpBags.Visible = false;
            // 
            // nudBag
            // 
            this.nudBag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBag.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBag.Location = new System.Drawing.Point(92, 28);
            this.nudBag.Margin = new System.Windows.Forms.Padding(4);
            this.nudBag.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudBag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBag.Name = "nudBag";
            this.nudBag.Size = new System.Drawing.Size(192, 22);
            this.nudBag.TabIndex = 38;
            this.nudBag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBag.ValueChanged += new System.EventHandler(this.nudBag_ValueChanged);
            // 
            // lblBag
            // 
            this.lblBag.AutoSize = true;
            this.lblBag.Location = new System.Drawing.Point(11, 31);
            this.lblBag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(72, 17);
            this.lblBag.TabIndex = 11;
            this.lblBag.Text = "Bag Slots:";
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
            this.toolStrip.Size = new System.Drawing.Size(915, 31);
            this.toolStrip.TabIndex = 44;
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
            // nudDurability
            // 
            this.nudDurability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDurability.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDurability.Location = new System.Drawing.Point(89, 666);
            this.nudDurability.Margin = new System.Windows.Forms.Padding(4);
            this.nudDurability.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDurability.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudDurability.Name = "nudDurability";
            this.nudDurability.Size = new System.Drawing.Size(159, 22);
            this.nudDurability.TabIndex = 74;
            this.nudDurability.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDurability.ValueChanged += new System.EventHandler(this.nudDurability_ValueChanged);
            // 
            // lblDurability
            // 
            this.lblDurability.AutoSize = true;
            this.lblDurability.Location = new System.Drawing.Point(15, 668);
            this.lblDurability.Name = "lblDurability";
            this.lblDurability.Size = new System.Drawing.Size(71, 17);
            this.lblDurability.TabIndex = 73;
            this.lblDurability.Text = "Durability:";
            // 
            // nudWeaponSkillPoints
            // 
            this.nudWeaponSkillPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudWeaponSkillPoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudWeaponSkillPoints.Location = new System.Drawing.Point(408, 663);
            this.nudWeaponSkillPoints.Margin = new System.Windows.Forms.Padding(4);
            this.nudWeaponSkillPoints.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudWeaponSkillPoints.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nudWeaponSkillPoints.Name = "nudWeaponSkillPoints";
            this.nudWeaponSkillPoints.Size = new System.Drawing.Size(159, 22);
            this.nudWeaponSkillPoints.TabIndex = 76;
            this.nudWeaponSkillPoints.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWeaponSkillPoints.ValueChanged += new System.EventHandler(this.nudWeaponSkillPoints_ValueChanged);
            // 
            // lblWeaponSkillPoints
            // 
            this.lblWeaponSkillPoints.AutoSize = true;
            this.lblWeaponSkillPoints.Location = new System.Drawing.Point(268, 665);
            this.lblWeaponSkillPoints.Name = "lblWeaponSkillPoints";
            this.lblWeaponSkillPoints.Size = new System.Drawing.Size(137, 17);
            this.lblWeaponSkillPoints.TabIndex = 75;
            this.lblWeaponSkillPoints.Text = "Weapon Skill Points:";
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(915, 636);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmItem_FormClosed);
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            this.grpRegen.ResumeLayout(false);
            this.grpRegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPRegen)).EndInit();
            this.grpVitalBonuses.ResumeLayout(false);
            this.grpVitalBonuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMPPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManaBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealthBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEffectPercent)).EndInit();
            this.grpStatBonuses.ResumeLayout(false);
            this.grpStatBonuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaithPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpdPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMRPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemalePaperdoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMalePaperdoll)).EndInit();
            this.grpWeaponProperties.ResumeLayout(false);
            this.grpWeaponProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritMultiplier)).EndInit();
            this.grpAttackSpeed.ResumeLayout(false);
            this.grpAttackSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttackSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            this.grpEvent.ResumeLayout(false);
            this.grpConsumable.ResumeLayout(false);
            this.grpConsumable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.grpSpell.ResumeLayout(false);
            this.grpSpell.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFire)).EndInit();
            this.grpBags.ResumeLayout(false);
            this.grpBags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBag)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponSkillPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblName;
        private Label lblType;
        private Label lblAnim;
        private Label lblPrice;
        private PictureBox picItem;
        private Label lblDamage;
        private PictureBox picMalePaperdoll;
        private Label lblInterval;
        private Label lblVital;
        private Label lblSpell;
        private Label lblRange;
        private Label lblPic;
        private Label lblMalePaperdoll;
        private Label lblDesc;
        private Label lblEquipmentSlot;
        private Label lblEffectPercent;
        private Label lblBonusEffect;
        private Label lblToolType;
        private Label lblProjectile;
        private Panel pnlContainer;
        private Label lblFemalePaperdoll;
        private PictureBox picFemalePaperdoll;
        private ToolStripButton toolStripItemNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripItemDelete;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStripButton toolStripItemCopy;
        public ToolStripButton toolStripItemPaste;
        private ToolStripSeparator toolStripSeparator3;
        public ToolStripButton toolStripItemUndo;
        private Label lblAttackAnimation;
        private DarkUI.Controls.DarkGroupBox grpStatBonuses;
        private DarkUI.Controls.DarkGroupBox grpWeaponProperties;
        private Label lblScalingAmount;
        private Label lblDamageType;
        private Label lblCritChance;
        private Label lblScalingStat;
        private DarkGroupBox grpItems;
        private DarkButton btnSave;
        private DarkGroupBox grpGeneral;
        private DarkTextBox txtName;
        private DarkComboBox cmbType;
        private DarkGroupBox grpEquipment;
        private DarkGroupBox grpConsumable;
        private DarkComboBox cmbConsume;
        private DarkGroupBox grpSpell;
        private DarkButton btnCancel;
        private DarkComboBox cmbPic;
        private DarkComboBox cmbMalePaperdoll;
        private DarkTextBox txtDesc;
        private DarkCheckBox chk2Hand;
        private DarkComboBox cmbEquipmentSlot;
        private DarkComboBox cmbEquipmentBonus;
        private DarkComboBox cmbToolType;
        private DarkGroupBox grpEvent;
        private DarkComboBox cmbFemalePaperdoll;
        private DarkComboBox cmbAttackAnimation;
        private DarkComboBox cmbDamageType;
        private DarkComboBox cmbScalingStat;
        private DarkComboBox cmbProjectile;
        private DarkToolStrip toolStrip;
        private DarkButton btnEditRequirements;
        private DarkComboBox cmbAnimation;
        private DarkComboBox cmbTeachSpell;
        private DarkComboBox cmbEvent;
        private DarkGroupBox grpBags;
        private Label lblBag;
        private DarkNumericUpDown nudPrice;
        private DarkNumericUpDown nudBag;
        private DarkNumericUpDown nudInterval;
        private DarkNumericUpDown nudEffectPercent;
        private DarkNumericUpDown nudRange;
        private DarkNumericUpDown nudSpd;
        private DarkNumericUpDown nudMR;
        private DarkNumericUpDown nudDef;
        private DarkNumericUpDown nudMag;
        private DarkNumericUpDown nudStr;
        private Label lblSpd;
        private Label lblMR;
        private Label lblDef;
        private Label lblMag;
        private Label lblStr;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudCritChance;
        private DarkNumericUpDown nudDamage;
        private DarkCheckBox chkStackable;
        private DarkCheckBox chkBound;
        private DarkGroupBox grpVitalBonuses;
        private DarkNumericUpDown nudManaBonus;
        private DarkNumericUpDown nudHealthBonus;
        private Label lblManaBonus;
        private Label lblHealthBonus;
        private DarkComboBox cmbEquipmentAnimation;
        private Label lblEquipmentAnimation;
        private DarkGroupBox grpAttackSpeed;
        private DarkNumericUpDown nudAttackSpeedValue;
        private Label lblAttackSpeedValue;
        private DarkComboBox cmbAttackSpeedModifier;
        private Label lblAttackSpeedModifier;
        private DarkNumericUpDown nudCritMultiplier;
        private Label lblCritMultiplier;
        private DarkNumericUpDown nudCooldown;
        private Label lblCooldown;
        private DarkCheckBox chkDestroy;
        private DarkCheckBox chkQuickCast;
        private DarkComboBox cmbRarity;
        private Label lblRarity;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        public TreeView lstItems;
        private ToolStripButton btnChronological;
        private ToolStripSeparator toolStripSeparator4;
        private DarkButton btnAddFolder;
        private Label lblFolder;
        private DarkComboBox cmbFolder;
        private ImageList imageList;
        private Label lblPercentage2;
        private Label lblPercentage1;
        private DarkNumericUpDown nudMPPercentage;
        private DarkNumericUpDown nudHPPercentage;
        private Label lblPlus2;
        private Label lblPlus1;
        private Label lblPercentage3;
        private DarkNumericUpDown nudIntervalPercentage;
        private Label lblPlus3;
        private Label lblPercentage5;
        private Label lblPercentage4;
        private Label lblPercentage8;
        private Label lblPercentage7;
        private Label lblPercentage6;
        private DarkNumericUpDown nudSpdPercentage;
        private DarkNumericUpDown nudMRPercentage;
        private DarkNumericUpDown nudDefPercentage;
        private DarkNumericUpDown nudMagPercentage;
        private DarkNumericUpDown nudStrPercentage;
        private Label lblPlus5;
        private Label lblPlus4;
        private Label lblPlus8;
        private Label lblPlus7;
        private Label lblPlus6;
    private DarkGroupBox grpRegen;
    private DarkNumericUpDown nudMpRegen;
    private DarkNumericUpDown nudHPRegen;
    private Label lblHpRegen;
    private Label lblManaRegen;
    private Label lblRegenHint;
        private DarkGroupBox darkGroupBox1;
        private Label lblDark;
        private Label lblLight;
        private Label lblEarth;
        private Label lblWind;
        private DarkNumericUpDown nudDark;
        private DarkNumericUpDown nudLight;
        private DarkNumericUpDown nudThunder;
        private DarkNumericUpDown nudWind;
        private DarkNumericUpDown nudNature;
        private DarkNumericUpDown nudWater;
        private DarkNumericUpDown nudEarth;
        private DarkNumericUpDown nudIce;
        private DarkNumericUpDown nudFire;
        private Label lblNature;
        private Label lblThunder;
        private Label lblWater;
        private Label lblIce;
        private Label lblFire;
        private DarkNumericUpDown nudCapacity;
        private Label lblWeight;
        private Label label1;
        private DarkNumericUpDown nudFaithPercentage;
        private Label label2;
        private DarkNumericUpDown nudFaith;
        private Label lblFaith;
        private DarkNumericUpDown nudWeaponSkillPoints;
        private Label lblWeaponSkillPoints;
        private DarkNumericUpDown nudDurability;
        private Label lblDurability;
    }
}
