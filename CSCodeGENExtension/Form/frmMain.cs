using CSCodeGENExtension.Klassen;
using CSCodeGENExtension.Klassen.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGENExtension
{
    public partial class frmMain : Form
    {
        TemplateController controller;
        private List<Template> templates;
        public frmMain()
        {
            InitializeComponent();
               
            controller = new TemplateController();
            templates = new List<Template>();
            Template template = controller.CreateNew();

            templates.Add(template);

            controller.SaveTemplates(templates);

        }
    }
}
