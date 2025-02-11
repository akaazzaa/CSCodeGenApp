using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using CSCodeGen.UI.Usercontrols;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        private BindingList<Template> _templates;
        private Template currentTemplate;
        private Keyword currentKeyword;


        public TemplateDesignerForm()
        {
            InitializeComponent();



            // Templates aus dem Controller laden
            _templates = CoreGlobals.Instance.templateController.Templates;
            templateBindingSource.DataSource = _templates;

            // Auswahl-Änderung im ListBox-Event
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Neues Keyword zum aktuellen Template hinzufügen
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentTemplate == null)
            {
                MessageBox.Show("Bitte zuerst ein Template erstellen oder auswählen.");
                return;
            }

            currentKeyword = new Keyword();
            currentTemplate.Keywords.Add(currentKeyword);
            dataGridView1.Refresh(); // Grid aktualisieren
        }

        // Neues Template erstellen
        private void neuesTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template { Name = "Neues Template" };
            _templates.Add(currentTemplate); // Template zur Liste hinzufügen
            CreateNewEditorPage(currentTemplate.Name);
            SetPropertyGrid(currentTemplate);

        }

        // Editor-Tab für das Template erstellen
        private void CreateNewEditorPage(string pageName)
        {
            ucEditor ucEditor = new ucEditor(currentTemplate.Source);
            TabPage tabPage = new TabPage(pageName);
            tabPage.Controls.Add(ucEditor);
            tabControl1.TabPages.Add(tabPage);
        }

        // Eigenschaften & Keywords-Grid aktualisieren
        private void SetPropertyGrid(Template template)
        {
            propertyGrid1.SelectedObject = template;
            dataGridView1.DataSource = template.Keywords;
        }

        // Auswahl eines Templates per Doppelklick in der ListBox
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            currentTemplate = (Template)listBox1.SelectedItem;
            CreateNewEditorPage(currentTemplate.Name);
            SetPropertyGrid(currentTemplate);
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentTemplate == null)
            {
                MessageBox.Show("Bitte zuerst ein Template erstellen oder auswählen.");
                return;
            }

            CoreGlobals.Instance.templateController.SaveTemplate(currentTemplate);
        }
    }

}


