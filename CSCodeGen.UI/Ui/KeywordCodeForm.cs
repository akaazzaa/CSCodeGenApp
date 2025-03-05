using CSCodeGen.DataAccess.Model.Main;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class KeywordCodeForm : Form
    {
        private ucEditor ucEditor;
        Keyword Keyword;
        public event Action KeywordChanged;
        public KeywordCodeForm(Keyword keyword)
        {
            InitializeComponent();

            Keyword = keyword;
            ucEditor = new ucEditor(keyword);
            ucEditor.CodeChanged += CodeChanged;
            ucEditor.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucEditor);

        }

        private void CodeChanged(object sender, string newCode)
        {
            Keyword.Code = newCode;
            KeywordChanged?.Invoke();
        }
    }
}
