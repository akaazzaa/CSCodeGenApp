using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;
using FastColoredTextBoxNS;
using System.ComponentModel;

namespace CSCodeGenApp.CodeGen
{
    public partial class frmCodeGen : Form
    {
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



            bsDaten.DataSource = CoreGlobals.Instance.templateController.Templates;
            txtName.Validated += NameEingabe;

            bsProperties.DataSource = properties;

            ChangeCurrentObjekt();

        }


        private string ReplaceKeywords(string source)
        {
            if (currentTemplate == null) return source;
            

            foreach (Propertie prop in properties)
            {
                if (string.IsNullOrEmpty(prop.Name) || string.IsNullOrEmpty(prop.DataType))
                {
                    continue;
                }

                var matchingKeywords = currentTemplate.Keywords.Where(k => k.DataType == prop.DataType).ToList();

                foreach (Keyword key in matchingKeywords)
                {
                    key.Code = ReplaceDefaultKeys(key.Code);
                    source = source.Replace(key.DisplayText, key.Code + "\r   " + key.DisplayText);
                }
            }
            
            return source;
        }

        private string ReplaceDefaultKeys(string text)
        {
            foreach (Keyword key in CoreGlobals.Instance.storage.LoadAllKeywords())
            {

                
            }

            return text;
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

            fastColoredTextBox1.Text = currentTemplate.Source;

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
