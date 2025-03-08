using CSCodeGen.Model.Main;
using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace CSCodeGen.UI
{
    public partial class ucEditor : UserControl
    {
        private FastColoredTextBox fastColoredTextBox1 = new FastColoredTextBox();
        public event EventHandler<string> CodeChanged;
        public event EventHandler GetDefaultKeys;

        private BindingList<Keyword> defaultKeywords;



        public ucEditor(object obj)
        {
            InitializeComponent();
            Initialize(obj);


            pnlEditor.Controls.Add(fastColoredTextBox1);
            fastColoredTextBox1.Dock = DockStyle.Fill;
            fastColoredTextBox1.Language = Language.CSharp;
            fastColoredTextBox1.AutoIndentChars = true;
            fastColoredTextBox1.AutoIndent = true;
            fastColoredTextBox1.TextChanged += OnTextChanged;
            listBox1.DoubleClick += InsertKeyword;

        }

        private void Initialize<T>(T obj)
        {
            if (obj == null) return;


            if (obj is CodeTemplate template)
            {
                fastColoredTextBox1.Text = template.Source;
                listBox1.DataSource = LoadKeywords(template);
                listBox1.DisplayMember = "Name";
                //PublicEvents.KeywordDeleted += KeywordDeleted;

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



        private void InsertKeyword(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Keyword selectedKeyword = (Keyword)listBox1.SelectedItem;
                string fullKeyword = $"{selectedKeyword.DisplayText}";
                int insertPosition = fastColoredTextBox1.SelectionStart;
                fastColoredTextBox1.Text = fastColoredTextBox1.Text.Insert(insertPosition, fullKeyword);
            }
        }
        private BindingList<Keyword> LoadKeywords(CodeTemplate template = null)
        {


            // Hole die Standard-Keywords
            //defaultKeywords =    

            if (template == null)
            {
                // Ohne Template einfach zurückgeben
                return defaultKeywords;
            }

            // Eventhandler registrieren
            template.Keywords.AddingNew += Keywords_AddingNew;


            foreach (Keyword keyword in template.Keywords)
            {
                if (!defaultKeywords.Any(k => k.Name == keyword.Name))
                {
                    defaultKeywords.Add(keyword);
                }
            }


            return defaultKeywords;


        }
        private void Keywords_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Keyword(); // Neues Keyword mit Default-Name

            Keyword tmp = (Keyword)e.NewObject;

            // Falls ein Keyword mit demselben Namen bereits existiert, wird es nicht hinzugefügt
            if (!defaultKeywords.Any(k => k.Name == tmp.Name))
            {
                defaultKeywords.Add(tmp);
            }
        }
        private void OnTextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            CodeChanged?.Invoke(this, fastColoredTextBox1.Text);
        }





    }
}
