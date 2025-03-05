using CSCodeGen.DataAccess.Model.Main;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        private ucEditor ucEditor;
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaveChanges;
        public event Action OnResetChanges;
        private CodeTemplate currentTemplate;
        private string alterCode;

        public ucTemplateEditor(CodeTemplate template)
        {
            InitializeComponent();


            currentTemplate = template;
            ucEditor = new ucEditor(template);
            ucEditor.CodeChanged += CodeChanged;
            ucEditor.Dock = DockStyle.Fill;
            pnlEditor.Controls.Add(ucEditor);
            btnRemove.Click += (s, e) => CloseTab();


        }

        private void CodeChanged(object sender, string newSource)
        {
            alterCode = currentTemplate.Source;


            currentTemplate.Source = newSource;


        }

        #region Methoden
        private void CloseTab()
        {
            this.Validate(); // Sicherstellen, dass alle Eingaben verarbeitet wurden

            if (currentTemplate.IsChanged) // Falls Änderungen vorhanden sind
            {
                DialogResult result = MessageBox.Show(
                    "Änderungen speichern?",
                    "Speichern",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SaveChanges(); // Speichern
                }
                else if (result == DialogResult.No)
                {
                    ResetChanges();
                }
            }

            OnClosingTap?.Invoke(this.Parent as TabPage);
        }

        private void ResetChanges()
        {

            OnResetChanges?.Invoke();
        }
        private void SaveChanges()
        {
            OnSaveChanges?.Invoke();
        }

        #endregion

    }
}
