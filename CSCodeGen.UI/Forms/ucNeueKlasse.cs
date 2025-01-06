using CSCodeGen.Library.Controller;
using CSCodeGen.Library.Klassen.Template;
using FastColoredTextBoxNS;


namespace CSCodeGen.Ui
{
    public partial class ucNeueKlasse : UserControl
    {
        private Template currentTemplate;
        FastColoredTextBox fastColoredTextBox;
        public ucNeueKlasse()
        {
            InitializeComponent();

            //comboBox1.DataSource = TemplateController.Instance.GetTemplates();

            templateBS.DataSource = TemplateController.Instance.GetTemplates();
            fastColoredTextBox = Ui.GetFastColoredTextBox();
            splitContainer1.Panel2.Controls.Add(fastColoredTextBox);

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 1;
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 1;
            }

            currentTemplate = TemplateController.Instance.GetTemplate(comboBox1.SelectedIndex);

            if (currentTemplate == null) { fastColoredTextBox.Text = string.Empty; return; }
            fastColoredTextBox.Text = currentTemplate.DisplayText;
        }

        private void btnAddProperties_Click(object sender, EventArgs e)
        {
            currentTemplate.Properties.Add(new PropertyModel());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TemplateController.Instance.GetTemplate(comboBox1.SelectedIndex) == null)
            {
                return;
            }

            currentTemplate = TemplateController.Instance.GetTemplate(comboBox1.SelectedIndex);



            if (fastColoredTextBox == null)
            {
                return;
            }
            fastColoredTextBox.Text = currentTemplate.DisplayText;
        }

        private void btnDeleteProperties_Click(object sender, EventArgs e)
        {
            if (gcProps.SelectedRows.Count <= 0)
            {
                return;
            }

            var selectedRow = gcProps.SelectedRows[0];

            // Überprüfen, ob die Zeile in der Datenquelle vorhanden ist
            if (selectedRow.DataBoundItem is PropertyModel prop)
            {
                // Entfernen aus der BindingList
                currentTemplate.Properties.Remove(prop);
            }
        }
    }
}
