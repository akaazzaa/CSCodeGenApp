using CSCodeGen.DataAccess.Model.Config;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CSCodeGen.UI.Usercontrols
{
    public partial class ucEditor : UserControl
    {
        public ucEditor(string source)
        {
            InitializeComponent();

            LoadKeywords();
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
