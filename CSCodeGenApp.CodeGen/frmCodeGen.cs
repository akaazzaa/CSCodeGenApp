
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
            var args = new GeneratorEventArgs();
            var template = GetSelectedTemplate();
            var result = GetResult();
            if (template == null) { return; }


            args.Template = template;
            args.Result = result;

            GenerateCode?.Invoke(this, args);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var uv = new UserValue();

            bsUserValues.Add(uv);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            gvUserValues.Rows.Remove(gvUserValues.CurrentRow);
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
            bsDaten.DataSource = templates;
            bsResult.DataSource = new Result();

            ChangeCurrentObjekt();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private Template GetSelectedTemplate()
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
        private Result GetResult()
        {
            return (Result)bsResult.DataSource;
        }
        #endregion

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
    }
}
