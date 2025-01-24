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

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTemname.Text == String.Empty)
            {
                MessageBox.Show("Bitte Name eintragen");
                return;
            }
            template.Name = txtTemname.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
