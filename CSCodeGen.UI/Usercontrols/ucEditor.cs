using CSCodeGen.DataAccess.Model.Config;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucEditor : UserControl
    {
        public event Action<TabPage> OnClosingTap;
        public event Action OnSaving;
        public event Action<string> OnTextChanging;
        private bool textChanged = false;
        string source;



        public ucEditor(string source)
        {
            InitializeComponent();

            // Datasource
            this.source = source;
            fastColoredTextBox1.Text = this.source;

            //Events abonnieren

            fastColoredTextBox1.TextChanged += FastColoredTextBox1_TextChanged;

            löschenToolStripMenuItem.Click += (s, e) => CloseTab();


            LoadKeywords();

        }

        private void FastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            source = fastColoredTextBox1.Text;
            OnTextChanging?.Invoke(source);
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
                    SaveChanges(); // Speichern und dann schließen
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Abbrechen, Tab bleibt offen
                }
            }

            OnClosingTap?.Invoke(this.Parent as TabPage);
        }
        public void SaveChanges()
        {
            OnSaving?.Invoke();// Speichert den Text
        }
        private void LoadKeywords()
        {
            var keywords = typeof(KeywordConfiguration)
               .GetProperties(BindingFlags.Public | BindingFlags.Instance)
               .Where(prop => prop.PropertyType == typeof(string))
               .Select(prop => prop.GetValue(Configuration.Keywords)?.ToString())
               .ToList();

            lbSchlüssel.DataSource = keywords;
        }
        #endregion
        private void lbSchlüssel_DoubleClick(object sender, System.EventArgs e)
        {
            if (lbSchlüssel.SelectedItem != null)
            {
                string selectedKeyword = lbSchlüssel.SelectedItem.ToString();
                // Optional: Füge Prefix und Postfix hinzu – falls gewünscht,
                // könntest du auch den "DisplayText" aus einer Keyword-Klasse verwenden.
                string fullKeyword = $"{Configuration.Prefix}{selectedKeyword}{Configuration.Postfix}";
                int insertPosition = fastColoredTextBox1.SelectionStart;
                fastColoredTextBox1.Text = fastColoredTextBox1.Text.Insert(insertPosition, fullKeyword);
            }
        }


    }
}
