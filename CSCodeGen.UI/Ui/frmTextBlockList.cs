using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.UC;
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
    public partial class frmTextBlockList : Form, ITextBlockListView
    {
        private TemplateEventArgs _args;
        private ucEditor ucEditor;
        private Textbaustein _textbaustein;
        public frmTextBlockList(TemplateEventArgs args)
        {
            InitializeComponent();
            _args = args;
            Initialize();
        }

        #region Mthods
        public void Initialize()
        {
            ucEditor = new ucEditor();
            ucEditor.Dock = DockStyle.Fill;
            ucEditor.CodeChanged += CodeChanged;
           
            pnlRight.Controls.Add(ucEditor);
            ShowKeywords(_args.Template.Textbausteine);
        }

        private void CodeChanged(object sender, string e)
        {
            if (_textbaustein == null) { return; }

            _textbaustein.Code = e;
        }

        public void ShowKeywords(IEnumerable<Textbaustein> keywords)
        {
            textbausteinBindingSource.DataSource = keywords;

            Type.DataSource = Enum.GetValues(typeof(DataType));

        }
        #endregion
        #region Events

        private void gvDaten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();

            if (e.RowIndex < 0) { return; }

            _textbaustein = (Textbaustein)gvDaten.Rows[e.RowIndex].DataBoundItem;

            if (String.IsNullOrEmpty(_textbaustein.Name))
            {
                MessageBox.Show("Bitte erst einen Namen vergeben");
            }
            ucEditor.ShowContent(_textbaustein);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            textbausteinBindingSource.Add(new Textbaustein());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(textbausteinBindingSource.Current == null) { return; }

            textbausteinBindingSource.RemoveCurrent();
        }

        #endregion



    }
}
