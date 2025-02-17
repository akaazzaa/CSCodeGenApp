using CSCodeGen.DataAccess.Model;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaveChanges;
        private bool textChanged = false;
        private Template Template;

        public ucTemplateEditor(Template template)
        {
            InitializeComponent();
            Template = template;
            ucEditor2.Initialize(template);
            ucEditor2.CodeChanged += UcEditor_CodeChanged;

            löschenToolStripMenuItem.Click += (s, e) => CloseTab();

        }
        private void UcEditor_CodeChanged(object sender, string newSource)
        {
            Template.Source = newSource;
            textChanged = true;
        }

        #region Methoden
        private void CloseTab()
        {
            if (textChanged) // Falls Änderungen vorhanden sind
            {
                DialogResult result = MessageBox.Show(
                    "Änderungen speichern?",
                    "Speichern",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Abbrechen, Tab bleibt offen
                }
            }

            OnClosingTap?.Invoke(this.Parent as TabPage);
        }

        private void SaveChanges()
        {
            OnSaveChanges?.Invoke();
        }

        #endregion



    }
}
