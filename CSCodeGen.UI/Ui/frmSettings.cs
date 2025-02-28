using CSCodeGen.Library;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();

            bsDaten.DataSource = CoreGlobals.Instance.settings;
            this.FormClosing += Close;

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            this.Validate();
        }
    }
}
