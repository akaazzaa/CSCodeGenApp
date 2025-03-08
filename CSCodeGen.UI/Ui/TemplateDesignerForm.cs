
using CSCodeGen.Model.Main;
using CSCodeGen.Contracts.Interfaces;
using System;

using System.ComponentModel;

using System.Windows.Forms;
using CSCodeGen.UI.Usercontrols;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Linq;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form, ICodeTemplateView<CodeTemplate>
    {
        public event EventHandler LoadTemplates;
        public event EventHandler<CodeTemplate> SaveTemplate;
        public event EventHandler<CodeTemplate> NewTemplate;
        private Dictionary<TabPage, CodeTemplate> tabs = new Dictionary<TabPage, CodeTemplate>();

        public TemplateDesignerForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowTemplates(BindingList<CodeTemplate> templates)
        {
            bsTemplates.DataSource = templates;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(this,GetSelectedTemplate());
        }

        private void btnNeuesTemplate_Click(object sender, EventArgs e)
        {
            NewTemplate?.Invoke(this, new CodeTemplate("Neues Template"));
        }

        private void listTemplate_DoubleClick(object sender, EventArgs e)
        {
            bsKeywords.DataSource = GetSelectedTemplate().Keywords;
            pgTemplate.SelectedObject = listTemplate.SelectedItem;
            AddNewTap(GetSelectedTemplate());
        }
        private void AddNewTap(CodeTemplate currentTemplate)
        {
            if (currentTemplate == null) return;

            // Prüfe, ob Template bereits geöffnet
            var existingTab = tabs.FirstOrDefault(x => x.Value == currentTemplate).Key;
            if (existingTab != null)
            {
                tcMain.SelectedTab = existingTab;
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

        private void Save(object sender, CodeTemplate template)
        {
            SaveTemplate?.Invoke(this, template);
        }

        private void ResetTextChanges()
        {
            throw new NotImplementedException();
        }

        private void CloseTab(TabPage page)
        {
            throw new NotImplementedException();
        }
        private CodeTemplate GetSelectedTemplate()
        {
            return listTemplate.SelectedItem as CodeTemplate;
        }
    }

}


