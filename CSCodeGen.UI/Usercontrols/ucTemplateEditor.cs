using CSCodeGen.DataAccess.Model;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaveChanges;
        public event Action OnResetChanges;
        private Template currentTemplate;
        private string alterCode;

        public ucTemplateEditor(Template template)
        {
            InitializeComponent();
            // Todo: Copy vom Template.Proprertys  machen und in der Resetchange mitgeben. 
            currentTemplate = template;
            ucEditor2.Initialize(template);
            ucEditor2.CodeChanged += UcEditor2_CodeChanged;
            löschenToolStripMenuItem.Click += (s, e) => CloseTab();


        }

        private void UcEditor2_CodeChanged(object sender, string newSource)
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
