using CSCodeGen.Model;
using CSCodeGen.Model.Main;
using CSCodeGen.Model.Settings;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CSCodeGen.Model.Interfaces.View;


namespace CSCodeGen.UC
{
    public partial class ucEditor : UserControl 
    {
        public event EventHandler<string> CodeChanged;
        public event EventHandler GetDefaultKeys;
        public event EventHandler UpdatePlatzhalter;

        private FastColoredTextBox fastColoredTextBox = new FastColoredTextBox();
        private List<Textbaustein> defaultKeywords = new List<Textbaustein>();
        private Template currentTemplate;

        public ucEditor(object obj)
        {
            InitializeComponent();
            Initialize(obj);

        }
        #region Events
        private void OnTextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            CodeChanged?.Invoke(this, fastColoredTextBox.Text);
        }
        private void Keywords_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted ||
                e.ListChangedType == ListChangedType.ItemChanged)
            {
                UpdateKeywordsList(currentTemplate);
                RefreshKeywordsList();
            }
        }
        private void InsertKeyword(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Textbaustein selectedKeyword = (Textbaustein)listBox1.SelectedItem;
                string fullKeyword = $"{selectedKeyword.DisplayText}";

                int insertPosition = fastColoredTextBox.SelectionStart;

                fastColoredTextBox.Text = fastColoredTextBox.Text.Insert(insertPosition, fullKeyword);

                fastColoredTextBox.SelectionStart = insertPosition + fullKeyword.Length;
                fastColoredTextBox.Focus();
            }
        }
        #endregion

        #region Methods
        public void Initialize<T>(T obj)
        {
            if (obj == null) return;


            if (obj is Template template)
            {
                fastColoredTextBox.Text = template.Content;
                currentTemplate = template;
                LoadKeywords();
                RefreshKeywordsList();
            }
            else if (obj is Textbaustein keyword)
            {
                fastColoredTextBox.Text = keyword.Code;
                LoadKeywords();
                RefreshKeywordsList();
            }

            pnlEditor.Controls.Add(fastColoredTextBox);
            fastColoredTextBox.Dock = DockStyle.Fill;
            fastColoredTextBox.Language = Language.CSharp;
            fastColoredTextBox.AutoIndentChars = true;
            fastColoredTextBox.AutoIndent = true;


            fastColoredTextBox.TextChanged += OnTextChanged;

            listBox1.DoubleClick += InsertKeyword;
        }
        private void LoadKeywords()
        {
            //defaultKeywords = (List<Textbaustein>)ConfigData.GetDefaults();  

            if (currentTemplate == null)
            {
               
                return;
            }

            currentTemplate.Textbausteine.ListChanged += Keywords_ListChanged;

            UpdateKeywordsList(currentTemplate);

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

            foreach (Textbaustein keyword in template.Textbausteine)
            {
                if (!defaultKeywords.Any(k => k.Name == keyword.Name))
                {
                    defaultKeywords.Add(keyword);
                }
            }
        }

        #endregion
    }
}
