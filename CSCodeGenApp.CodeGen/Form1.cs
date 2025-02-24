using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;
using System.ComponentModel;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {
        private BindingList<Template> templates;
        private BindingList<Propertie> properties = new BindingList<Propertie>();
        private Template currentTemplate;
        private string lastInput = "";
        public frmCodeGen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            templates = CoreGlobals.Instance.templateController.Templates;
            bsDaten.DataSource = templates;
            txtName.Validated += NameEingabe;

            bsProperties.DataSource = properties;

            ChangeCurrentObjekt();

        }


        private string ReplaceKeywords(string source)
        {
            if (currentTemplate == null) return source;
            List<Keyword> tmplist = new List<Keyword>();
            foreach (Propertie prop in properties)
            {
                if (string.IsNullOrEmpty(prop.Name) || string.IsNullOrEmpty(prop.DataType))
                {
                    continue;
                }

                tmplist = currentTemplate.Keywords.Where(k => k.DataType == prop.DataType).ToList();
                foreach (Keyword key in tmplist)
                {
                    key.Code = key.Code.Replace(key.DisplayText, prop.Name);
                    source = source.Replace(key.DisplayText, key.Code + "\r   " + key.DisplayText);
                }
            }
            // User-Keywords ersetzen


            // Standard-Keywords aus der Config ersetzen
            return ReplaceStandardKeywords(source);
        }

        private string ReplaceStandardKeywords(string source)
        {
            var standardKeywords = new Dictionary<string, string>
            {


            };

            foreach (var kvp in standardKeywords)
            {
                source = source.Replace(kvp.Key, kvp.Value);
            }

            return source;
        }


        private void NameEingabe(object? sender, EventArgs e)
        {
            CheckCurrentTemplate();

            if (!string.IsNullOrEmpty(txtName.Text))
            {

                string prefabName = $"{Configuration.Prefix}{Configuration.Keywords.PrefabClassname}{Configuration.Postfix}";
                if (currentTemplate.Source.Contains(prefabName))
                {
                    currentTemplate.Source = currentTemplate.Source.Replace(prefabName, txtName.Text);
                }
                else if (!string.IsNullOrEmpty(lastInput))
                {
                    currentTemplate.Source = currentTemplate.Source.Replace(lastInput, txtName.Text);
                }

                lastInput = txtName.Text;
            }



        }
        private void CheckCurrentTemplate()
        {
            if (currentTemplate == null) { return; }
        }
        private void ChangeCurrentObjekt()
        {
            if (cbTemplate.SelectedItem == null) { return; }

            currentTemplate = (Template)cbTemplate.SelectedItem;



        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }

        private void btnPropertiesAdd_Click(object sender, EventArgs e)
        {
            properties.Add(new Propertie());
        }

        private void btnPropertiesDelete_Click(object sender, EventArgs e)
        {
            var selectedPropertie = (Propertie)dataGridView1.CurrentRow.DataBoundItem;

            if (selectedPropertie == null) { return; }
            properties.Remove(selectedPropertie);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            fastColoredTextBox1.Text = ReplaceKeywords(currentTemplate.Source);
        }
    }
}
