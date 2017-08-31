#define debug
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using CountWordsPerLanguage.Properties;

namespace CountWordsPerLanguage
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    readonly Dictionary<string, string> _languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> _languageDicoFr = new Dictionary<string, string>();
    private string _currentLanguage = "english";
    private float _fontSize = 10f;

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveWindowValue();
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      aboutBoxApplication.ShowDialog();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadSettingsAtStartup();
      textBoxSource_TextChanged(sender, e);
    }

    private void LoadSettingsAtStartup()
    {
      DisplayTitle();
      LoadComboBox(comboBoxLanguage, Settings.Default.LanguagePerCountryFileName);
      LoadComboBox(comboBoxStatChooseLanguage, Settings.Default.LanguagePerCountryFileName);
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      AdjustAllControls();
    }

    private static void LoadComboBox(ComboBox cb, string fileName)
    {
      if (!File.Exists(fileName))
      {
        CreateFile(fileName);
      }

      XDocument xDoc;
      try
      {
        xDoc = XDocument.Load(fileName);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Error while loading xml file " + exception);
        CreateFile(fileName);
        return;
      }
      
      var result = from node in xDoc.Descendants("language")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   select new
                   {
                     name = xElementName.Value,
                   };

      cb.Items.Clear();
      foreach (var item in result)
      {
        cb.Items.Add(item.name);
      }

      cb.SelectedIndex = 0;
    }

    private static void CreateFile(string fileName)
    {
      if (fileName != Settings.Default.LanguagePerCountryFileName) return;
      var minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<languages>",
        "<language>",
        "<name>English</name>",
        "</language>",
        "<language>",
        "<name>French</name>",
        "</language>",
        "<language>",
        "<name>Italian</name>",
        "</language>",
        "<language>",
        "<name>Spanish</name>",
        "</language>",
        "<language>",
        "<name>Portuguese</name>",
        "</language>",
        "<language>",
        "<name>German</name>",
        "</language>",
        "<language>",
        "<name>Russian</name>",
        "</language>",
        "</languages>"
      };

      StreamWriter sw = new StreamWriter(Settings.Default.LanguagePerCountryFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc;
      try
      {
        xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Error while loading xml file " + exception);
        CreateLanguageFile();
        return;
      }
      
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        if (!_languageDicoEn.ContainsKey(i.name))
        {
          _languageDicoEn.Add(i.name, i.englishValue);
        }
        else
        {
          MessageBox.Show("Your xml file has duplicate like: " + i.name);
        }

        if (!_languageDicoFr.ContainsKey(i.name))
        {
          _languageDicoFr.Add(i.name, i.frenchValue);
        }
        else
        {
          MessageBox.Show("Your xml file has duplicate like: " + i.name);
        }
      }
    }

    private static void CreateLanguageFile()
    {
      var minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileNew</name>",
        "<englishValue>New</englishValue>",
        "<frenchValue>Nouveau</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileOpen</name>",
        "<englishValue>Open</englishValue>",
        "<frenchValue>Ouvrir</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSave</name>",
        "<englishValue>Save</englishValue>",
        "<frenchValue>Enregistrer</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFileSaveAs</name>",
        "<englishValue>Save as ...</englishValue>",
        "<frenchValue>Enregistrer sous ...</frenchValue>",
        "</term>",
        "<term>",
        "<name>MenuFilePrint</name>",
        "<englishValue>Print ...</englishValue>",
        "<frenchValue>Imprimer ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufilePageSetup</name>",
          "<englishValue>Page setup</englishValue>",
          "<frenchValue>Aperçu avant impression</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenufileQuit</name>",
          "<englishValue>Quit</englishValue>",
          "<frenchValue>Quitter</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEdit</name>",
          "<englishValue>Edit</englishValue>",
          "<frenchValue>Edition</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCancel</name>",
          "<englishValue>Cancel</englishValue>",
          "<frenchValue>Annuler</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditRedo</name>",
          "<englishValue>Redo</englishValue>",
          "<frenchValue>Rétablir</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCut</name>",
          "<englishValue>Cut</englishValue>",
          "<frenchValue>Couper</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditCopy</name>",
          "<englishValue>Copy</englishValue>",
          "<frenchValue>Copier</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditPaste</name>",
          "<englishValue>Paste</englishValue>",
          "<frenchValue>Coller</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuEditSelectAll</name>",
          "<englishValue>Select All</englishValue>",
          "<frenchValue>Sélectionner tout</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuTools</name>",
          "<englishValue>Tools</englishValue>",
          "<frenchValue>Outils</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsCustomize</name>",
          "<englishValue>Customize ...</englishValue>",
          "<frenchValue>Personaliser ...</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuToolsOptions</name>",
          "<englishValue>Options</englishValue>",
          "<frenchValue>Options</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguage</name>",
          "<englishValue>Language</englishValue>",
          "<frenchValue>Langage</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageEnglish</name>",
          "<englishValue>English</englishValue>",
          "<frenchValue>Anglais</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuLanguageFrench</name>",
          "<englishValue>French</englishValue>",
          "<frenchValue>Français</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelp</name>",
          "<englishValue>Help</englishValue>",
          "<frenchValue>Aide</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSummary</name>",
          "<englishValue>Summary</englishValue>",
          "<frenchValue>Sommaire</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpIndex</name>",
          "<englishValue>Index</englishValue>",
          "<frenchValue>Index</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpSearch</name>",
          "<englishValue>Search</englishValue>",
          "<frenchValue>Rechercher</frenchValue>",
        "</term>",
        "<term>",
          "<name>MenuHelpAbout</name>",
          "<englishValue>About</englishValue>",
          "<frenchValue>A propos de ...</frenchValue>",
        "</term>",
        "</terms>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      SetDisplayOption(Settings.Default.DisplayToolStripMenuItem);
      comboBoxLanguage.SelectedIndex = Settings.Default.comboBoxLanguage;
      comboBoxStatChooseLanguage.SelectedIndex = Settings.Default.comboBoxStatChooseLanguage;
      tabControlMain.SelectedIndex = Settings.Default.SelectedTabControl;
      _fontSize = Settings.Default._fontSize;
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.DisplayToolStripMenuItem = GetDisplayOption();
      Settings.Default.comboBoxLanguage = comboBoxLanguage.SelectedIndex;
      Settings.Default._fontSize = _fontSize;
      Settings.Default.comboBoxStatChooseLanguage = comboBoxStatChooseLanguage.SelectedIndex;
      Settings.Default.SelectedTabControl = tabControlMain.SelectedIndex;
      Settings.Default.Save();
    }

    private string GetDisplayOption()
    {
      if (SmallToolStripMenuItem.Checked)
      {
        return "Small";
      }

      if (MediumToolStripMenuItem.Checked)
      {
        return "Medium";
      }

      return LargeToolStripMenuItem.Checked ? "Large" : string.Empty;
    }

    private void SetDisplayOption(string option)
    {
      UncheckAllOptions();
      switch (option.ToLower())
      {
        case "small":
          SmallToolStripMenuItem.Checked = true;
          break;
        case "medium":
          MediumToolStripMenuItem.Checked = true;
          break;
        case "large":
          LargeToolStripMenuItem.Checked = true;
          break;
        default:
          SmallToolStripMenuItem.Checked = true;
          break;
      }
    }

    private void UncheckAllOptions()
    {
      SmallToolStripMenuItem.Checked = false;
      MediumToolStripMenuItem.Checked = false;
      LargeToolStripMenuItem.Checked = false;
    }

    private void FormMainFormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.French.ToString();
      SetLanguage(Language.French.ToString());
      AdjustAllControls();
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _currentLanguage = Language.English.ToString();
      SetLanguage(Language.English.ToString());
      AdjustAllControls();
    }

    private void SetLanguage(string myLanguage)
    {
      while (true)
      {
        switch (myLanguage)
        {
          case "English":
            frenchToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            fileToolStripMenuItem.Text = _languageDicoEn["MenuFile"];
            newToolStripMenuItem.Text = _languageDicoEn["MenuFileNew"];
            openToolStripMenuItem.Text = _languageDicoEn["MenuFileOpen"];
            saveToolStripMenuItem.Text = _languageDicoEn["MenuFileSave"];
            saveasToolStripMenuItem.Text = _languageDicoEn["MenuFileSaveAs"];
            printPreviewToolStripMenuItem.Text = _languageDicoEn["MenuFilePrint"];
            printPreviewToolStripMenuItem.Text = _languageDicoEn["MenufilePageSetup"];
            quitToolStripMenuItem.Text = _languageDicoEn["MenufileQuit"];
            editToolStripMenuItem.Text = _languageDicoEn["MenuEdit"];
            cancelToolStripMenuItem.Text = _languageDicoEn["MenuEditCancel"];
            redoToolStripMenuItem.Text = _languageDicoEn["MenuEditRedo"];
            cutToolStripMenuItem.Text = _languageDicoEn["MenuEditCut"];
            copyToolStripMenuItem.Text = _languageDicoEn["MenuEditCopy"];
            pasteToolStripMenuItem.Text = _languageDicoEn["MenuEditPaste"];
            selectAllToolStripMenuItem.Text = _languageDicoEn["MenuEditSelectAll"];
            toolsToolStripMenuItem.Text = _languageDicoEn["MenuTools"];
            personalizeToolStripMenuItem.Text = _languageDicoEn["MenuToolsCustomize"];
            optionsToolStripMenuItem.Text = _languageDicoEn["MenuToolsOptions"];
            languagetoolStripMenuItem.Text = _languageDicoEn["MenuLanguage"];
            englishToolStripMenuItem.Text = _languageDicoEn["MenuLanguageEnglish"];
            frenchToolStripMenuItem.Text = _languageDicoEn["MenuLanguageFrench"];
            helpToolStripMenuItem.Text = _languageDicoEn["MenuHelp"];
            summaryToolStripMenuItem.Text = _languageDicoEn["MenuHelpSummary"];
            indexToolStripMenuItem.Text = _languageDicoEn["MenuHelpIndex"];
            searchToolStripMenuItem.Text = _languageDicoEn["MenuHelpSearch"];
            aboutToolStripMenuItem.Text = _languageDicoEn["MenuHelpAbout"];
            DisplayToolStripMenuItem.Text = _languageDicoEn["Display"];
            SmallToolStripMenuItem.Text = _languageDicoEn["Small"];
            MediumToolStripMenuItem.Text = _languageDicoEn["Medium"];
            LargeToolStripMenuItem.Text = _languageDicoEn["Large"];
            labelChooseLanguage.Text = _languageDicoEn["Choose a language"];
            buttonCountWords.Text = _languageDicoEn["Count"];
            buttonClear.Text = _languageDicoEn["Clear"];
            labelWordsCount.Text = _languageDicoEn["Number of words"];
            labelCharacterCount.Text = _languageDicoEn["Number of characters"];
            textBoxSource_TextChanged(null, null);
            labelStatChooseLanguage.Text = _languageDicoEn["Choose a language"];
            buttonStatLoadResult.Text = _languageDicoEn["Load results"];
            labelDocTitle.Text = _languageDicoEn["Document title"];
            ConditionalTranslate(Language.English, textBoxDocTitle, "Untitled document");
            buttonClearResults.Text = _languageDicoEn["Clear results"];
            labelAvailableLanguage.Text = _languageDicoEn["Available Language"];
            _currentLanguage = "English";
            break;
          case "French":
            frenchToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            fileToolStripMenuItem.Text = _languageDicoFr["MenuFile"];
            newToolStripMenuItem.Text = _languageDicoFr["MenuFileNew"];
            openToolStripMenuItem.Text = _languageDicoFr["MenuFileOpen"];
            saveToolStripMenuItem.Text = _languageDicoFr["MenuFileSave"];
            saveasToolStripMenuItem.Text = _languageDicoFr["MenuFileSaveAs"];
            printPreviewToolStripMenuItem.Text = _languageDicoFr["MenuFilePrint"];
            printPreviewToolStripMenuItem.Text = _languageDicoFr["MenufilePageSetup"];
            quitToolStripMenuItem.Text = _languageDicoFr["MenufileQuit"];
            editToolStripMenuItem.Text = _languageDicoFr["MenuEdit"];
            cancelToolStripMenuItem.Text = _languageDicoFr["MenuEditCancel"];
            redoToolStripMenuItem.Text = _languageDicoFr["MenuEditRedo"];
            cutToolStripMenuItem.Text = _languageDicoFr["MenuEditCut"];
            copyToolStripMenuItem.Text = _languageDicoFr["MenuEditCopy"];
            pasteToolStripMenuItem.Text = _languageDicoFr["MenuEditPaste"];
            selectAllToolStripMenuItem.Text = _languageDicoFr["MenuEditSelectAll"];
            toolsToolStripMenuItem.Text = _languageDicoFr["MenuTools"];
            personalizeToolStripMenuItem.Text = _languageDicoFr["MenuToolsCustomize"];
            optionsToolStripMenuItem.Text = _languageDicoFr["MenuToolsOptions"];
            languagetoolStripMenuItem.Text = _languageDicoFr["MenuLanguage"];
            englishToolStripMenuItem.Text = _languageDicoFr["MenuLanguageEnglish"];
            frenchToolStripMenuItem.Text = _languageDicoFr["MenuLanguageFrench"];
            helpToolStripMenuItem.Text = _languageDicoFr["MenuHelp"];
            summaryToolStripMenuItem.Text = _languageDicoFr["MenuHelpSummary"];
            indexToolStripMenuItem.Text = _languageDicoFr["MenuHelpIndex"];
            searchToolStripMenuItem.Text = _languageDicoFr["MenuHelpSearch"];
            aboutToolStripMenuItem.Text = _languageDicoFr["MenuHelpAbout"];
            DisplayToolStripMenuItem.Text = _languageDicoFr["Display"];
            SmallToolStripMenuItem.Text = _languageDicoFr["Small"];
            MediumToolStripMenuItem.Text = _languageDicoFr["Medium"];
            LargeToolStripMenuItem.Text = _languageDicoFr["Large"];
            labelChooseLanguage.Text = _languageDicoFr["Choose a language"];
            buttonCountWords.Text = _languageDicoFr["Count"];
            buttonClear.Text = _languageDicoFr["Clear"];
            labelWordsCount.Text = _languageDicoFr["Number of words"];
            labelCharacterCount.Text = _languageDicoFr["Number of characters"];
            textBoxSource_TextChanged(null, null);
            labelStatChooseLanguage.Text = _languageDicoFr["Choose a language"];
            buttonStatLoadResult.Text = _languageDicoFr["Load results"];
            labelDocTitle.Text = _languageDicoFr["Document title"];
            ConditionalTranslate(Language.French, textBoxDocTitle, "Untitled document");
            buttonClearResults.Text = _languageDicoFr["Clear results"];
            labelAvailableLanguage.Text = _languageDicoFr["Available Language"];
            _currentLanguage = "French";
            break;
          default:
            myLanguage = "English";
            continue;
        }
        break;
      }
    }

    private void ConditionalTranslate(Language language, Control ctrl, string condition)
    {
      if (ctrl.Text == condition)
      {
        if (language == Language.French)
        {
          ctrl.Text = _languageDicoFr[condition];
          return;
        }

        if (language == Language.English)
        {
          ctrl.Text = _languageDicoEn[condition];
          // return; // if any other language
        }
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CutToClipboard(tb);
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        CopyToClipboard(tb);
      }
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      var tb = focusedControl as TextBox;
      if (tb != null)
      {
        PasteFromClipboard(tb);
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Control focusedControl = FindFocusedControl(new List<Control> { textBoxSource });
      TextBox control = focusedControl as TextBox;
      if (!(control == null))
      {
        control.SelectAll();
      }
    }

    private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIs") + Punctuation.OneSpace +
          Translate(errorMessage) + Punctuation.OneSpace +
          Translate("ToCut") + Punctuation.OneSpace, Translate(errorMessage),
          MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(errorMessage), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
      tb.SelectedText = string.Empty;
    }

    private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
    {
      if (tb != ActiveControl) return;
      if (tb.Text == string.Empty)
      {
        DisplayMessage(Translate("ThereIsNothingToCopy") + Punctuation.OneSpace,
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      if (tb.SelectedText == string.Empty)
      {
        DisplayMessage(Translate("NoTextHasBeenSelected"),
          Translate(message), MessageBoxButtons.OK);
        return;
      }

      Clipboard.SetText(tb.SelectedText);
    }

    private void PasteFromClipboard(TextBoxBase tb)
    {
      if (tb != ActiveControl) return;
      var selectionIndex = tb.SelectionStart;
      tb.SelectedText = Clipboard.GetText();
      tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
    }

    private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      MessageBox.Show(this, message, title, buttons);
    }

    private string Translate(string index)
    {
      string result = string.Empty;
      switch (_currentLanguage.ToLower())
      {
        case "english":
          result = _languageDicoEn.ContainsKey(index) ? _languageDicoEn[index] :
           "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
        case "french":
          result = _languageDicoFr.ContainsKey(index) ? _languageDicoFr[index] :
            "the term: \"" + index + "\" has not been translated yet.\nPlease tell the developer to translate this term";
          break;
      }

      return result;
    }

    private static Control FindFocusedControl(Control container)
    {
      foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
      {
        return childControl;
      }

      return (from Control childControl in container.Controls
              select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
    }

    private static Control FindFocusedControl(IEnumerable<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static Control FindFocusedControl(List<Control> container)
    {
      return container.FirstOrDefault(control => control.Focused);
    }

    private static string ChooseDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      SmallToolStripMenuItem.Checked = true;
      _fontSize = 10f;
      AdjustAllControls();
    }

    private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      MediumToolStripMenuItem.Checked = true;
      _fontSize = 11f;
      AdjustAllControls();
    }

    private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UncheckAllOptions();
      LargeToolStripMenuItem.Checked = true;
      _fontSize = 12f;
      AdjustAllControls();
    }

    private void AdjustControls(params Control[] listOfControls)
    {
      if (listOfControls.Length == 0)
      {
        return;
      }

      int position = listOfControls[0].Width + 33; // 33 is the initial padding
      bool isFirstControl = true;
      foreach (Control control in listOfControls)
      {
        if (isFirstControl)
        {
          if (_fontSize == 0f)
          {
            _fontSize = GetFontSize();
          }

          control.Font = new Font(new FontFamily("Verdana"), _fontSize);
          isFirstControl = false;
        }
        else
        {
          if (_fontSize == 0f)
          {
            _fontSize = GetFontSize();
          }

          control.Left = position + 25;
          position += control.Width + 10;
          control.Font = new Font(new FontFamily("Verdana"), _fontSize);
        }
      }
    }

    private float GetFontSize()
    {
      if (SmallToolStripMenuItem.Checked)
      {
        return 10f;
      }

      if (MediumToolStripMenuItem.Checked)
      {
        return 11f;
      }

      if (LargeToolStripMenuItem.Checked)
      {
        return 12f;
      }

      return 10f;
    }

    private void AdjustAllControls()
    {
      // Tab 0
      AdjustControls(labelChooseLanguage, comboBoxLanguage, buttonCountWords, buttonClear);
      AdjustControls(labelDocTitle, textBoxDocTitle);
      AdjustControls(labelWordsCount, labelCharacterCount);
      AdjustControlsTextBased(textBoxSource);
      // Tab 1
      AdjustControls(labelStatChooseLanguage, comboBoxStatChooseLanguage, buttonStatLoadResult, buttonClearResults);
      AdjustControls(labelAvailableLanguage);
      AdjustControlsTextBased(listBoxStatResult);
    }

    private void AdjustControlsTextBased(Control textBox)
    {
      if (_fontSize == 0f)
      {
        _fontSize = GetFontSize();
      }

      textBox.Font = new Font(new FontFamily("Verdana"), _fontSize);
    }

    private void buttonCountWords_Click(object sender, EventArgs e)
    {
      if (textBoxSource.Text == string.Empty)
      {
        DisplayMessage(Translate("No text has been found"), Translate("No Text"),
        MessageBoxButtons.OK);
        return;
      }

      int[] count = CountLetters(textBoxSource.Text);

#if debug
      int[] count2 = CountLetters2(textBoxSource.Text);
      //MessageBox.Show("Do CountLetters and CountLMetters2 bring the same result: " + (count == count2));
#endif
      if (comboBoxLanguage.SelectedIndex == -1)
      {
        comboBoxLanguage.SelectedIndex = 0;
      }

      var oneLetterFrequency = new LetterFrequency(comboBoxLanguage.SelectedItem.ToString(),
        textBoxDocTitle.Text);
      oneLetterFrequency.FeedLetters(count);
      oneLetterFrequency.AddHash(textBoxSource.Text);
      SaveToXml(oneLetterFrequency);

      MessageBox.Show("Letters frequencies from the text has been added.");
    }

    private static void SaveToXml(LetterFrequency letterFrequency)
    {
      if (!File.Exists(Settings.Default.LanguagePerCountryFileName))
      {
        string minimumText = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>" + Environment.NewLine +
          "<LetterFrequencies>" + Environment.NewLine + "</LetterFrequencies>";
        CreateXmlFile(Settings.Default.LanguagePerCountryFileName, minimumText);
      }

      XmlDocument doc = new XmlDocument();
      doc.Load(Settings.Default.LetterCountPerLanguageFileName);
      XmlNode root = doc.DocumentElement;
      XmlElement newLetterFrequency = doc.CreateElement("LetterFrequency");
      XmlElement newLanguage = doc.CreateElement("Language");
      newLanguage.InnerText = letterFrequency.Language;
      XmlElement newFileHash = doc.CreateElement("FileHash");
      newFileHash.InnerText = letterFrequency.FileHash.ToString();

      XmlElement newDocName = doc.CreateElement("DocName");
      newDocName.InnerText = letterFrequency.DocName;

      XmlElement newDateTime = doc.CreateElement("DateTime");
      newDateTime.InnerText = letterFrequency.DateTimeProcessed.ToString(CultureInfo.CurrentCulture);
      XmlElement newLetterA = doc.CreateElement("LetterA");
      newLetterA.InnerText = letterFrequency.LetterA.ToString();
      XmlElement newLetterB = doc.CreateElement("LetterB");
      newLetterB.InnerText = letterFrequency.LetterB.ToString();
      XmlElement newLetterC = doc.CreateElement("LetterC");
      newLetterC.InnerText = letterFrequency.LetterC.ToString();
      XmlElement newLetterD = doc.CreateElement("LetterD");
      newLetterD.InnerText = letterFrequency.LetterD.ToString();
      XmlElement newLetterE = doc.CreateElement("LetterE");
      newLetterE.InnerText = letterFrequency.LetterE.ToString();
      XmlElement newLetterF = doc.CreateElement("LetterF");
      newLetterF.InnerText = letterFrequency.LetterF.ToString();
      XmlElement newLetterG = doc.CreateElement("LetterG");
      newLetterG.InnerText = letterFrequency.LetterG.ToString();
      XmlElement newLetterH = doc.CreateElement("LetterH");
      newLetterH.InnerText = letterFrequency.LetterH.ToString();
      XmlElement newLetterI = doc.CreateElement("LetterI");
      newLetterI.InnerText = letterFrequency.LetterI.ToString();
      XmlElement newLetterJ = doc.CreateElement("LetterJ");
      newLetterJ.InnerText = letterFrequency.LetterJ.ToString();
      XmlElement newLetterK = doc.CreateElement("LetterK");
      newLetterK.InnerText = letterFrequency.LetterK.ToString();
      XmlElement newLetterL = doc.CreateElement("LetterL");
      newLetterL.InnerText = letterFrequency.LetterL.ToString();
      XmlElement newLetterM = doc.CreateElement("LetterM");
      newLetterM.InnerText = letterFrequency.LetterM.ToString();
      XmlElement newLetterN = doc.CreateElement("LetterN");
      newLetterN.InnerText = letterFrequency.LetterN.ToString();
      XmlElement newLetterO = doc.CreateElement("LetterO");
      newLetterO.InnerText = letterFrequency.LetterO.ToString();
      XmlElement newLetterP = doc.CreateElement("LetterP");
      newLetterP.InnerText = letterFrequency.LetterP.ToString();
      XmlElement newLetterQ = doc.CreateElement("LetterQ");
      newLetterQ.InnerText = letterFrequency.LetterQ.ToString();
      XmlElement newLetterR = doc.CreateElement("LetterR");
      newLetterR.InnerText = letterFrequency.LetterR.ToString();
      XmlElement newLetterS = doc.CreateElement("LetterS");
      newLetterS.InnerText = letterFrequency.LetterS.ToString();
      XmlElement newLetterT = doc.CreateElement("LetterT");
      newLetterT.InnerText = letterFrequency.LetterT.ToString();
      XmlElement newLetterU = doc.CreateElement("LetterU");
      newLetterU.InnerText = letterFrequency.LetterU.ToString();
      XmlElement newLetterV = doc.CreateElement("LetterV");
      newLetterV.InnerText = letterFrequency.LetterV.ToString();
      XmlElement newLetterW = doc.CreateElement("LetterW");
      newLetterW.InnerText = letterFrequency.LetterW.ToString();
      XmlElement newLetterX = doc.CreateElement("LetterX");
      newLetterX.InnerText = letterFrequency.LetterX.ToString();
      XmlElement newLetterY = doc.CreateElement("LetterY");
      newLetterY.InnerText = letterFrequency.LetterY.ToString();
      XmlElement newLetterZ = doc.CreateElement("LetterZ");
      newLetterZ.InnerText = letterFrequency.LetterZ.ToString();

      newLetterFrequency.AppendChild(newLanguage);
      newLetterFrequency.AppendChild(newFileHash);
      newLetterFrequency.AppendChild(newDocName);
      newLetterFrequency.AppendChild(newDateTime);
      newLetterFrequency.AppendChild(newLetterA);
      newLetterFrequency.AppendChild(newLetterB);
      newLetterFrequency.AppendChild(newLetterC);
      newLetterFrequency.AppendChild(newLetterD);
      newLetterFrequency.AppendChild(newLetterE);
      newLetterFrequency.AppendChild(newLetterF);
      newLetterFrequency.AppendChild(newLetterG);
      newLetterFrequency.AppendChild(newLetterH);
      newLetterFrequency.AppendChild(newLetterI);
      newLetterFrequency.AppendChild(newLetterJ);
      newLetterFrequency.AppendChild(newLetterK);
      newLetterFrequency.AppendChild(newLetterL);
      newLetterFrequency.AppendChild(newLetterM);
      newLetterFrequency.AppendChild(newLetterN);
      newLetterFrequency.AppendChild(newLetterO);
      newLetterFrequency.AppendChild(newLetterP);
      newLetterFrequency.AppendChild(newLetterQ);
      newLetterFrequency.AppendChild(newLetterR);
      newLetterFrequency.AppendChild(newLetterS);
      newLetterFrequency.AppendChild(newLetterT);
      newLetterFrequency.AppendChild(newLetterU);
      newLetterFrequency.AppendChild(newLetterV);
      newLetterFrequency.AppendChild(newLetterW);
      newLetterFrequency.AppendChild(newLetterX);
      newLetterFrequency.AppendChild(newLetterY);
      newLetterFrequency.AppendChild(newLetterZ);

      if (root != null) root.AppendChild(newLetterFrequency);
      doc.Save(Settings.Default.LetterCountPerLanguageFileName);
    }

    private static void CreateXmlFile(string fileName, string minimumText)
    {
      StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);
      sw.WriteLine(minimumText);
      sw.Close();
    }

    private static int[] CountLetters2(string text)
    {
      var resultTmp = new int[399];
      foreach (char letter in text)
      {
        if (char.IsLetter(letter))
        {
          resultTmp[letter]++;
        }
      }

      var result = new int[27];
      for (int i = 1; i < 27; i++)
      {
        // ASCII code table
        // A = 65
        // Z = 90
        // a = 97
        // z = 122
        result[i] = resultTmp[i + 64] + resultTmp[i + 96];
      }

      return result;
    }

    private static int[] CountLetters(string text)
    {
      var result = new int[27]; // result[1] counts a
      foreach (char letter in text)
      {
        if (char.IsLetter(letter)) // exclude numerics, special char
        {
          char letterTmp = letter.ToString().ToLower().ToCharArray()[0];
          if ((letterTmp >= 97) && letterTmp <= 122) // exclude accented letters
          {
            result[letterTmp - 96]++;
          }
        }
      }

      return result;
    }

    public static Dictionary<char, int> CountLettersToDicoDictionary(string myString, bool wholeDictionary = true)
    {
      var input = myString.ToLower();
      var result = new Dictionary<char, int>();
      if (wholeDictionary)
      {
        for (char i = 'a'; i <= 'z'; i++)
        {
          result.Add(i, 0);
        }
      }

      for (int i = 0; i <= input.Length - 1; i++)
      {
        if (result.ContainsKey(input[i]))
        {
          result[input[i]]++;
        }
        else
        {
          if (char.IsLetter(input[i]))
          {
            if (!wholeDictionary)
            {
              result.Add(input[i], 1);
            }
            else
            {
              result[input[i]]++;
            }

          }
        }
      }

      return result;
    }

    public static int CountWords(string input)
    {
      return input == string.Empty ? 0 : input.Split(' ').Length;
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
      textBoxSource.Text = string.Empty;
      buttonClear.Enabled = false;
    }

    private void textBoxSource_TextChanged(object sender, EventArgs e)
    {
      buttonClear.Enabled = textBoxSource.Text != string.Empty;
      labelWordsCount.Text = Translate("Number of words") +
        Punctuation.SpaceIfFrench(_currentLanguage) +
        Punctuation.Colon + Punctuation.OneSpace + CountWords(textBoxSource.Text);
      labelCharacterCount.Text = Translate("Number of characters") +
        Punctuation.SpaceIfFrench(_currentLanguage) +
        Punctuation.Colon + Punctuation.OneSpace + CountCharacters(textBoxSource.Text);
    }

    private static int CountCharacters(string text)
    {
      return text.Length;
    }

    public static LetterFrequencyList LoadFromXml(string filePath)
    {
      if (!File.Exists(filePath))
      {
        CreateFile(filePath);
      }

      var deserializer = new XmlSerializer(typeof(LetterFrequencyList));
      TextReader reader = new StreamReader(filePath);
      object obj = deserializer.Deserialize(reader);
      LetterFrequencyList xmlData = (LetterFrequencyList)obj;
      reader.Close();
      return xmlData;
    }

    private void buttonStatLoadResult_Click(object sender, EventArgs e)
    {
      if (comboBoxStatChooseLanguage.SelectedIndex == -1)
      {
        DisplayMessage(Translate("You haven't choose a language"), Translate("No Language choosen"), MessageBoxButtons.OK);
        comboBoxStatChooseLanguage.Focus();
        return;
      }

      dataGridViewStatResult.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
      dataGridViewStatResult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
      dataGridViewStatResult.ColumnHeadersDefaultCellStyle.Font =
          new Font(dataGridViewStatResult.Font, FontStyle.Bold);
      dataGridViewStatResult.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
      dataGridViewStatResult.ColumnHeadersBorderStyle =
          DataGridViewHeaderBorderStyle.Single;
      dataGridViewStatResult.CellBorderStyle = DataGridViewCellBorderStyle.Single;
      dataGridViewStatResult.GridColor = Color.Black;
      dataGridViewStatResult.RowHeadersVisible = true;
      dataGridViewStatResult.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
      dataGridViewStatResult.MultiSelect = false;

      listBoxStatResult.Items.Clear();

      // deserialize the xml file into class intances
      LetterFrequencyList statistics = LoadFromXml(Settings.Default.LetterCountPerLanguageFileName);
      var letterFrequencyDictionary = new Dictionary<char, int>();
      for (char letter = 'A'; letter <= 'Z'; letter++)
      {
        letterFrequencyDictionary.Add(letter, 0);
      }

      foreach (LetterFrequency frequency in statistics.LetterFrequencies)
      {
        if (!listBoxStatResult.Items.Contains(frequency.Language))
        {
          listBoxStatResult.Items.Add(frequency.Language);
        }

        if (frequency.Language != comboBoxStatChooseLanguage.SelectedItem.ToString()) continue;
        letterFrequencyDictionary['A'] += frequency.LetterA;
        letterFrequencyDictionary['B'] += frequency.LetterB;
        letterFrequencyDictionary['C'] += frequency.LetterC;
        letterFrequencyDictionary['D'] += frequency.LetterD;
        letterFrequencyDictionary['E'] += frequency.LetterE;
        letterFrequencyDictionary['F'] += frequency.LetterF;
        letterFrequencyDictionary['G'] += frequency.LetterG;
        letterFrequencyDictionary['H'] += frequency.LetterH;
        letterFrequencyDictionary['I'] += frequency.LetterI;
        letterFrequencyDictionary['J'] += frequency.LetterJ;
        letterFrequencyDictionary['K'] += frequency.LetterK;
        letterFrequencyDictionary['L'] += frequency.LetterL;
        letterFrequencyDictionary['M'] += frequency.LetterM;
        letterFrequencyDictionary['N'] += frequency.LetterN;
        letterFrequencyDictionary['O'] += frequency.LetterO;
        letterFrequencyDictionary['P'] += frequency.LetterP;
        letterFrequencyDictionary['Q'] += frequency.LetterQ;
        letterFrequencyDictionary['R'] += frequency.LetterR;
        letterFrequencyDictionary['S'] += frequency.LetterS;
        letterFrequencyDictionary['T'] += frequency.LetterT;
        letterFrequencyDictionary['U'] += frequency.LetterU;
        letterFrequencyDictionary['V'] += frequency.LetterV;
        letterFrequencyDictionary['W'] += frequency.LetterW;
        letterFrequencyDictionary['X'] += frequency.LetterX;
        letterFrequencyDictionary['Y'] += frequency.LetterY;
        letterFrequencyDictionary['Z'] += frequency.LetterZ;
      }

      object[] rowA = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "A", letterFrequencyDictionary['A'] };
      object[] rowB = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "B", letterFrequencyDictionary['B'] };
      object[] rowC = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "C", letterFrequencyDictionary['C'] };
      object[] rowD = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "D", letterFrequencyDictionary['D'] };
      object[] rowE = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "E", letterFrequencyDictionary['E'] };
      object[] rowF = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "F", letterFrequencyDictionary['F'] };
      object[] rowG = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "G", letterFrequencyDictionary['G'] };
      object[] rowH = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "H", letterFrequencyDictionary['H'] };
      object[] rowI = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "I", letterFrequencyDictionary['I'] };
      object[] rowJ = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "J", letterFrequencyDictionary['J'] };
      object[] rowK = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "K", letterFrequencyDictionary['K'] };
      object[] rowL = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "L", letterFrequencyDictionary['L'] };
      object[] rowM = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "M", letterFrequencyDictionary['M'] };
      object[] rowN = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "N", letterFrequencyDictionary['N'] };
      object[] rowO = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "O", letterFrequencyDictionary['O'] };
      object[] rowP = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "P", letterFrequencyDictionary['P'] };
      object[] rowQ = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "Q", letterFrequencyDictionary['Q'] };
      object[] rowR = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "R", letterFrequencyDictionary['R'] };
      object[] rowS = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "S", letterFrequencyDictionary['S'] };
      object[] rowT = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "T", letterFrequencyDictionary['T'] };
      object[] rowU = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "U", letterFrequencyDictionary['U'] };
      object[] rowV = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "V", letterFrequencyDictionary['V'] };
      object[] rowW = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "W", letterFrequencyDictionary['W'] };
      object[] rowX = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "X", letterFrequencyDictionary['X'] };
      object[] rowY = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "Y", letterFrequencyDictionary['Y'] };
      object[] rowZ = { comboBoxStatChooseLanguage.SelectedItem.ToString(), "Z", letterFrequencyDictionary['Z'] };

      dataGridViewStatResult.Rows.Add(rowA);
      dataGridViewStatResult.Rows.Add(rowB);
      dataGridViewStatResult.Rows.Add(rowC);
      dataGridViewStatResult.Rows.Add(rowD);
      dataGridViewStatResult.Rows.Add(rowE);
      dataGridViewStatResult.Rows.Add(rowF);
      dataGridViewStatResult.Rows.Add(rowG);
      dataGridViewStatResult.Rows.Add(rowH);
      dataGridViewStatResult.Rows.Add(rowI);
      dataGridViewStatResult.Rows.Add(rowJ);
      dataGridViewStatResult.Rows.Add(rowK);
      dataGridViewStatResult.Rows.Add(rowL);
      dataGridViewStatResult.Rows.Add(rowM);
      dataGridViewStatResult.Rows.Add(rowN);
      dataGridViewStatResult.Rows.Add(rowO);
      dataGridViewStatResult.Rows.Add(rowP);
      dataGridViewStatResult.Rows.Add(rowQ);
      dataGridViewStatResult.Rows.Add(rowR);
      dataGridViewStatResult.Rows.Add(rowS);
      dataGridViewStatResult.Rows.Add(rowT);
      dataGridViewStatResult.Rows.Add(rowU);
      dataGridViewStatResult.Rows.Add(rowV);
      dataGridViewStatResult.Rows.Add(rowW);
      dataGridViewStatResult.Rows.Add(rowX);
      dataGridViewStatResult.Rows.Add(rowY);
      dataGridViewStatResult.Rows.Add(rowZ);
    }

    private void buttonClearResults_Click(object sender, EventArgs e)
    {
      dataGridViewStatResult.Rows.Clear();
    }
  }
}
