using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using FastColoredTextBoxNS;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.Formatting;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form, IClassView
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();

        public event EventHandler? LoadTemplates;
        public event EventHandler<GeneratorEventArgs>? GenerateCode;
        public event EventHandler<GeneratorEventArgs>? Save;

        private GeneratorUIData _UIData = new GeneratorUIData();
        public frmCodeGen()
        {
            InitializeComponent();
            Initialize();
        }
        #region Events 
        private void OnLoad(object? sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog svd = new SaveFileDialog())
            {
                svd.Filter = "CS (*.cs)|*.cs|Alle Dateien (*.*)|*.*";
                svd.Title = "Speichern unter";
                svd.InitialDirectory = Globals.FolderPath;
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    var args = new GeneratorEventArgs();
                    args.ContentResult = fastColoredTextBox1.Text;
                    args.SavePath = svd.FileName;
                    Save?.Invoke(this, args);
                }

            }

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var uiData = GetUserData();
            var args = new GeneratorEventArgs();
            args.ClassName = uiData.ClassName;
            args.Namespace = uiData.NameSpace;
            args.UserValues = uiData.UserValues;
            args.TemplateName = GetTemplateName();

            GenerateCode?.Invoke(this, args);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var userValue = new UserValue();
            _UIData.UserValues.Add(userValue);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            gvUserValues.Rows.Remove(gvUserValues.CurrentRow);
        }
        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Formatiert den Code richtig
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string Format(string code)
        {
            using (var workspace = new AdhocWorkspace())
            {
                // Einrückungseinstellungen
                var workspaceOptions = workspace.Options

                     .WithChangedOption(FormattingOptions.IndentationSize, LanguageNames.CSharp, 4)
                     .WithChangedOption(FormattingOptions.TabSize, LanguageNames.CSharp, 4)
                     .WithChangedOption(FormattingOptions.UseTabs, LanguageNames.CSharp, false);

                workspaceOptions = workspaceOptions
                    .WithChangedOption(CSharpFormattingOptions.IndentBlock, true)
                    .WithChangedOption(CSharpFormattingOptions.IndentBraces, false);

                // Ein SyntaxTree aus dem Code erstellen
                var tree = CSharpSyntaxTree.ParseText(code);
                var root = tree.GetCompilationUnitRoot().NormalizeWhitespace();

                // Den Code formatieren
                var formattedDocument = Formatter.Format(root, workspace, workspaceOptions);


                // Das Ergebnis ausgeben
                string formattedCode = formattedDocument.ToString();
                return formattedCode;
            }

        }
        /// <summary>
        /// Initialisiert die Form und Events
        /// </summary>
        public void Initialize()
        {
            this.Load += OnLoad;
            pnlEditorMain.Controls.Add(fastColoredTextBox1);
            fastColoredTextBox1.Dock = DockStyle.Fill;

            fastColoredTextBox1.Language = Language.CSharp;
            fastColoredTextBox1.AutoIndent = true;
            fastColoredTextBox1.AutoIndentChars = true;

            gvcbType.DataSource = Enum.GetValues(typeof(DataType));
            gvcbType.ValueType = typeof(DataType);
            gvcbType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        /// <summary>
        /// Zeigt den Text in dem Editor an
        /// </summary>
        /// <param name="text"></param>
        public void ShowText(string text)
        {
            fastColoredTextBox1.Text = Format(text); ;
        }
        /// <summary>
        /// Datenbindung 
        /// </summary>
        /// <param name="templates"></param>
        public void Show(BindingList<Template> templates)
        {
            templateBindingSource.DataSource = templates;
            bsDaten.DataSource = _UIData;

            ChangeCurrentObjekt();
        }
        /// <summary>
        /// Zeigt eine MessageBox an 
        /// </summary>
        /// <param name="message"></param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        /// <summary>
        /// Gibt das ausgewählte Template zurück
        /// </summary>
        /// <returns></returns>
        private Template? GetSelectedTemplate()
        {
            if (cbTemplate.SelectedItem == null) { return null; }

            var template = (Template)cbTemplate.SelectedItem;

            return template;
        }
        /// <summary>
        /// Wechselt das Objekt und die Daten die angezeigt werden
        /// </summary>
        private void ChangeCurrentObjekt()
        {
            var template = GetSelectedTemplate();

            if (template == null) { return; }

            var uiData = GetUserData();
            var args = new GeneratorEventArgs();
            args.ClassName = uiData.ClassName;
            args.Namespace = uiData.NameSpace;
            args.UserValues = uiData.UserValues;
            args.TemplateName = GetTemplateName();

            GenerateCode?.Invoke(this, args);

        }
        /// <summary>
        /// Gibt den Templatenamen zurück
        /// </summary>
        /// <returns></returns>
        private string GetTemplateName()
        {
            var template = GetSelectedTemplate();
            if (template == null)
            {
                return string.Empty;
            }

            return template.Name;

        }
        /// <summary>
        /// Gibt die User eingabe zurück 
        /// </summary>
        /// <returns></returns>
        private GeneratorUIData GetUserData()
        {
            var result = (GeneratorUIData)bsDaten.DataSource;

            return result;
        }
        #endregion





        
    }
}
