using CSCodeGen.Library;

namespace CSCodeGen.UI.Forms
{
    public partial class frmTemName : Form
    {
        Template template;
        public frmTemName(Template template)
        {
            InitializeComponent();
            this.template = template;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            template.Name = txtTemname.Text;
        }
    }
}
