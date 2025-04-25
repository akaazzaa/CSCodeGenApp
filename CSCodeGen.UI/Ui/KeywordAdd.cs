using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class KeywordAdd : Form, IKeywordView
    {
        public KeywordAdd(TemplateEventArgs args)
        {
            InitializeComponent();
            ShowKeywords(args.Template.Textbausteine);
        }

        public event EventHandler LoadKeywords;
        public event EventHandler SaveAll;
        public event EventHandler SaveKeyword;
        public event EventHandler NewKeyword;
        public event EventHandler RemoveKeyword;

        public void SetKeyword(Textbaustein keyword)
        {
            throw new NotImplementedException();
        }

        public void SetKeywordCount(int count)
        {
            throw new NotImplementedException();
        }

        public void SetKeywordError(string error)
        {
            throw new NotImplementedException();
        }

        public void SetKeywordIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void ShowKeywords(IEnumerable<Textbaustein> keywords)
        {
            textbausteinBindingSource.DataSource = keywords;

            Type.DataSource = Enum.GetValues(typeof(DataType));

        }

        private void gvDaten_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var selectedKeyword = (Textbaustein)gvDaten.Rows[e.RowIndex].DataBoundItem;

            if (selectedKeyword == null) { return; }

            // Überprüfe, ob die geklickte Zelle zur Button-Spalte gehört
            if (gvDaten.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                KeywordCodeForm keywordCodeForm = new KeywordCodeForm(selectedKeyword);
                keywordCodeForm.KeywordChanged += OnKeywordChanged;
                keywordCodeForm.ShowDialog();
            }
        }

        private void OnKeywordChanged()
        {
            
        }
    }
}
