using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {

        private Klasse klasse = new Klasse();
        private Template currentTemplate;
        private string lastInput = "";
        public frmCodeGen()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {

            bsDaten.DataSource = CoreGlobals.Instance.templateController.Templates;
            klasseBindingSource.DataSource = klasse;
            bsProperties.DataSource = klasse.Properties;

            ChangeCurrentObjekt();

        }


        private string ReplaceKeywords(string source)
        {
            if (currentTemplate == null) return source;


            foreach (Propertie prop in klasse.Properties)
            {
                if (string.IsNullOrEmpty(prop.Name) || string.IsNullOrEmpty(prop.DataType))
                {
                    continue;
                }

                var matchingKeywords = currentTemplate.Keywords.Where(k => k.DataType == prop.DataType).ToList();

                foreach (Keyword key in matchingKeywords)
                {

                    string code = ReplaceDefaultKeys(key.Code, prop);

                    source = source.Replace(key.DisplayText, code + "\r\r" + "            " + key.DisplayText);
                }
            }

            return ReplaceDefaultKeys(source);
        }

        private string ReplaceDefaultKeys(string text, Propertie prop = null)
        {
            foreach (Keyword key in CoreGlobals.Instance.storage.GetDefaultKeywords())
            {
                if (key.Name == Configuration.Keywords.Classname)
                {
                    text = text.Replace(key.DisplayText, klasse.Name);
                }
                else if (key.Name == Configuration.Keywords.Namespace)
                {
                    text = text.Replace(key.DisplayText, klasse.Namespace);
                }
                else if (key.Name == Configuration.Keywords.Variable)
                {
                    if (prop != null && !string.IsNullOrEmpty(prop.Name))
                    {
                        text = text.Replace(key.DisplayText, PropertyNameToVariable(prop.Name));
                    }
                }
                else if (key.Name == Configuration.Keywords.Propertie)
                {
                    if (prop != null && !string.IsNullOrEmpty(prop.Name))
                    {
                        text = text.Replace(key.DisplayText, prop.Name);
                    }
                }
            }

            return text;
        }

        private string PropertyNameToVariable(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            return $"{name.Substring(0, 1).ToLower()}{name.Substring(1, checked(name.Length - 1))}";
        }

        private void ChangeCurrentObjekt()
        {
            if (cbTemplate.SelectedItem == null) { return; }

            currentTemplate = (Template)cbTemplate.SelectedItem;

            fastColoredTextBox1.Text = currentTemplate.Source;

        }
        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }
        private void btnPropertiesAdd_Click(object sender, EventArgs e)
        {
            klasse.Properties.Add(new Propertie());
        }
        private void btnPropertiesDelete_Click(object sender, EventArgs e)
        {
            var selectedPropertie = (Propertie)dataGridView1.CurrentRow.DataBoundItem;

            if (selectedPropertie == null) { return; }
            klasse.Properties.Remove(selectedPropertie);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            fastColoredTextBox1.Text = ReplaceKeywords(currentTemplate.Source);
        }


    }
}
