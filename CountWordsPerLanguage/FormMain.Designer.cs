namespace CountWordsPerLanguage
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.languagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.LargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageAdd = new System.Windows.Forms.TabPage();
      this.textBoxDocTitle = new System.Windows.Forms.TextBox();
      this.labelDocTitle = new System.Windows.Forms.Label();
      this.buttonClear = new System.Windows.Forms.Button();
      this.labelCharacterCount = new System.Windows.Forms.Label();
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.labelWordsCount = new System.Windows.Forms.Label();
      this.labelChooseLanguage = new System.Windows.Forms.Label();
      this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
      this.buttonCountWords = new System.Windows.Forms.Button();
      this.tabPageStatistics = new System.Windows.Forms.TabPage();
      this.buttonClearResults = new System.Windows.Forms.Button();
      this.dataGridViewStatResult = new System.Windows.Forms.DataGridView();
      this.listBoxStatResult = new System.Windows.Forms.ListBox();
      this.labelStatChooseLanguage = new System.Windows.Forms.Label();
      this.comboBoxStatChooseLanguage = new System.Windows.Forms.ComboBox();
      this.buttonStatLoadResult = new System.Windows.Forms.Button();
      this.ColumnLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.labelAvailableLanguage = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageAdd.SuspendLayout();
      this.tabPageStatistics.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatResult)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languagetoolStripMenuItem,
            this.DisplayToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.newToolStripMenuItem.Text = "&Nouveau";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.openToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(244, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveToolStripMenuItem.Text = "&Enregistrer";
      // 
      // saveasToolStripMenuItem
      // 
      this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
      this.saveasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.saveasToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printToolStripMenuItem.Text = "&Imprimer";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.printPreviewToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.cutToolStripMenuItem.Text = "&Couper";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.copyToolStripMenuItem.Text = "Co&pier";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.toolsToolStripMenuItem.Text = "&Outils";
      // 
      // personalizeToolStripMenuItem
      // 
      this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
      this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.personalizeToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // languagetoolStripMenuItem
      // 
      this.languagetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.languagetoolStripMenuItem.Name = "languagetoolStripMenuItem";
      this.languagetoolStripMenuItem.Size = new System.Drawing.Size(86, 24);
      this.languagetoolStripMenuItem.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
      // 
      // DisplayToolStripMenuItem
      // 
      this.DisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmallToolStripMenuItem,
            this.MediumToolStripMenuItem,
            this.LargeToolStripMenuItem});
      this.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
      this.DisplayToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
      this.DisplayToolStripMenuItem.Text = "Affichage";
      // 
      // SmallToolStripMenuItem
      // 
      this.SmallToolStripMenuItem.Checked = true;
      this.SmallToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
      this.SmallToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.SmallToolStripMenuItem.Text = "Petit";
      this.SmallToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
      // 
      // MediumToolStripMenuItem
      // 
      this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
      this.MediumToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.MediumToolStripMenuItem.Text = "Moyen";
      this.MediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
      // 
      // LargeToolStripMenuItem
      // 
      this.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem";
      this.LargeToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
      this.LargeToolStripMenuItem.Text = "Grand";
      this.LargeToolStripMenuItem.Click += new System.EventHandler(this.LargeToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // summaryToolStripMenuItem
      // 
      this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
      this.summaryToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.summaryToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.searchToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // tabControlMain
      // 
      this.tabControlMain.Controls.Add(this.tabPageAdd);
      this.tabControlMain.Controls.Add(this.tabPageStatistics);
      this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlMain.Location = new System.Drawing.Point(0, 28);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1132, 464);
      this.tabControlMain.TabIndex = 9;
      // 
      // tabPageAdd
      // 
      this.tabPageAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tabPageAdd.Controls.Add(this.textBoxDocTitle);
      this.tabPageAdd.Controls.Add(this.labelDocTitle);
      this.tabPageAdd.Controls.Add(this.buttonClear);
      this.tabPageAdd.Controls.Add(this.labelCharacterCount);
      this.tabPageAdd.Controls.Add(this.textBoxSource);
      this.tabPageAdd.Controls.Add(this.labelWordsCount);
      this.tabPageAdd.Controls.Add(this.labelChooseLanguage);
      this.tabPageAdd.Controls.Add(this.comboBoxLanguage);
      this.tabPageAdd.Controls.Add(this.buttonCountWords);
      this.tabPageAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
      this.tabPageAdd.Name = "tabPageAdd";
      this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageAdd.Size = new System.Drawing.Size(1124, 435);
      this.tabPageAdd.TabIndex = 1;
      this.tabPageAdd.Text = "Add";
      this.tabPageAdd.UseVisualStyleBackColor = true;
      // 
      // textBoxDocTitle
      // 
      this.textBoxDocTitle.Location = new System.Drawing.Point(215, 53);
      this.textBoxDocTitle.Name = "textBoxDocTitle";
      this.textBoxDocTitle.Size = new System.Drawing.Size(426, 26);
      this.textBoxDocTitle.TabIndex = 32;
      this.textBoxDocTitle.Text = "Untitled document";
      // 
      // labelDocTitle
      // 
      this.labelDocTitle.AutoSize = true;
      this.labelDocTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDocTitle.Location = new System.Drawing.Point(14, 56);
      this.labelDocTitle.Name = "labelDocTitle";
      this.labelDocTitle.Size = new System.Drawing.Size(123, 20);
      this.labelDocTitle.TabIndex = 31;
      this.labelDocTitle.Text = "Document title:";
      // 
      // buttonClear
      // 
      this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClear.Location = new System.Drawing.Point(524, 17);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(117, 31);
      this.buttonClear.TabIndex = 26;
      this.buttonClear.Text = "Clear";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // labelCharacterCount
      // 
      this.labelCharacterCount.AutoSize = true;
      this.labelCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelCharacterCount.Location = new System.Drawing.Point(211, 87);
      this.labelCharacterCount.Name = "labelCharacterCount";
      this.labelCharacterCount.Size = new System.Drawing.Size(177, 20);
      this.labelCharacterCount.TabIndex = 30;
      this.labelCharacterCount.Text = "Number of characters:";
      // 
      // textBoxSource
      // 
      this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxSource.Location = new System.Drawing.Point(18, 118);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxSource.Size = new System.Drawing.Size(1090, 329);
      this.textBoxSource.TabIndex = 18;
      this.textBoxSource.Text = "azAZ";
      this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
      // 
      // labelWordsCount
      // 
      this.labelWordsCount.AutoSize = true;
      this.labelWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWordsCount.Location = new System.Drawing.Point(14, 87);
      this.labelWordsCount.Name = "labelWordsCount";
      this.labelWordsCount.Size = new System.Drawing.Size(142, 20);
      this.labelWordsCount.TabIndex = 28;
      this.labelWordsCount.Text = "Number of words:";
      // 
      // labelChooseLanguage
      // 
      this.labelChooseLanguage.AutoSize = true;
      this.labelChooseLanguage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelChooseLanguage.Location = new System.Drawing.Point(14, 21);
      this.labelChooseLanguage.Name = "labelChooseLanguage";
      this.labelChooseLanguage.Size = new System.Drawing.Size(172, 20);
      this.labelChooseLanguage.TabIndex = 20;
      this.labelChooseLanguage.Text = "Choose a language";
      // 
      // comboBoxLanguage
      // 
      this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxLanguage.FormattingEnabled = true;
      this.comboBoxLanguage.Location = new System.Drawing.Point(215, 18);
      this.comboBoxLanguage.Name = "comboBoxLanguage";
      this.comboBoxLanguage.Size = new System.Drawing.Size(157, 28);
      this.comboBoxLanguage.TabIndex = 22;
      // 
      // buttonCountWords
      // 
      this.buttonCountWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCountWords.Location = new System.Drawing.Point(378, 16);
      this.buttonCountWords.Name = "buttonCountWords";
      this.buttonCountWords.Size = new System.Drawing.Size(140, 31);
      this.buttonCountWords.TabIndex = 24;
      this.buttonCountWords.Text = "Count";
      this.buttonCountWords.UseVisualStyleBackColor = true;
      this.buttonCountWords.Click += new System.EventHandler(this.buttonCountWords_Click);
      // 
      // tabPageStatistics
      // 
      this.tabPageStatistics.Controls.Add(this.labelAvailableLanguage);
      this.tabPageStatistics.Controls.Add(this.buttonClearResults);
      this.tabPageStatistics.Controls.Add(this.dataGridViewStatResult);
      this.tabPageStatistics.Controls.Add(this.listBoxStatResult);
      this.tabPageStatistics.Controls.Add(this.labelStatChooseLanguage);
      this.tabPageStatistics.Controls.Add(this.comboBoxStatChooseLanguage);
      this.tabPageStatistics.Controls.Add(this.buttonStatLoadResult);
      this.tabPageStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tabPageStatistics.Location = new System.Drawing.Point(4, 25);
      this.tabPageStatistics.Name = "tabPageStatistics";
      this.tabPageStatistics.Size = new System.Drawing.Size(1124, 435);
      this.tabPageStatistics.TabIndex = 2;
      this.tabPageStatistics.Text = "Letter statistics";
      this.tabPageStatistics.UseVisualStyleBackColor = true;
      // 
      // buttonClearResults
      // 
      this.buttonClearResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClearResults.Location = new System.Drawing.Point(687, 23);
      this.buttonClearResults.Name = "buttonClearResults";
      this.buttonClearResults.Size = new System.Drawing.Size(224, 31);
      this.buttonClearResults.TabIndex = 30;
      this.buttonClearResults.Text = "Clear results";
      this.buttonClearResults.UseVisualStyleBackColor = true;
      this.buttonClearResults.Click += new System.EventHandler(this.buttonClearResults_Click);
      // 
      // dataGridViewStatResult
      // 
      this.dataGridViewStatResult.AllowUserToAddRows = false;
      this.dataGridViewStatResult.AllowUserToDeleteRows = false;
      this.dataGridViewStatResult.AllowUserToOrderColumns = true;
      this.dataGridViewStatResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewStatResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewStatResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLanguage,
            this.ColumnLetter,
            this.ColumnFrequency});
      this.dataGridViewStatResult.Location = new System.Drawing.Point(273, 76);
      this.dataGridViewStatResult.Name = "dataGridViewStatResult";
      this.dataGridViewStatResult.ReadOnly = true;
      this.dataGridViewStatResult.RowTemplate.Height = 24;
      this.dataGridViewStatResult.Size = new System.Drawing.Size(823, 336);
      this.dataGridViewStatResult.TabIndex = 29;
      // 
      // listBoxStatResult
      // 
      this.listBoxStatResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listBoxStatResult.FormattingEnabled = true;
      this.listBoxStatResult.ItemHeight = 20;
      this.listBoxStatResult.Location = new System.Drawing.Point(28, 116);
      this.listBoxStatResult.Name = "listBoxStatResult";
      this.listBoxStatResult.Size = new System.Drawing.Size(212, 304);
      this.listBoxStatResult.TabIndex = 28;
      // 
      // labelStatChooseLanguage
      // 
      this.labelStatChooseLanguage.AutoSize = true;
      this.labelStatChooseLanguage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelStatChooseLanguage.Location = new System.Drawing.Point(24, 28);
      this.labelStatChooseLanguage.Name = "labelStatChooseLanguage";
      this.labelStatChooseLanguage.Size = new System.Drawing.Size(172, 20);
      this.labelStatChooseLanguage.TabIndex = 25;
      this.labelStatChooseLanguage.Text = "Choose a language";
      // 
      // comboBoxStatChooseLanguage
      // 
      this.comboBoxStatChooseLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxStatChooseLanguage.FormattingEnabled = true;
      this.comboBoxStatChooseLanguage.Location = new System.Drawing.Point(225, 25);
      this.comboBoxStatChooseLanguage.Name = "comboBoxStatChooseLanguage";
      this.comboBoxStatChooseLanguage.Size = new System.Drawing.Size(157, 28);
      this.comboBoxStatChooseLanguage.TabIndex = 26;
      // 
      // buttonStatLoadResult
      // 
      this.buttonStatLoadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonStatLoadResult.Location = new System.Drawing.Point(388, 23);
      this.buttonStatLoadResult.Name = "buttonStatLoadResult";
      this.buttonStatLoadResult.Size = new System.Drawing.Size(257, 31);
      this.buttonStatLoadResult.TabIndex = 27;
      this.buttonStatLoadResult.Text = "Load results";
      this.buttonStatLoadResult.UseVisualStyleBackColor = true;
      this.buttonStatLoadResult.Click += new System.EventHandler(this.buttonStatLoadResult_Click);
      // 
      // ColumnLanguage
      // 
      this.ColumnLanguage.HeaderText = "Language";
      this.ColumnLanguage.Name = "ColumnLanguage";
      this.ColumnLanguage.ReadOnly = true;
      // 
      // ColumnLetter
      // 
      this.ColumnLetter.HeaderText = "Letter";
      this.ColumnLetter.Name = "ColumnLetter";
      this.ColumnLetter.ReadOnly = true;
      // 
      // ColumnFrequency
      // 
      this.ColumnFrequency.HeaderText = "Number of occurence";
      this.ColumnFrequency.Name = "ColumnFrequency";
      this.ColumnFrequency.ReadOnly = true;
      this.ColumnFrequency.Width = 300;
      // 
      // labelAvailableLanguage
      // 
      this.labelAvailableLanguage.AutoSize = true;
      this.labelAvailableLanguage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAvailableLanguage.Location = new System.Drawing.Point(24, 76);
      this.labelAvailableLanguage.Name = "labelAvailableLanguage";
      this.labelAvailableLanguage.Size = new System.Drawing.Size(172, 20);
      this.labelAvailableLanguage.TabIndex = 31;
      this.labelAvailableLanguage.Text = "Available language";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1132, 492);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Count letter frequency per language";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageAdd.ResumeLayout(false);
      this.tabPageAdd.PerformLayout();
      this.tabPageStatistics.ResumeLayout(false);
      this.tabPageStatistics.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languagetoolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SmallToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MediumToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem LargeToolStripMenuItem;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabPageAdd;
    private System.Windows.Forms.Button buttonClear;
    private System.Windows.Forms.Label labelCharacterCount;
    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Label labelWordsCount;
    private System.Windows.Forms.Label labelChooseLanguage;
    private System.Windows.Forms.ComboBox comboBoxLanguage;
    private System.Windows.Forms.Button buttonCountWords;
    private System.Windows.Forms.TabPage tabPageStatistics;
    private System.Windows.Forms.Label labelStatChooseLanguage;
    private System.Windows.Forms.ComboBox comboBoxStatChooseLanguage;
    private System.Windows.Forms.Button buttonStatLoadResult;
    private System.Windows.Forms.DataGridView dataGridViewStatResult;
    private System.Windows.Forms.ListBox listBoxStatResult;
    private System.Windows.Forms.TextBox textBoxDocTitle;
    private System.Windows.Forms.Label labelDocTitle;
    private System.Windows.Forms.Button buttonClearResults;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLanguage;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLetter;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrequency;
    private System.Windows.Forms.Label labelAvailableLanguage;
  }
}