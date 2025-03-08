
using CSCodeGen.Model;
using CSCodeGen.Library.Controller;
using FastColoredTextBoxNS;
using CSCodeGen.Model.Model;
using CSCodeGen.Model.Main;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();
        private ClassController classController;
        private CodeTemplate currentTemplate;

        public frmCodeGen()
        {
            InitializeComponent();

            // Controller für die Logik
            ////this.classController = classController;

            pnlEditorMain.Controls.Add(fastColoredTextBox1);
            fastColoredTextBox1.Dock = DockStyle.Fill;

            fastColoredTextBox1.Language = Language.CSharp;
            fastColoredTextBox1.AutoIndent = true;
            fastColoredTextBox1.AutoIndentChars = true;


            //bsDaten.DataSource = CoreGlobals.Instance.templateController.Templates;
            klasseBindingSource.DataSource = classController.Klasse;
            bsProperties.DataSource = classController.Klasse.Properties;

            ChangeCurrentObjekt();
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
        private void btnPropertiesAdd_Click(object sender, EventArgs e)
        {
            classController.AddProperty(new PropertyDefinition());
        }
        private void btnPropertiesDelete_Click(object sender, EventArgs e)
        {
            var selectedPropertie = (PropertyDefinition)dataGridView1.CurrentRow.DataBoundItem;

            if (selectedPropertie == null) { return; }
            classController.RemoveProperty(selectedPropertie);
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

            currentTemplate = (CodeTemplate)cbTemplate.SelectedItem;

            fastColoredTextBox1.Text = currentTemplate.Source;

        }
    }
}
