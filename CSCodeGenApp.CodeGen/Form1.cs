using CSCodeGen.DataAccess.Model;
using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

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

            // User-Keywords ersetzen
            foreach (Keyword key in currentTemplate.Keywords)
            {
                source = source.Replace(key.DisplayText, key.Code + "\r   " + key.DisplayText);
            }

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

            fastColoredTextBox1.Text =  ReplaceKeywords(currentTemplate.Source);

        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentObjekt();
        }

       
    }
}
