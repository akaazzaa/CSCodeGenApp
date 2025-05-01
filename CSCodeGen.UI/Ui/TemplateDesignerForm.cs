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
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public event EventHandler LoadTemplates;
        public event EventHandler SaveAll;
        public event EventHandler<TemplateEventArgs> SaveTemplate;
        public event EventHandler<TemplateEventArgs> NewTemplate;
        public event EventHandler<TemplateEventArgs> AddKeyword;
        public event EventHandler<TemplateEventArgs> RemoveKeyword;
        public event EventHandler<TemplateEventArgs> DeleteKeyword;

        public TemplateDesignerForm()
        {
            InitializeComponent();
            Initialize();
        }
        #region Form Events

        private void OnLoad(object sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
            listTemplate.SelectedIndex = -1;
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll?.Invoke(this, EventArgs.Empty);
        }
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsSelectedTabPageNull() || !TabPageHelper.DictonaryContaisTabPage(tcMain.SelectedTab)) return;

            var template = TabPageHelper.Tabs[tcMain.SelectedTab];
            listTemplate.SelectedItem = template;
            SetKeyWordsBindings(template);
        }
        private void gvKeywords_DoubleClick(object sender, EventArgs e)
        {
            if (IsSelectedTabPageNull()) return;

            var args = new TemplateEventArgs();

            args.Template = GetTemplateFromTap();

            OpenEditor(args);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();

            Save(this, GetSelectedTemplate());
        }
        private void btnNeuesTemplate_Click(object sender, EventArgs e)
        {
            var args = new TemplateEventArgs();

            args.Template = new Template();

            NewTemplate?.Invoke(this, args);
        }
        private void btnLöschen_Click(object sender, EventArgs e)
        {
            var args = new TemplateEventArgs();

            args.Template = GetSelectedTemplate();

            DeleteKeyword?.Invoke(sender, args);
        }

        private void listTemplate_Click(object sender, EventArgs e)
        {
            SetKeyWordsBindings(GetSelectedTemplate());
            AddNewTab(GetSelectedTemplate());
        }
        #endregion

        #region Methods
        public void Initialize()
        {
            this.Load += OnLoad;
            this.FormClosing += OnFormClosing;
        }

        public bool ShowMessagBox(string message, string caption)
        {
           var result =  MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            return result == DialogResult.Yes;

        }
        private void OpenEditor(TemplateEventArgs args)
        {
            frmTextBlockList textBlockList = new frmTextBlockList(args);
            textBlockList.ShowDialog();
        }
        private bool IsSelectedTabPageNull()
        {
            return tcMain.SelectedTab == null;
        }
        private Template GetTemplateFromTap()
        {
            return TabPageHelper.Tabs[tcMain.SelectedTab];
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
            pgTemplate.SelectedObject = currentTemplate;
        }
        private void AddNewTab(Template currentTemplate)
        {
            if (currentTemplate == null ) { return; }


            if (TabPageHelper.DictonaryContainsTemplate(currentTemplate))
            {
                tcMain.SelectedTab = TabPageHelper.Tabs.FirstOrDefault(x => x.Value == currentTemplate).Key;

            }else
            {
                var editor = new ucTemplateEditor(currentTemplate)
                {
                    Dock = DockStyle.Fill
                };

                editor.OnClosingTap += CloseTab;
                editor.OnSaveChanges += Save;
                editor.OnResetChanges += ResetTextChanges;

                var tabPage = TabPageHelper.CreateTabPage(currentTemplate, editor);
                tcMain.TabPages.Add(tabPage);
                tcMain.SelectedTab = tabPage;
            }
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
            TabPageHelper.Tabs.Remove(tabPage);

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


