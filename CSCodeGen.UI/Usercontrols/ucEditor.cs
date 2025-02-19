using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace CSCodeGen.UI
{
    public partial class ucEditor : UserControl
    {
        private object _currentObject;
        public event EventHandler<string> CodeChanged;
        private BindingList<Keyword> defaultKeywords;

        public ucEditor()
        {
            InitializeComponent();
            fastColoredTextBox1.TextChanged += FastColoredTextBox1_TextChanged;
            listBox1.DoubleClick += ListBox1_DoubleClick;

        }

        public void Initialize<T>(T obj)
        {
            _currentObject = obj;

            if (obj is Template template)
            {
                fastColoredTextBox1.Text = template.Source;
                listBox1.DataSource = LoadKeywords(template);
                listBox1.DisplayMember = "Name";
            }
            else if (obj is Keyword keyword)
            {
                fastColoredTextBox1.Text = keyword.Code;
                listBox1.DataSource = LoadKeywords();
                listBox1.DisplayMember = "Name";
            }

            // Falls dein Objekt eine `Name`-Eigenschaft hat

        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Keyword selectedKeyword = (Keyword)listBox1.SelectedItem;
                string fullKeyword = $"{selectedKeyword.DisplayText}";
                int insertPosition = fastColoredTextBox1.SelectionStart;
                fastColoredTextBox1.Text = fastColoredTextBox1.Text.Insert(insertPosition, fullKeyword);
            }
        }

        private BindingList<Keyword> LoadKeywords(Template template = null)
        {
            // Hole die String-Werte aus KeywordConfiguration
            List<string> reflectedKeywords = typeof(KeywordConfiguration)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(prop => prop.PropertyType == typeof(string))
                .Select(prop => prop.GetValue(Configuration.Keywords)?.ToString())
                .Where(value => !string.IsNullOrEmpty(value)) // Filtert null und leere Werte
                .ToList();

            defaultKeywords = new BindingList<Keyword>(
              (reflectedKeywords ?? Enumerable.Empty<string>())
                  .Select(text => new Keyword(text))
                      .ToList()
                      );

            if (template == null) { return defaultKeywords; }

            template.Keywords.AddingNew += Keywords_AddingNew;

            foreach (Keyword keyword in template.Keywords)
            {
                defaultKeywords.Add(keyword);
            }

            return defaultKeywords;
        }

        private void Keywords_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Keyword();
            Keyword tmp = (Keyword)e.NewObject;

            defaultKeywords.Add(tmp);
        }

        private void FastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            CodeChanged?.Invoke(this, fastColoredTextBox1.Text);
        }





    }
}
