
using CSCodeGen.Model;
using CSCodeGen.Library.Controller;
using FastColoredTextBoxNS;
using CSCodeGen.Model.Main;
using System.ComponentModel;
using CSCodeGen.Model.Interfaces.View;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form , IClassView
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


            //bsDaten.DataSource = CoreGlobals.Instance.templateController.Templates;
            //klasseBindingSource.DataSource = classController.Klasse;
            //bsProperties.DataSource = classController.Klasse.Properties;

            ChangeCurrentObjekt();
        }

        private void OnLoad(object? sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
        private void btnPropertiesAdd_Click(object sender, EventArgs e)
        {
            
        }
        private void btnPropertiesDelete_Click(object sender, EventArgs e)
        {
            //var selectedPropertie = (PropertyDefinition)dataGridView1.CurrentRow.DataBoundItem;

            //if (selectedPropertie == null) { return; }
            //classController.RemoveProperty(selectedPropertie);
        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //fastColoredTextBox1.Text = classController.ReplaceKeywords(currentTemplate);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void ChangeCurrentObjekt()
        {
            if (cbTemplate.SelectedItem == null) { return; }

            currentTemplate = (Template)cbTemplate.SelectedItem;

            fastColoredTextBox1.Text = currentTemplate.Source;

        }

        public void ShowTemplates(BindingList<Template> templates)
        {
           bsDaten.DataSource = templates;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
