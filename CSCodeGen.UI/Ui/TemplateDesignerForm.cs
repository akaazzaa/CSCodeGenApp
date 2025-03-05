using CSCodeGen.DataAccess.Model.Main;
using CSCodeGen.Library.GlobalEvents;
using CSCodeGen.UI.Ui;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        #region Variabeln
        private Dictionary<TabPage, CodeTemplate> tabs = new Dictionary<TabPage, CodeTemplate>();


        #endregion

        public TemplateDesignerForm()
        {
            InitializeComponent();
            // Datasource binding
            Init();

        }

        #region Methoden

        private void Init()
        {
            templates = CoreGlobals.Instance.templateController.Templates;
            bsTemplates.DataSource = templates;
            //Events abonnieren
            tcMain.SelectedIndexChanged += SelectedTabChanged;
            gvKeywords.CellClick += OpenKeywordCode;
            gvKeywords.MouseWheel += Keyword_MouseWheelMove;
            btnAddKeyword.Click += AddKeyword;
            btnNeuesTemplate.Click += AddTemplate;
            listTemplate.DoubleClick += ChangeSelectedTemplate;
            btnSave.Click += (s, e) => Save();
            FormClosing += OnFormClosing;
            btnRemovekeyword.Click += RemoveKeyword;
        }
        private void Save()
        {

            try
            {
                if (!templates.Any(t => t.IsChanged)) return;

                this.Validate();
                CoreGlobals.Instance.templateController.SaveAllTemplates();

                // Optional: Erfolgsbenachrichtigung
                MessageBox.Show("Alle Templates erfolgreich gespeichert.",
                                "Speichern",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                // Optional: Logging
                // Logger.LogError(ex);
            }
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

            // Prüfe, ob Template bereits geöffnet
            var existingTab = tabs.FirstOrDefault(x => x.Value == currentTemplate).Key;
            if (existingTab != null)
            {
                tcMain.SelectedTab = existingTab;
                return;
            }

            Add();
            var tabPage = new TabPage(currentTemplate.Name)
            {
                ToolTipText = currentTemplate.Name
            };

            var editor = new ucTemplateEditor(currentTemplate)
            {
                Dock = DockStyle.Fill
            };

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
        private void SetPropertyGrid(CodeTemplate template)
        {
            pgTemplate.SelectedObject = template;
            gvKeywords.DataSource = template.Keywords;
        }

        #endregion

        #region Events
        private void Keyword_MouseWheelMove(object sender, MouseEventArgs e)
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
        private void OpenKeywordCode(object sender, DataGridViewCellEventArgs e)
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
        private void SelectedTabChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab != null && tabs.ContainsKey(tcMain.SelectedTab))
            {
                CodeTemplate currentTemplate = tabs[tcMain.SelectedTab];  // Hole das Template der ausgewählten TabPage
                SetPropertyGrid(currentTemplate);  // Übergib das Template an die Methode
            }
        }
        private void AddKeyword(object sender, EventArgs e)
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
        private void AddTemplate(object sender, EventArgs e)
        {
            currentTemplate = new CodeTemplate("Neues Template");

            AddNewTap();
            SetPropertyGrid(currentTemplate);

        }
        private void ChangeSelectedTemplate(object sender, EventArgs e)
        {
            if (listTemplate.SelectedItem == null) return;

            currentTemplate = (CodeTemplate)listTemplate.SelectedItem;
            AddNewTap();
            SetPropertyGrid(currentTemplate);
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            var changedTemplates = templates.Where(t => t.IsChanged).ToList();

            if (changedTemplates.Any())
            {
                var result = MessageBox.Show(
                    $"Es gibt {changedTemplates.Count} ungespeicherte Templates.\n" +
                    "Möchten Sie alle speichern?",
                    "Ungespeicherte Änderungen",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }

        }
        private void RemoveKeyword(object sender, EventArgs e)
        {
            if (gvKeywords.CurrentRow == null) return;

            var selectedKeyword = (Keyword)gvKeywords.CurrentRow.DataBoundItem;



            currentTemplate.Keywords.Remove(selectedKeyword);
            currentTemplate.IsChanged = true;
            PublicEvents.OnKeywordDeleted(selectedKeyword);
        }

        #endregion




        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }


    }

}


