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
using CSCodeGen.Library.Controller;
using CSCodeGen.UI.UIKlassen;

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

        
        
        

        public TemplateDesignerForm()
        {
            InitializeComponent();
            Initialize();
        }
        #region Form Events
       
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
            if (tcMain.SelectedTab != null && TabPageHelper.GetTabs().ContainsKey(tcMain.SelectedTab))
            {
                Template currentTemplate = TabPageHelper.GetTabs()[tcMain.SelectedTab];  // Hole das Template der ausgewählten TabPage
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

            var currentTemplate = TabPageHelper.GetTabs()[tcMain.SelectedTab];

            var args = new TemplateEventArgs();

            args.Template = currentTemplate;

            frmTextBlockList keywordAdd = new frmTextBlockList(args);

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
            var args = new TemplateEventArgs();

            args.Template = new Template("Neues Template");

            NewTemplate?.Invoke(this, args);
        }

        #endregion

        #region Methods
        public void Initialize()
        {
            this.Load += OnLoad;
            this.FormClosing += OnFormClosing;

        }
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
            if (currentTemplate == null || TabPageHelper.GetTabs().ContainsValue(currentTemplate))
            {
                return;
            }
           
            var tabPage = TabPageHelper.CreateTabPage(currentTemplate);   
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
            var args = new TemplateEventArgs();

            args.Template = template;

            SaveTemplate?.Invoke(this, args);
        }
        private void CloseTab(object sender, TabPage tabPage)
        {
            if (tabPage == null) return;

            tcMain.TabPages.Remove(tabPage);
            TabPageHelper.GetTabs().Remove(tabPage);

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


