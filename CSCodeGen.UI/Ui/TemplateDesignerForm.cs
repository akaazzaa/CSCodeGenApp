
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

            //Type.DataSource = Enum.GetValues(typeof(DataType)); // Alle Enum-Werte
            //Type.ValueType = typeof(DataType);
            //Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //gvKeywords.CellValueChanged += GvKeywords_CellChanged;

        }

        #region Form Events
        private void OnKeywordChanged()
        {
            GetSelectedTemplate().MarkAsChanged();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll?.Invoke(this, EventArgs.Empty);
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

            args.Keyword = (Textbaustein)gvKeywords.CurrentRow.DataBoundItem;

            args.Template = GetSelectedTemplate();

            RemoveKeyword?.Invoke(this, args);

        }
        private void gvKeywords_DoubleClick(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == null) { return; }

            var currentTemplate = tabs[tcMain.SelectedTab];

            var args = new TemplateEventArgs();

            args.Template = currentTemplate;

            KeywordAdd keywordAdd = new KeywordAdd(args);

            if (keywordAdd.ShowDialog() == DialogResult.Cancel)
            {
               
            }
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
            bsPlatzhalter.DataSource = currentTemplate.Textbausteine;
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
            bsPlatzhalter.DataSource = null;

        }
        private Template GetSelectedTemplate()
        {
            return listTemplate.SelectedItem as Template;
        }
        #endregion



        
    }

}


