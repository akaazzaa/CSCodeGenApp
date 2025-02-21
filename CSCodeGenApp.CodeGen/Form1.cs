using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using System.ComponentModel;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {
        private BindingList<Template> templates;
        public frmCodeGen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            templates = CoreGlobals.Instance.templateController.Templates;
            bsDaten.DataSource = templates;
        }
    }
}
