using CSCodeGen.Library.Controller;
using CSCodeGen.Library.Klassen.Template;
using FastColoredTextBoxNS;


namespace CSCodeGen.Ui
{
    public partial class ucNeueKlasse : UserControl
    {
        private List<Template> templates = new List<Template>();
        private Template template;
        TemplateController controller;
        public ucNeueKlasse()
        {
            InitializeComponent();
            controller = new TemplateController();
            templates = controller.LoadTemplates();

            Application.Idle += Application_Idle;


        }

        private void Application_Idle(object? sender, EventArgs e)
        {

            templateBindingSource.DataSource = templates;
            //propertiesBindingSource.DataSource = template.Properties;
            //methodsBindingSource.DataSource = template.Methods;

            FastColoredTextBox fastColoredTextBox = Ui.GetFastColoredTextBox();

        }
    }
}
