using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.DataAccess.Model.Klasse;
using CSCodeGen.DataAccess.Model.Main;
using CSCodeGen.Library.GlobalEvents;
using FastColoredTextBoxNS;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();
        private Klasse klasse = new Klasse();
        private Template currentTemplate;
        private string lastInput = "";
        public frmCodeGen()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            pnlEditorMain.Controls.Add(fastColoredTextBox1);
            fastColoredTextBox1.Dock = DockStyle.Fill;

            fastColoredTextBox1.Language = Language.CSharp;
            fastColoredTextBox1.AutoIndent = true;
            fastColoredTextBox1.AutoIndentChars = true;


            bsDaten.DataSource = CoreGlobals.Instance.templateController.Templates;
            klasseBindingSource.DataSource = klasse;
            bsProperties.DataSource = klasse.Properties;

            ChangeCurrentObjekt();
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
        private void btnPropertiesAdd_Click(object sender, EventArgs e)
        {
            klasse.Properties.Add(new Propertie());
        }
        private void btnPropertiesDelete_Click(object sender, EventArgs e)
        {
            var selectedPropertie = (Propertie)dataGridView1.CurrentRow.DataBoundItem;

            if (selectedPropertie == null) { return; }
            klasse.Properties.Remove(selectedPropertie);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            fastColoredTextBox1.Text = ReplaceKeywords(currentTemplate.Source);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = CoreGlobals.Instance.SaveCSPath;
            string fileName = "NewCSDatei.cs";
            string fullPath = Path.Combine(path, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(fullPath, fastColoredTextBox1.Text);

        }
    }
}
