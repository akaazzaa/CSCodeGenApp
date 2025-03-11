
using CSCodeGen.Model;
using CSCodeGen.Library.Controller;
using FastColoredTextBoxNS;
using CSCodeGen.Model.Main;
using System.ComponentModel;
using CSCodeGen.Model.Interfaces.View;
using System.Drawing.Design;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form, IClassView
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();
        private Template currentTemplate;

        public event EventHandler LoadTemplates;

        public frmCodeGen()
        {
            InitializeComponent();
            this.Load += OnLoad;

            pnlEditorMain.Controls.Add(fastColoredTextBox1);
            fastColoredTextBox1.Dock = DockStyle.Fill;

            fastColoredTextBox1.Language = Language.CSharp;
            fastColoredTextBox1.AutoIndent = true;
            fastColoredTextBox1.AutoIndentChars = true;


            //Type.DataSource = Enum.GetValues(typeof(KeywordType)); // Alle Enum-Werte
            //Type.ValueType = typeof(KeywordType);
            //Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }

        private void OnLoad(object? sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
        }


      
        private void ChangeCurrentObjekt()
        {
            if (cbTemplate.SelectedItem == null) { return; }

            currentTemplate = (Template)cbTemplate.SelectedItem;

            fastColoredTextBox1.Text = currentTemplate.Source;

            fastColoredTextBox1.Text = currentTemplate.ErsetzeKeywords();

        }

        public void ShowTemplates(BindingList<Template> templates)
        {
            bsDaten.DataSource = templates;
            ChangeCurrentObjekt();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

      

      
    }
}
