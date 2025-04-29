
using CSCodeGen.Model;
using CSCodeGen.Library.Controller;
using FastColoredTextBoxNS;
using CSCodeGen.Model.Main;
using System.ComponentModel;
using CSCodeGen.Model.Interfaces.View;
using System.Drawing.Design;
using CSCodeGen.Model.Args;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form, IClassView
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();

        public event EventHandler? LoadTemplates;
        public event EventHandler<GeneratorEventArgs>? GenerateCode;

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
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var uiData = GetUserData();
            var args = new GeneratorEventArgs();
            args.ClassName = uiData.ClassName;
            args.Namespace = uiData.NameSpace;
            args.UserValues = uiData.UserValues;
            args.TemplateName = GetTemplateID();

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
        public void ShowText(string text)
        {
            fastColoredTextBox1.Text = text;
        }
        public void Show(BindingList<Template> templates)
        {
            templateBindingSource.DataSource = templates;
            bsDaten.DataSource = _UIData;

            ChangeCurrentObjekt();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private Template? GetSelectedTemplate()
        {
            if (cbTemplate.SelectedItem == null) { return null; }

            var template = (Template)cbTemplate.SelectedItem;

            return template;
        }

        private void ChangeCurrentObjekt()
        {
            var template = GetSelectedTemplate();

            if (template == null) { return; }

            ShowText(template.Content);

        }

        private string GetTemplateID()
        {
            var template = GetSelectedTemplate();
            if (template == null)
            {
                return string.Empty;
            }

            return template.Name;

        }

        private GeneratorUIData GetUserData()
        {
            var result = (GeneratorUIData)bsDaten.DataSource;

            return result;
        }
        #endregion


       
    }
}
