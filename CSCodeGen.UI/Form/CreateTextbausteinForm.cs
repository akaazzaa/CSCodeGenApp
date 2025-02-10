using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class CreateTextbausteinForm : Form
    {
        private BindingList<Textbaustein> _textbausteine;


        public CreateTextbausteinForm()
        {
            InitializeComponent();
            _textbausteine = CoreGlobals.Instance.textbausteinController.GetListTextbausteine();
            textbausteinBindingSource.DataSource = _textbausteine;

        }

        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            if (toolStripTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Bitte Textbaustein Name eingeben");
                return;
            }
            string key = $" <#{{{toolStripTextBox1.Text}}}#>";


            Textbaustein textbaustein = new Textbaustein("value", "key");
            _textbausteine.Add(textbaustein);


        }
    }
}
