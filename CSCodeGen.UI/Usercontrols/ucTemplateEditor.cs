using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.UC;
using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        private Template currentTemplate;
        private ucEditor ucEditor;

        public event EventHandler<TabPage> OnClosingTap;
        public event EventHandler<Template> OnSaveChanges;
        public event EventHandler<Template> OnResetChanges;
        public event EventHandler<string> OnCodeChanged;
    
        public ucTemplateEditor(Template template)
        {
            InitializeComponent();
            currentTemplate = template;
            Initialize();
        }

        private void Initialize()
        {
            ucEditor = new ucEditor();
            ucEditor.Dock = DockStyle.Fill;
            pnlEditor.Controls.Add(ucEditor);

            btnRemove.Click += (s, e) => CloseTab();

            ucEditor.ShowContent(currentTemplate);

            ucEditor.CodeChanged += (s, newCode) =>
            {
               currentTemplate.Content = newCode;
               OnCodeChanged?.Invoke(this, newCode); // Weiterleitung an die Form
            };
        }

        #region Events

        private void CloseTab()
        {
            this.Validate();

            if (currentTemplate.IsChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Änderungen speichern?", "Speichern",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                    SaveChanges();
                else if (result == DialogResult.No)
                    ResetChanges();
            }

            OnClosingTap?.Invoke(this,this.Parent as TabPage);
        }

        private void ResetChanges()
        {
            OnResetChanges?.Invoke(this,currentTemplate);
        }

        private void SaveChanges()
        {
            OnSaveChanges?.Invoke(this, currentTemplate);
        }
        #endregion



    }
}
