using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using CSCodeGen.UI.Ui;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        #region Variabeln
        private BindingList<Template> templates;
        private Dictionary<TabPage, Template> tabs = new Dictionary<TabPage, Template>();
        private Template currentTemplate;

        #endregion
        public TemplateDesignerForm()
        {
            InitializeComponent();
            Init();
        }

        #region Methoden

        private void Init()
        {
            // Datasource binding
            templates = CoreGlobals.Instance.templateController.Templates;
            bsTemplates.DataSource = templates;

            //Events
            tcMain.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            gvKeywords.CellClick += gvKeywords_CellClick;

        }



        private void Save()
        {
            if (currentTemplate == null) return;


            if (currentTemplate.IsChanged)
            {
                CoreGlobals.Instance.templateController.SaveTemplate(currentTemplate);
                currentTemplate = null;
            }
        }
        private void AddNewTap()
        {
            TabPage tabPage = new TabPage(currentTemplate.Name);
            ucTemplateEditor ucEditor = new ucTemplateEditor(currentTemplate);
            ucEditor.OnClosingTap += UcEditor_OnClosingTap;
            ucEditor.OnSaveChanges += () => Save();

            tabs[tabPage] = currentTemplate;

            tabPage.Controls.Add(ucEditor);
            tcMain.TabPages.Add(tabPage);

            tcMain.SelectedTab = tabPage;

        }




        #endregion

        #region Events

        private void gvKeywords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
            {
                return;
            }

            var selectedKeyword = (Keyword)gvKeywords.Rows[e.RowIndex].DataBoundItem;

            if (selectedKeyword == null) { return; }

            // Überprüfe, ob die geklickte Zelle zur Button-Spalte gehört
            if (gvKeywords.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                KeywordCodeForm keywordCodeForm = new KeywordCodeForm(selectedKeyword);
                keywordCodeForm.ShowDialog();

            }

        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab != null && tabs.ContainsKey(tcMain.SelectedTab))
            {
                Template currentTemplate = tabs[tcMain.SelectedTab];  // Hole das Template der ausgewählten TabPage
                SetPropertyGrid(currentTemplate);  // Übergib das Template an die Methode
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentTemplate == null)
            {
                MessageBox.Show("Bitte zuerst ein Template erstellen oder auswählen.");
                return;
            }


            Keyword newkeyword = currentTemplate.Keywords.AddNew();

            gvKeywords.Refresh(); // Grid aktualisieren

        }
        private void neuesTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template { Name = "Neues Template" };

            AddNewTap();
            SetPropertyGrid(currentTemplate);

        }
        private void UcEditor_OnClosingTap(TabPage tabPage)
        {
            if (tabPage == null)
            {
                return;
            }

            // Jetzt die TabPage entfernen
            tcMain.TabPages.Remove(tabPage);

            if (tcMain.TabPages.Count > 0)
            {
                tcMain.SelectedTab = tcMain.TabPages[tcMain.TabPages.Count - 1];  // Setze den ersten Tab als aktiv
            }

            pgTemplate.SelectedObject = null;
            gvKeywords.DataSource = null;

        }
        private void SetPropertyGrid(Template template)
        {
            pgTemplate.SelectedObject = template;
            gvKeywords.DataSource = template.Keywords;
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listTemplate.SelectedItem == null) return;

            currentTemplate = (Template)listTemplate.SelectedItem;
            AddNewTap();
            SetPropertyGrid(currentTemplate);
        }
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void TemplateDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (templates == null) return;

            int nichtgespeichert = 0;
            foreach (Template template in templates)
            {
                if (template.IsChanged)
                {
                    nichtgespeichert++;
                }
            }

            if (nichtgespeichert > 0)
            {
                DialogResult result = MessageBox.Show(
               "Änderungen speichern?",
               "Speichern",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question
           );

                if (result == DialogResult.Yes)
                {
                    Save();
                }

            }

        }
        private void allesSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoreGlobals.Instance.templateController.SaveAllTemplates();
        }
        #endregion
    }

}


