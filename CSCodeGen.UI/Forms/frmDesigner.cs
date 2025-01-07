using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public partial class frmDesigner : System.Windows.Forms.Form
    {
        FastColoredTextBox fastColoredTextBox;

        public frmDesigner()
        {
            InitializeComponent();

            fastColoredTextBox = Ui.GetFastColoredTextBox();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
