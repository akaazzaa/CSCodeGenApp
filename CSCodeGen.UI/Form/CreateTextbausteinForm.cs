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

            Textbaustein textbaustein = (Textbaustein)listBox1.SelectedItem;
            if (textbaustein != null)
            {
                fastColoredTextBox1.Text = textbaustein.Value;
            }
        }

        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            if (toolStripTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Bitte Textbaustein Name eingeben");
                return;
            }
            string key = $" <#{{{toolStripTextBox1.Text}}}#>";
            string value = fastColoredTextBox1.Text;

            if (value == string.Empty || key == string.Empty)
            {
                return;
            }

            Textbaustein textbaustein = new Textbaustein(value, key);
            _textbausteine.Add(textbaustein);
            Save();
        }

        private void listBox1_DoubleClick(object sender, System.EventArgs e)
        {
            Textbaustein textbaustein = (Textbaustein)listBox1.SelectedItem;
            
            if (textbaustein != null)
            {
                fastColoredTextBox1.Text = textbaustein.Value;
            }
           
        }

        private void removeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Textbaustein textbaustein = (Textbaustein)listBox1.SelectedItem;

            if (textbaustein != null)
            {
                _textbausteine.Remove(textbaustein);
                Save();
            }
        }

        private void Save()
        {
            CoreGlobals.Instance.Save();
        }
    }
}
