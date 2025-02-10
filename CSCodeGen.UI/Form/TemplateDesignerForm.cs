using CSCodeGen.DataAccess.Model;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        public Template EditedTemplate { get; private set; }

        public TemplateDesignerForm()
        {
            InitializeComponent();
            Template template = new Template(DataAccess.DataType.Klasse);
            EditedTemplate = template;
            fastColoredTextBox1.Text = EditedTemplate.Source;






        }

        private void listBox1_DoubleClick(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                Textbaustein k = (Textbaustein)listBox1.SelectedItem;

                if (fastColoredTextBox1.Text.Contains(k.Value))
                {
                    fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace(k.Value, k.Value);
                }
            }
        }
    }

}


