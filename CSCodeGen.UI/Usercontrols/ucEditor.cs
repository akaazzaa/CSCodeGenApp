using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;
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
            if (obj == null) return;
            _currentObject = obj;

            if (obj is Template template)
            {
                fastColoredTextBox1.Text = template.Source;
                listBox1.DataSource = LoadKeywords(template);
                listBox1.DisplayMember = "Name";
                PublicEvents.KeywordDeleted += KeywordDeleted;
               
            }
            else if (obj is Keyword keyword)
            {
                fastColoredTextBox1.Text = keyword.Code;
                listBox1.DataSource = LoadKeywords();
                listBox1.DisplayMember = "Name";
            }
        }

        private void KeywordDeleted(Keyword deletedKeyword)
        {
            defaultKeywords.Remove(deletedKeyword);
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
            defaultKeywords = CoreGlobals.Instance.storage.LoadAllKeywords();

            if (template == null) { return defaultKeywords; }

            template.Keywords.AddingNew += Keywords_AddingNew;

            foreach (Keyword keyword in template.Keywords)
            {
                if (!defaultKeywords.Any(k => k.Id == keyword.Id)) // Hier sicherstellen, dass kein doppeltes Keyword hinzugefügt wird
                {
                    defaultKeywords.Add(keyword);
                }
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
