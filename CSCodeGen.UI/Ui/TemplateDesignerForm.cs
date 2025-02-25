using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using CSCodeGen.UI.Ui;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        #region Variabeln
        private BindingList<Template> templates;
        private Dictionary<TabPage, Template> tabs = new Dictionary<TabPage, Template>();
        private Template currentTemplate;
        ucTemplateEditor ucTemplateEditor;


        #endregion

        #region Methoden
        private void Init()
        {
            // Datasource binding
            templates = CoreGlobals.Instance.templateController.Templates;
            bsTemplates.DataSource = templates;

            //Events
            tcMain.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            gvKeywords.CellClick += gvKeywords_CellClick;
            gvKeywords.MouseWheel += GvKeywords_MouseWheel;

        }
        private void Save()
        {
            if (!templates.Any(t => t.IsChanged)) return; // Nur speichern, wenn nötig
            this.Validate();
            CoreGlobals.Instance.templateController.SaveAllTemplates();
        }
        private void Add()
        {
            if (currentTemplate == null || templates.Contains(currentTemplate))
            {
                return;
            }

            templates.Add(currentTemplate);
        }
        private void CloseTab(TabPage tabPage)
        {
            if (tabPage == null) return;

            tcMain.TabPages.Remove(tabPage);
            tabs.Remove(tabPage);

            if (tcMain.TabPages.Count > 0)
            {
                tcMain.SelectedTab = tcMain.TabPages[tcMain.TabPages.Count - 1];
            }

            pgTemplate.SelectedObject = null;
            gvKeywords.DataSource = null;
            currentTemplate = null;

        }
        private void AddNewTap()
        {
            if (currentTemplate == null) return;

            Add();

            var tabPage = new TabPage(currentTemplate.Name);
            var editor = new ucTemplateEditor(currentTemplate);
            editor.Dock = DockStyle.Fill;
            editor.OnClosingTap += CloseTab;
            editor.OnSaveChanges += Save;
            editor.OnResetChanges += ResetTextChanges;


            tabs[tabPage] = currentTemplate;
            tabPage.Controls.Add(editor);
            tcMain.TabPages.Add(tabPage);
            tcMain.SelectedTab = tabPage;

        }
        private void ResetTextChanges()
        {
            if (currentTemplate == null)
            {
                return;
            }
            currentTemplate.Name = currentTemplate.OldName;
            currentTemplate.Keywords.Clear();
            currentTemplate.IsChanged = false;
        }
        private void SetPropertyGrid(Template template)
        {
            pgTemplate.SelectedObject = template;
            gvKeywords.DataSource = template.Keywords;
        }

        #endregion

        #region Events
        private void GvKeywords_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                if (gvKeywords.HorizontalScrollingOffset > 0 || e.Delta < 0)
                {
                    int newIndex = Math.Max(0, gvKeywords.HorizontalScrollingOffset - (e.Delta / 2));
                    gvKeywords.HorizontalScrollingOffset = Math.Max(0, newIndex);
                }
            }
            else
            {
                if (gvKeywords.RowCount > gvKeywords.DisplayedRowCount(false))
                {
                    int currentIndex = gvKeywords.FirstDisplayedScrollingRowIndex;
                    int scrollLines = SystemInformation.MouseWheelScrollLines;
                    int newIndex = Math.Max(0, currentIndex - (e.Delta / 120) * scrollLines);

                    gvKeywords.FirstDisplayedScrollingRowIndex = newIndex;
                }
            }
        }
        private void gvKeywords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var selectedKeyword = (Keyword)gvKeywords.Rows[e.RowIndex].DataBoundItem;

            if (selectedKeyword == null) { return; }

            // Überprüfe, ob die geklickte Zelle zur Button-Spalte gehört
            if (gvKeywords.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                KeywordCodeForm keywordCodeForm = new KeywordCodeForm(selectedKeyword);
                keywordCodeForm.KeywordChanged += KeywordChanged;
                keywordCodeForm.ShowDialog();
            }
        }

        private void KeywordChanged()
        {
            if (currentTemplate == null) { return; }

            currentTemplate.IsChanged = true;

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
            currentTemplate.IsChanged = true;
            gvKeywords.Refresh(); // Grid aktualisieren

        }
        private void neuesTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template("Neues Template");

            AddNewTap();
            SetPropertyGrid(currentTemplate);

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
            if (templates.Any(t => t.IsChanged))
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
        private void btnRemovekeyword_Click(object sender, EventArgs e)
        {
            if (gvKeywords.CurrentRow == null) return;

            var selectedKeyword = (Keyword)gvKeywords.CurrentRow.DataBoundItem;



            currentTemplate.Keywords.Remove(selectedKeyword);
            currentTemplate.IsChanged = true;
            PublicEvents.OnKeywordDeleted(selectedKeyword);
        }

        #endregion


        public TemplateDesignerForm()
        {
            InitializeComponent();
            Init();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {



            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }
    }

}


