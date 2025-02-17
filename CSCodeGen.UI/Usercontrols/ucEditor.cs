using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace CSCodeGen.UI
{
    public partial class ucEditor : UserControl
    {
        private object _currentObject;
        public event EventHandler<string> CodeChanged;

        public ucEditor()
        {
            InitializeComponent();
            fastColoredTextBox1.TextChanged += FastColoredTextBox1_TextChanged;
            listBox1.DoubleClick += ListBox1_DoubleClick;
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedKeyword = listBox1.SelectedItem.ToString();
                string fullKeyword = $"{Configuration.Prefix}{selectedKeyword}{Configuration.Postfix}";
                int insertPosition = fastColoredTextBox1.SelectionStart;
                fastColoredTextBox1.Text = fastColoredTextBox1.Text.Insert(insertPosition, fullKeyword);
            }
        }

        private List<string> LoadKeywords()
        {
            var keywords = typeof(KeywordConfiguration)
              .GetProperties(BindingFlags.Public | BindingFlags.Instance)
               .Where(prop => prop.PropertyType == typeof(string))
                .Select(prop => prop.GetValue(Configuration.Keywords)?.ToString())
                .ToList();

            return keywords;
        }

        public void Initialize<T>(T obj)
        {
            _currentObject = obj;

            if (obj is Template template)
            {
                fastColoredTextBox1.Text = template.Source;
            }
            else if (obj is Keyword keyword)
            {
                fastColoredTextBox1.Text = keyword.Code;
            }

            listBox1.DataSource = LoadKeywords();
            listBox1.DisplayMember = "Name"; // Falls dein Objekt eine `Name`-Eigenschaft hat

        }

        private void FastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            CodeChanged?.Invoke(this, fastColoredTextBox1.Text);
        }





    }
}
