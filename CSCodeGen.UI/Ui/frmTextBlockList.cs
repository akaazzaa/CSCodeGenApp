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
    public partial class frmTextBlockList : Form, ITextBlockListView
    {
        private TemplateEventArgs _args;

        public frmTextBlockList(TemplateEventArgs args)
        {
            InitializeComponent();
            _args = args;
            Initialize();
        }

        #region Mthods
        public void Initialize()
        {
            ShowKeywords(_args.Template.Textbausteine);
        }
        public void ShowKeywords(IEnumerable<Textbaustein> keywords)
        {
            textbausteinBindingSource.DataSource = keywords;

            Type.DataSource = Enum.GetValues(typeof(DataType));

        }
        #endregion
        #region Events
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
                frmTextBlockEditor textBlockEditor = new frmTextBlockEditor(selectedKeyword);
                textBlockEditor.ShowDialog();
            }
        }
        #endregion

    }
}
