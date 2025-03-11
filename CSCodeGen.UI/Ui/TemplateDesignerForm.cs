
using CSCodeGen.Model.Main;

using System;

using System.ComponentModel;

using System.Windows.Forms;
using CSCodeGen.UI.Usercontrols;
using System.Collections.Generic;
using System.Linq;
using CSCodeGen.Model.Args;
using CSCodeGen.UI.Ui;
using CSCodeGen.Model.Interfaces.View;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form, ICodeTemplateView
    {
        public event EventHandler LoadTemplates;
        public event EventHandler SaveAll;
        public event EventHandler<TemplateEventArgs> SaveTemplate;
        public event EventHandler<TemplateEventArgs> NewTemplate;
        public event EventHandler<TemplateEventArgs> AddKeyword;
        public event EventHandler<TemplateEventArgs> RemoveKeyword;

        private Dictionary<TabPage, Template> tabs = new Dictionary<TabPage, Template>();

        private TemplateEventArgs _args;

        public TemplateDesignerForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
            this.FormClosing += OnFormClosing;

            Type.DataSource = Enum.GetValues(typeof(KeywordType)); // Alle Enum-Werte
            Type.ValueType = typeof(KeywordType);
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        #region Form Events
        private void OnKeywordChanged()
        {
            GetSelectedTemplate().IsChanged = true;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll?.Invoke(this, EventArgs.Empty);
        }
        private void btnAddKeyword_Click(object sender, EventArgs e)
        {   
            if (tcMain.SelectedTab == null) { return; }
            TemplateEventArgs args = new TemplateEventArgs();
            args.Template = tabs[tcMain.SelectedTab];

            AddKeyword?.Invoke(this, args);
            gvKeywords.Refresh();
        }
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab != null && tabs.ContainsKey(tcMain.SelectedTab))
            {
                Template currentTemplate = tabs[tcMain.SelectedTab];  // Hole das Template der ausgewählten TabPage
                SetKeyWordsBindings(currentTemplate);
            }
        }
        private void btnRemovekeyword_Click(object sender, EventArgs e)
        {
            if (gvKeywords.CurrentRow == null) return;

            var args = new TemplateEventArgs();

            args.Keyword = (Keyword)gvKeywords.CurrentRow.DataBoundItem;

            args.Template = GetSelectedTemplate();

            RemoveKeyword?.Invoke(this, args);

        }
        private void listTemplate_DoubleClick(object sender, EventArgs e)
        {
            SetKeyWordsBindings(GetSelectedTemplate());
            AddNewTab(GetSelectedTemplate());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();

            Save(this, GetSelectedTemplate());
        }
        private void btnNeuesTemplate_Click(object sender, EventArgs e)
        {
            _args = new TemplateEventArgs();

            _args.Template = new Template("Neues Template");

            NewTemplate?.Invoke(this, _args);
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
                keywordCodeForm.KeywordChanged += OnKeywordChanged;
                keywordCodeForm.ShowDialog();
            }
        }
        #endregion

        #region Methods
       
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void ShowTemplates(BindingList<Template> templates)
        {
            bsTemplates.DataSource = templates;
        }
        private void SetKeyWordsBindings(Template currentTemplate)
        {
            bsKeywords.DataSource = currentTemplate.Keywords;
            pgTemplate.SelectedObject = listTemplate.SelectedItem;
        }
        private void AddNewTab(Template currentTemplate)
        {
            if (currentTemplate == null) return;

            // Prüfe, ob Template bereits geöffnet
            var existingTab = tabs.FirstOrDefault(x => x.Value == currentTemplate);
            if (existingTab.Key != null)
            {
                tcMain.SelectedTab = existingTab.Key;
                return;
            }


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
        private void ResetTextChanges(object sender, Template template)
        {

            if (template == null)
            {
                return;
            }
            template.Name = template.OldName;
            template.Keywords.Clear();
            template.IsChanged = false;
        }
        private void Save(object sender, Template template)
        {
            _args = new TemplateEventArgs();

            _args.Template = template;

            SaveTemplate?.Invoke(this, _args);
        }
        private void CloseTab(object sender, TabPage tabPage)
        {
            if (tabPage == null) return;

            tcMain.TabPages.Remove(tabPage);
            tabs.Remove(tabPage);

            if (tcMain.TabPages.Count > 0)
            {
                tcMain.SelectedTab = tcMain.TabPages[tcMain.TabPages.Count - 1];
            }

            pgTemplate.SelectedObject = null;
            bsKeywords.DataSource = null;

        }
        private Template GetSelectedTemplate()
        {
            return listTemplate.SelectedItem as Template;
        }
        #endregion

        
    }

}


