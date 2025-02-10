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
            Template template = new Template();
            fastColoredTextBox1.Text = template.Content;

        }




    }

}


