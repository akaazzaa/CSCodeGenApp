using CSCodeGen.Library.Controller;
using CSCodeGen.Library.Klassen.Template;
using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public partial class frmDesigner : System.Windows.Forms.Form
    {
        FastColoredTextBox fastColoredTextBox;
        Template currentTemplate;
        public frmDesigner()
        {
            InitializeComponent();
            templateBindingSource.DataSource = TemplateController.Instance.GetTemplates();
            fastColoredTextBox = Ui.GetFastColoredTextBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TemplateController.Instance.GetTemplate(listBox1.SelectedIndex) == null)
            {
                return;
            }

            currentTemplate = TemplateController.Instance.GetTemplate(listBox1.SelectedIndex);



            if (fastColoredTextBox == null)
            {
                return;
            }
            fastColoredTextBox.Text = currentTemplate.DisplayText;

            pnlTextbox.Controls.Add(fastColoredTextBox);
        }
    }
}
