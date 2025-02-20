using CSCodeGen.DataAccess.Model;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaveChanges;
        public event Action<Template> OnResetChanges;
        private Template oldTemplate;
        private Template Template;
        private string alterCode;

        public ucTemplateEditor(Template template)
        {
            InitializeComponent();
            // Todo: Copy vom Template.Proprertys  machen und in der Resetchange mitgeben. 
            oldTemplate = template;
            Template = template;
            ucEditor2.Initialize(template);
            ucEditor2.CodeChanged += UcEditor2_CodeChanged;
            löschenToolStripMenuItem.Click += (s, e) => CloseTab();


        }

        private void UcEditor2_CodeChanged(object sender, string newSource)
        {
            alterCode = Template.Source;

            Template.Source = newSource;

        }

        #region Methoden
        private void CloseTab()
        {
            this.Validate(); // Sicherstellen, dass alle Eingaben verarbeitet wurden

            if (Template.IsChanged) // Falls Änderungen vorhanden sind
            {
                DialogResult result = MessageBox.Show(
                    "Änderungen speichern?",
                    "Speichern",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SaveChanges(); // Speichern
                }
                else if (result == DialogResult.No)
                {
                    if (oldTemplate == null)
                    {
                        return;
                    }

                    OnResetChanges(oldTemplate);
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Abbruch, Tab bleibt offen
                }
            }

            OnClosingTap?.Invoke(this.Parent as TabPage);
        }

        private void ResetChanges(Template oldTemplate)
        {
            OnResetChanges?.Invoke(oldTemplate);
        }
        private void SaveChanges()
        {
            OnSaveChanges?.Invoke();
        }

        #endregion

    }
}
