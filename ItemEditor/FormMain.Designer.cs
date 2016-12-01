namespace ItemEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelRarity = new System.Windows.Forms.Label();
            this.labelUnknown = new System.Windows.Forms.Label();
            this.labelModifier = new System.Windows.Forms.Label();
            this.labelSubType = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.comboBoxSubType = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxAdapted = new System.Windows.Forms.CheckBox();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterial = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRarity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUnknown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownModifier = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSubType = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownType = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonNone = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.checkBoxHighlight = new System.Windows.Forms.CheckBox();
            this.numericUpDownVisible = new System.Windows.Forms.NumericUpDown();
            this.labelVisible = new System.Windows.Forms.Label();
            this.comboBoxTypeC = new System.Windows.Forms.ComboBox();
            this.labelTypeC = new System.Windows.Forms.Label();
            this.numericUpDownTypeC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLevelC = new System.Windows.Forms.NumericUpDown();
            this.labelLevelC = new System.Windows.Forms.Label();
            this.labelPosZ = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            this.labelPosX = new System.Windows.Forms.Label();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.listBoxSlots = new System.Windows.Forms.ListBox();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.checkBoxStayOnTop = new System.Windows.Forms.CheckBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownType)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTypeC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxItem
            // 
            this.listBoxItem.Enabled = false;
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Items.AddRange(new object[] {
            "holding?",
            "unknown",
            "neck",
            "chest",
            "feet",
            "hands",
            "shoulder",
            "Lweapon",
            "Rweapon",
            "leftRing",
            "rightRing",
            "lamp",
            "special",
            "pet"});
            this.listBoxItem.Location = new System.Drawing.Point(0, 0);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(53, 186);
            this.listBoxItem.TabIndex = 0;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(53, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(174, 187);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelLevel);
            this.tabPage1.Controls.Add(this.labelMaterial);
            this.tabPage1.Controls.Add(this.labelRarity);
            this.tabPage1.Controls.Add(this.labelUnknown);
            this.tabPage1.Controls.Add(this.labelModifier);
            this.tabPage1.Controls.Add(this.labelSubType);
            this.tabPage1.Controls.Add(this.labelType);
            this.tabPage1.Controls.Add(this.comboBoxMaterial);
            this.tabPage1.Controls.Add(this.comboBoxRarity);
            this.tabPage1.Controls.Add(this.comboBoxSubType);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.checkBoxAdapted);
            this.tabPage1.Controls.Add(this.numericUpDownLevel);
            this.tabPage1.Controls.Add(this.numericUpDownMaterial);
            this.tabPage1.Controls.Add(this.numericUpDownRarity);
            this.tabPage1.Controls.Add(this.numericUpDownUnknown);
            this.tabPage1.Controls.Add(this.numericUpDownModifier);
            this.tabPage1.Controls.Add(this.numericUpDownSubType);
            this.tabPage1.Controls.Add(this.numericUpDownType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(166, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(-3, 130);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 18;
            this.labelLevel.Text = "Level";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(-3, 109);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(44, 13);
            this.labelMaterial.TabIndex = 17;
            this.labelMaterial.Text = "Material";
            // 
            // labelRarity
            // 
            this.labelRarity.AutoSize = true;
            this.labelRarity.Location = new System.Drawing.Point(-3, 88);
            this.labelRarity.Name = "labelRarity";
            this.labelRarity.Size = new System.Drawing.Size(34, 13);
            this.labelRarity.TabIndex = 16;
            this.labelRarity.Text = "Rarity";
            // 
            // labelUnknown
            // 
            this.labelUnknown.AutoSize = true;
            this.labelUnknown.Location = new System.Drawing.Point(-3, 67);
            this.labelUnknown.Name = "labelUnknown";
            this.labelUnknown.Size = new System.Drawing.Size(53, 13);
            this.labelUnknown.TabIndex = 15;
            this.labelUnknown.Text = "Unknown";
            // 
            // labelModifier
            // 
            this.labelModifier.AutoSize = true;
            this.labelModifier.Location = new System.Drawing.Point(-3, 46);
            this.labelModifier.Name = "labelModifier";
            this.labelModifier.Size = new System.Drawing.Size(44, 13);
            this.labelModifier.TabIndex = 14;
            this.labelModifier.Text = "Modifier";
            // 
            // labelSubType
            // 
            this.labelSubType.AutoSize = true;
            this.labelSubType.Location = new System.Drawing.Point(-3, 25);
            this.labelSubType.Name = "labelSubType";
            this.labelSubType.Size = new System.Drawing.Size(50, 13);
            this.labelSubType.TabIndex = 13;
            this.labelSubType.Text = "SubType";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(-3, 4);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "None",
            "Iron",
            "Wood",
            "unknown",
            "unknown",
            "Obsidian",
            "unknown",
            "Bone",
            "unknown",
            "unknown",
            "unknown",
            "Gold",
            "Silver",
            "Emerald",
            "Sapphire",
            "Ruby",
            "Diamond",
            "Sandstone",
            "Saurian",
            "Parrot",
            "Mammoth",
            "Plant",
            "Ice",
            "Licht",
            "Glass",
            "Silk",
            "Linen",
            "Cotton",
            "",
            "Fire",
            "Unholy",
            "Ice",
            "Wind"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(91, 105);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(75, 21);
            this.comboBoxMaterial.TabIndex = 11;
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // comboBoxRarity
            // 
            this.comboBoxRarity.FormattingEnabled = true;
            this.comboBoxRarity.Items.AddRange(new object[] {
            "Normal",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary",
            "Mystic"});
            this.comboBoxRarity.Location = new System.Drawing.Point(91, 84);
            this.comboBoxRarity.Name = "comboBoxRarity";
            this.comboBoxRarity.Size = new System.Drawing.Size(75, 21);
            this.comboBoxRarity.TabIndex = 10;
            this.comboBoxRarity.SelectedIndexChanged += new System.EventHandler(this.comboBoxRarity_SelectedIndexChanged);
            // 
            // comboBoxSubType
            // 
            this.comboBoxSubType.Enabled = false;
            this.comboBoxSubType.FormattingEnabled = true;
            this.comboBoxSubType.Location = new System.Drawing.Point(91, 21);
            this.comboBoxSubType.Name = "comboBoxSubType";
            this.comboBoxSubType.Size = new System.Drawing.Size(75, 21);
            this.comboBoxSubType.TabIndex = 9;
            this.comboBoxSubType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubType_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "None",
            "Food",
            "Formula",
            "Weapon",
            "Chest Armor",
            "Gloves",
            "Boots",
            "Shoulder Armor",
            "Amulet",
            "Ring",
            "Spirit",
            "Nugget",
            "Coin",
            "Platinum",
            "Leftover",
            "Beak",
            "Painting",
            "Vase/Pot",
            "Candle",
            "Pet",
            "Pet Food",
            "Quest Item",
            "Unknown",
            "Special",
            "Lamp",
            "Mana Cube"});
            this.comboBoxType.Location = new System.Drawing.Point(91, 0);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(75, 21);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxAdapted
            // 
            this.checkBoxAdapted.AutoSize = true;
            this.checkBoxAdapted.Location = new System.Drawing.Point(-5, 147);
            this.checkBoxAdapted.Name = "checkBoxAdapted";
            this.checkBoxAdapted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAdapted.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAdapted.TabIndex = 7;
            this.checkBoxAdapted.Text = "Adapted ";
            this.checkBoxAdapted.UseVisualStyleBackColor = true;
            this.checkBoxAdapted.Click += new System.EventHandler(this.checkBoxAdapted_Click);
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(50, 126);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownLevel.TabIndex = 6;
            this.numericUpDownLevel.ValueChanged += new System.EventHandler(this.numericUpDownLevel_ValueChanged);
            // 
            // numericUpDownMaterial
            // 
            this.numericUpDownMaterial.Location = new System.Drawing.Point(50, 105);
            this.numericUpDownMaterial.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaterial.Name = "numericUpDownMaterial";
            this.numericUpDownMaterial.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMaterial.TabIndex = 5;
            this.numericUpDownMaterial.ValueChanged += new System.EventHandler(this.numericUpDownMaterial_ValueChanged);
            // 
            // numericUpDownRarity
            // 
            this.numericUpDownRarity.Location = new System.Drawing.Point(50, 84);
            this.numericUpDownRarity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRarity.Name = "numericUpDownRarity";
            this.numericUpDownRarity.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRarity.TabIndex = 4;
            this.numericUpDownRarity.ValueChanged += new System.EventHandler(this.numericUpDownRarity_ValueChanged);
            // 
            // numericUpDownUnknown
            // 
            this.numericUpDownUnknown.Location = new System.Drawing.Point(50, 63);
            this.numericUpDownUnknown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownUnknown.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericUpDownUnknown.Name = "numericUpDownUnknown";
            this.numericUpDownUnknown.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownUnknown.TabIndex = 3;
            this.numericUpDownUnknown.ValueChanged += new System.EventHandler(this.numericUpDownUnknown_ValueChanged);
            // 
            // numericUpDownModifier
            // 
            this.numericUpDownModifier.Location = new System.Drawing.Point(50, 42);
            this.numericUpDownModifier.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownModifier.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericUpDownModifier.Name = "numericUpDownModifier";
            this.numericUpDownModifier.Size = new System.Drawing.Size(116, 20);
            this.numericUpDownModifier.TabIndex = 2;
            this.numericUpDownModifier.ValueChanged += new System.EventHandler(this.numericUpDownModifier_ValueChanged);
            // 
            // numericUpDownSubType
            // 
            this.numericUpDownSubType.Location = new System.Drawing.Point(50, 21);
            this.numericUpDownSubType.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSubType.Name = "numericUpDownSubType";
            this.numericUpDownSubType.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSubType.TabIndex = 1;
            this.numericUpDownSubType.ValueChanged += new System.EventHandler(this.numericUpDownSubType_ValueChanged);
            // 
            // numericUpDownType
            // 
            this.numericUpDownType.Location = new System.Drawing.Point(50, 0);
            this.numericUpDownType.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownType.Name = "numericUpDownType";
            this.numericUpDownType.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownType.TabIndex = 0;
            this.numericUpDownType.ValueChanged += new System.EventHandler(this.numericUpDownType_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonNone);
            this.tabPage2.Controls.Add(this.buttonAll);
            this.tabPage2.Controls.Add(this.checkBoxHighlight);
            this.tabPage2.Controls.Add(this.numericUpDownVisible);
            this.tabPage2.Controls.Add(this.labelVisible);
            this.tabPage2.Controls.Add(this.comboBoxTypeC);
            this.tabPage2.Controls.Add(this.labelTypeC);
            this.tabPage2.Controls.Add(this.numericUpDownTypeC);
            this.tabPage2.Controls.Add(this.numericUpDownLevelC);
            this.tabPage2.Controls.Add(this.labelLevelC);
            this.tabPage2.Controls.Add(this.labelPosZ);
            this.tabPage2.Controls.Add(this.labelPosY);
            this.tabPage2.Controls.Add(this.labelPosX);
            this.tabPage2.Controls.Add(this.numericUpDownZ);
            this.tabPage2.Controls.Add(this.numericUpDownY);
            this.tabPage2.Controls.Add(this.numericUpDownX);
            this.tabPage2.Controls.Add(this.listBoxSlots);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(166, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "cubes/spirits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonNone
            // 
            this.buttonNone.Enabled = false;
            this.buttonNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNone.Location = new System.Drawing.Point(35, 106);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(40, 15);
            this.buttonNone.TabIndex = 4;
            this.buttonNone.Text = "NONE";
            this.buttonNone.UseVisualStyleBackColor = true;
            // 
            // buttonAll
            // 
            this.buttonAll.Enabled = false;
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(-1, 106);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(36, 15);
            this.buttonAll.TabIndex = 4;
            this.buttonAll.Text = "ALL";
            this.buttonAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxHighlight
            // 
            this.checkBoxHighlight.AutoSize = true;
            this.checkBoxHighlight.Enabled = false;
            this.checkBoxHighlight.Location = new System.Drawing.Point(78, 83);
            this.checkBoxHighlight.Name = "checkBoxHighlight";
            this.checkBoxHighlight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHighlight.Size = new System.Drawing.Size(68, 30);
            this.checkBoxHighlight.TabIndex = 4;
            this.checkBoxHighlight.Text = "Highlight\r\nSelected";
            this.checkBoxHighlight.UseVisualStyleBackColor = true;
            this.checkBoxHighlight.Click += new System.EventHandler(this.checkBoxHighlight_Click);
            // 
            // numericUpDownVisible
            // 
            this.numericUpDownVisible.Location = new System.Drawing.Point(95, 143);
            this.numericUpDownVisible.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownVisible.Name = "numericUpDownVisible";
            this.numericUpDownVisible.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownVisible.TabIndex = 13;
            this.numericUpDownVisible.ValueChanged += new System.EventHandler(this.numericUpDownVisible_ValueChanged);
            // 
            // labelVisible
            // 
            this.labelVisible.AutoSize = true;
            this.labelVisible.Location = new System.Drawing.Point(16, 145);
            this.labelVisible.Name = "labelVisible";
            this.labelVisible.Size = new System.Drawing.Size(81, 13);
            this.labelVisible.TabIndex = 12;
            this.labelVisible.Text = "visible slots:  0 -";
            // 
            // comboBoxTypeC
            // 
            this.comboBoxTypeC.Enabled = false;
            this.comboBoxTypeC.FormattingEnabled = true;
            this.comboBoxTypeC.Items.AddRange(new object[] {
            "None",
            "Iron",
            "Wood",
            " ",
            " ",
            "Obsidian",
            " ",
            "Bone",
            " ",
            " ",
            " ",
            "Gold",
            "Silver",
            "Emerald",
            "Sapphire",
            "Ruby",
            "Diamond",
            "Sandstone",
            "Saurian",
            "Parrot",
            "Mammoth",
            "Plant",
            "Ice",
            "Licht",
            "Glass",
            "Silk",
            "Linen",
            "Cotton",
            " ",
            "Fire",
            "Unholy",
            "Ice",
            "Wind"});
            this.comboBoxTypeC.Location = new System.Drawing.Point(81, 122);
            this.comboBoxTypeC.Name = "comboBoxTypeC";
            this.comboBoxTypeC.Size = new System.Drawing.Size(85, 21);
            this.comboBoxTypeC.TabIndex = 11;
            this.comboBoxTypeC.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeC_SelectedIndexChanged);
            // 
            // labelTypeC
            // 
            this.labelTypeC.AutoSize = true;
            this.labelTypeC.Location = new System.Drawing.Point(-1, 126);
            this.labelTypeC.Name = "labelTypeC";
            this.labelTypeC.Size = new System.Drawing.Size(31, 13);
            this.labelTypeC.TabIndex = 10;
            this.labelTypeC.Text = "Type";
            // 
            // numericUpDownTypeC
            // 
            this.numericUpDownTypeC.Enabled = false;
            this.numericUpDownTypeC.Location = new System.Drawing.Point(30, 123);
            this.numericUpDownTypeC.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTypeC.Name = "numericUpDownTypeC";
            this.numericUpDownTypeC.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownTypeC.TabIndex = 9;
            this.numericUpDownTypeC.ValueChanged += new System.EventHandler(this.numericUpDownTypeC_ValueChanged);
            // 
            // numericUpDownLevelC
            // 
            this.numericUpDownLevelC.Enabled = false;
            this.numericUpDownLevelC.Location = new System.Drawing.Point(126, 63);
            this.numericUpDownLevelC.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownLevelC.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDownLevelC.Name = "numericUpDownLevelC";
            this.numericUpDownLevelC.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownLevelC.TabIndex = 8;
            this.numericUpDownLevelC.ValueChanged += new System.EventHandler(this.numericUpDownLevelC_ValueChanged);
            // 
            // labelLevelC
            // 
            this.labelLevelC.AutoSize = true;
            this.labelLevelC.Location = new System.Drawing.Point(80, 66);
            this.labelLevelC.Name = "labelLevelC";
            this.labelLevelC.Size = new System.Drawing.Size(33, 13);
            this.labelLevelC.TabIndex = 7;
            this.labelLevelC.Text = "Level";
            // 
            // labelPosZ
            // 
            this.labelPosZ.AutoSize = true;
            this.labelPosZ.Location = new System.Drawing.Point(80, 46);
            this.labelPosZ.Name = "labelPosZ";
            this.labelPosZ.Size = new System.Drawing.Size(32, 13);
            this.labelPosZ.TabIndex = 6;
            this.labelPosZ.Text = "PosZ";
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.Location = new System.Drawing.Point(80, 25);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(32, 13);
            this.labelPosY.TabIndex = 5;
            this.labelPosY.Text = "PosY";
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.Location = new System.Drawing.Point(80, 4);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(32, 13);
            this.labelPosX.TabIndex = 4;
            this.labelPosX.Text = "PosX";
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Enabled = false;
            this.numericUpDownZ.Location = new System.Drawing.Point(126, 42);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownZ.TabIndex = 3;
            this.numericUpDownZ.ValueChanged += new System.EventHandler(this.numericUpDownZ_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Enabled = false;
            this.numericUpDownY.Location = new System.Drawing.Point(126, 21);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownY.TabIndex = 2;
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Enabled = false;
            this.numericUpDownX.Location = new System.Drawing.Point(126, 0);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownX.TabIndex = 1;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // listBoxSlots
            // 
            this.listBoxSlots.ColumnWidth = 19;
            this.listBoxSlots.FormattingEnabled = true;
            this.listBoxSlots.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.listBoxSlots.Location = new System.Drawing.Point(-2, -2);
            this.listBoxSlots.MultiColumn = true;
            this.listBoxSlots.Name = "listBoxSlots";
            this.listBoxSlots.Size = new System.Drawing.Size(80, 108);
            this.listBoxSlots.TabIndex = 0;
            this.listBoxSlots.SelectedIndexChanged += new System.EventHandler(this.listBoxSlots_SelectedIndexChanged);
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(225, 164);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(98, 23);
            this.buttonAttach.TabIndex = 2;
            this.buttonAttach.Text = "Attach to process";
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // checkBoxStayOnTop
            // 
            this.checkBoxStayOnTop.AutoSize = true;
            this.checkBoxStayOnTop.Location = new System.Drawing.Point(234, 148);
            this.checkBoxStayOnTop.Name = "checkBoxStayOnTop";
            this.checkBoxStayOnTop.Size = new System.Drawing.Size(80, 17);
            this.checkBoxStayOnTop.TabIndex = 5;
            this.checkBoxStayOnTop.Text = "StayOnTop";
            this.checkBoxStayOnTop.UseVisualStyleBackColor = true;
            this.checkBoxStayOnTop.Click += new System.EventHandler(this.checkBoxStayOnTop_Click);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(225, 104);
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(98, 45);
            this.trackBarOpacity.TabIndex = 4;
            this.trackBarOpacity.Value = 10;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(236, 93);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(75, 13);
            this.labelOpacity.TabIndex = 5;
            this.labelOpacity.Text = "Opacity: 100%";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "ToDo:\r\n-SubType\r\n- multi-select\r\n- detect clientVer.\r\n\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOpacity);
            this.Controls.Add(this.trackBarOpacity);
            this.Controls.Add(this.checkBoxStayOnTop);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "ItemEditor (v1.0)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownType)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTypeC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevelC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxAdapted;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterial;
        private System.Windows.Forms.NumericUpDown numericUpDownRarity;
        private System.Windows.Forms.NumericUpDown numericUpDownUnknown;
        private System.Windows.Forms.NumericUpDown numericUpDownModifier;
        private System.Windows.Forms.NumericUpDown numericUpDownSubType;
        private System.Windows.Forms.NumericUpDown numericUpDownType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.ComboBox comboBoxSubType;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelRarity;
        private System.Windows.Forms.Label labelUnknown;
        private System.Windows.Forms.Label labelModifier;
        private System.Windows.Forms.Label labelSubType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ListBox listBoxSlots;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.CheckBox checkBoxStayOnTop;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.ComboBox comboBoxTypeC;
        private System.Windows.Forms.Label labelTypeC;
        private System.Windows.Forms.NumericUpDown numericUpDownTypeC;
        private System.Windows.Forms.NumericUpDown numericUpDownLevelC;
        private System.Windows.Forms.Label labelLevelC;
        private System.Windows.Forms.Label labelPosZ;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.NumericUpDown numericUpDownVisible;
        private System.Windows.Forms.Label labelVisible;
        private System.Windows.Forms.CheckBox checkBoxHighlight;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

