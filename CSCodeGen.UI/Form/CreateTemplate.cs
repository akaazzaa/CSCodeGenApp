using CSCodeGen.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class CreateTemplateForm : Form
    {
        Template _template;

        public CreateTemplateForm(Template template)
        {
            InitializeComponent();
            _template = template;
            this.FormClosing += CreateTemplate_FormClosing;
        }

        private void CreateTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            _template.Name = this.txtTemplateName.Text;
        }
    }
}
