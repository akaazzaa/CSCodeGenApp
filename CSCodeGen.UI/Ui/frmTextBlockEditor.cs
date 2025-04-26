
using CSCodeGen.Model.Main;
using CSCodeGen.UC;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class frmTextBlockEditor : Form , ITextBlockEditorView
    {

        public event EventHandler<Textbaustein> TextBlockChanged;

        private ucEditor ucEditor;
        Textbaustein Keyword;
        
        public frmTextBlockEditor(Textbaustein keyword)
        {
            InitializeComponent();
            Keyword = keyword;
            Initialize();

        }

        public void Initialize()
        {
            ucEditor = new ucEditor(Keyword);
            //ucEditor.CodeChanged += CodeChanged;
            ucEditor.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucEditor);
        }

        public void OnTextBlockChange(Textbaustein keyword)
        {
           TextBlockChanged?.Invoke(this, keyword);
        }
    }
}
