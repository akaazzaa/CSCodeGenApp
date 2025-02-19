using CSCodeGen.DataAccess.Model;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucTemplateEditor : UserControl
    {
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaveChanges;
        private Template Template;
        private string alterCode;

        public ucTemplateEditor(Template template)
        {
            InitializeComponent();
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
            this.Validate();

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
                    SaveChanges();
                }
                else if (result == DialogResult.No)
                {
                    Template.Source = alterCode;
                    SaveChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
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
