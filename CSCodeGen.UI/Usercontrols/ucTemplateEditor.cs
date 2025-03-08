using CSCodeGen.Model.Main;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        private ucEditor ucEditor;
        public event Action<TabPage> OnClosingTap;
        public event EventHandler<CodeTemplate> OnSaveChanges;
        public event Action OnResetChanges;
        public event EventHandler<string> OnCodeChanged;

        private CodeTemplate currentTemplate;

        public ucTemplateEditor(CodeTemplate template)
        {
            InitializeComponent();
            currentTemplate = template;
            ucEditor = new ucEditor(template);

            ucEditor.CodeChanged += (s, newCode) =>
            {
                currentTemplate.Source = newCode;
                OnCodeChanged?.Invoke(this, newCode); // Weiterleitung an die Form
            };

            ucEditor.Dock = DockStyle.Fill;
            pnlEditor.Controls.Add(ucEditor);

            btnRemove.Click += (s, e) => CloseTab();

        }

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
                    SaveChanges(currentTemplate);
                else if (result == DialogResult.No)
                    ResetChanges();
            }

            OnClosingTap?.Invoke(this.Parent as TabPage);
        }

        private void ResetChanges()
        {
            OnResetChanges?.Invoke();
        }

        private void SaveChanges(CodeTemplate template)
        {
            OnSaveChanges?.Invoke(this, template);
        }

       
    }
}
