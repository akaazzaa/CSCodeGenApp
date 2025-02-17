using CSCodeGen.DataAccess.Model;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class KeywordCodeForm : Form
    {
        Keyword Keyword;
        public KeywordCodeForm(Keyword current)
        {
            InitializeComponent();

            Keyword = current;

            ucEditor1.Initialize(current);
            ucEditor1.CodeChanged += UcEditor1_CodeChanged;

        }

        private void UcEditor1_CodeChanged(object sender, string newCode)
        {
            Keyword.Code = newCode;
        }
    }
}
