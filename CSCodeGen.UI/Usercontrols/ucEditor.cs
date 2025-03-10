using CSCodeGen.Model;
using CSCodeGen.Model.Main;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace CSCodeGen.UI
{
    public partial class ucEditor : UserControl
    {
        private FastColoredTextBox fastColoredTextBox = new FastColoredTextBox();
        public event EventHandler<string> CodeChanged;
        public event EventHandler GetDefaultKeys;
        private List<Keyword> defaultKeywords;
        private Template currentTemplate;

        public ucEditor(object obj)
        {
            InitializeComponent();
            Initialize(obj);

            pnlEditor.Controls.Add(fastColoredTextBox);
            fastColoredTextBox.Dock = DockStyle.Fill;
            fastColoredTextBox.Language = Language.CSharp;
            fastColoredTextBox.AutoIndentChars = true;
            fastColoredTextBox.AutoIndent = true;


            fastColoredTextBox.TextChanged += OnTextChanged;

            listBox1.DoubleClick += InsertKeyword;
        }
        private void Initialize<T>(T obj)
        {
            if (obj == null) return;


            if (obj is Template template)
            {
                fastColoredTextBox.Text = template.Source;
                currentTemplate = template;
                LoadKeywords();
                RefreshKeywordsList();


            }
            else if (obj is Keyword keyword)
            {
                fastColoredTextBox.Text = keyword.Code;
                LoadKeywords();
                RefreshKeywordsList();

            }
        }
        private void InsertKeyword(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Keyword selectedKeyword = (Keyword)listBox1.SelectedItem;
                string fullKeyword = $"{selectedKeyword.DisplayText}";

                int insertPosition = fastColoredTextBox.SelectionStart;

                fastColoredTextBox.Text = fastColoredTextBox.Text.Insert(insertPosition, fullKeyword);

                fastColoredTextBox.SelectionStart = insertPosition + fullKeyword.Length;
                fastColoredTextBox.Focus();
            }
        }
        private void LoadKeywords()
        {

            // Hole die Standard-Keywords
            defaultKeywords = (List<Keyword>)Configuration.GetDefaultKeywords();  

            if (currentTemplate == null)
            {
                // Ohne Template einfach zurückgeben
                return;
            }

            

            // Eventhandler registrieren
            currentTemplate.Keywords.ListChanged += Keywords_ListChanged;

            UpdateKeywordsList(currentTemplate);

        }
        private void Keywords_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted || 
                e.ListChangedType == ListChangedType.ItemChanged)
            {
                RefreshKeywordsList();
                UpdateKeywordsList(currentTemplate);
            }
        }
        private void OnTextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            CodeChanged?.Invoke(this, fastColoredTextBox.Text);
        }
        private void RefreshKeywordsList()
        {
            // Aktualisiere die ListBox mit den Keywords
            listBox1.DataSource = null;
            listBox1.DataSource = defaultKeywords;
            listBox1.DisplayMember = "Name";
        }
        private void UpdateKeywordsList(Template template)
        {
            foreach (Keyword keyword in template.Keywords)
            {
                if (!defaultKeywords.Any(k => k.Name == keyword.Name))
                {
                    defaultKeywords.Add(keyword);
                }
            }
        }

    }
}
