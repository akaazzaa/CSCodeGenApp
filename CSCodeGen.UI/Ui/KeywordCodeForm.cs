using CSCodeGen.DataAccess.Model;
using CSCodeGen.UI.Usercontrols;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class KeywordCodeForm : Form
    {
        public KeywordCodeForm(Keyword current)
        {
            InitializeComponent();

            ucEditor ucEditor = new ucEditor(current.Code);
            panel1.Controls.Add(ucEditor);
        }
    }
}
