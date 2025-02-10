using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        private Template currentTemplate;
        private Textbaustein currentTextbaustein;
        private BindingList<Textbaustein> textbausteinList = CoreGlobals.Instance.placeholderController.GetTextbausteinList();
        private BindingList<Template> templateList = CoreGlobals.Instance.templateController.GetTemplateList();
        private bool isDoubleClick = false;

        public TemplateDesignerForm()
        {
            InitializeComponent();

            ListBoxPlaceholder.Click += async (s, e) => await OnButtonClick(s, e);
            ListBoxPlaceholder.DoubleClick += (s, e) => OnButtonDoubleClick(s, e);
            ListBoxTemplates.Click += ListBoxTemplates_Click;
            this.FormClosing += TemplateDesignerForm_FormClosing;

            templateBindingSource.DataSource = templateList;
            placeholderBindingSource.DataSource = textbausteinList;
            currentTemplate = (Template)templateBindingSource.Current;
        }

        private void OnButtonDoubleClick(object sender, EventArgs e)
        {
            isDoubleClick = true;
            if (currentTextbaustein != null)
            {
                TextbausteinForm placeholder = new TextbausteinForm(currentTextbaustein);
                placeholder.ShowDialog();
            }
        }

        private async Task OnButtonClick(object sender, EventArgs e)
        {
            isDoubleClick = false;
            await Task.Delay(SystemInformation.DoubleClickTime);

            if (!isDoubleClick && currentTextbaustein != null)
            {
                var newText = CoreGlobals.Instance.placeholderController.ReplaceKeywords(editor.Text, currentTextbaustein);
                if (currentTemplate != null)
                {
                    currentTemplate.Content = newText;
                    ShowContent();
                }
            }
        }

        private void TemplateDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoreGlobals.Instance.Save();
        }

        private void GetPlaceholderFromSender(object sender)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is Textbaustein textbaustein)
            {
                currentTextbaustein = textbaustein;
            }
        }

        private void SetCurrentTemplate(object sender)
        {
            currentTemplate = (Template)ListBoxTemplates.SelectedItem;
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            // Erstellt neues Template, öffnet eine Form wenn der Name eingegeben wurde wird das Template der Liste hinzugefügt.
            Template newTemplate = new Template();
            CreateTemplateForm createTemplateForm = new CreateTemplateForm(newTemplate);
            createTemplateForm.ShowDialog();

            if (!string.IsNullOrEmpty(newTemplate.Name))
            {
                templateList.Add(newTemplate);
            }
        }
        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            // Löschen
            if (currentTemplate != null)
            {
                templateList.Remove(currentTemplate);
                currentTemplate = null;
            }
        }

        private void btnAddTextbaustein_Click(object sender, EventArgs e)
        {
            Textbaustein newTextbaustein = new Textbaustein();
            TextbausteinForm textbausteinForm = new TextbausteinForm(newTextbaustein);

            textbausteinForm.ShowDialog();
            // Überlegen was in TextbausteinForm passieren muss 

        }

        private void btnDeleteTextbaustein_Click(object sender, EventArgs e)
        {
            // Löschen
            if (currentTextbaustein != null)
            {
                textbausteinList.Remove(currentTextbaustein);
                currentTextbaustein = null;
            }
        }

        private void ListBoxTemplates_Click(object sender, EventArgs e)
        {

            SetCurrentTemplate(sender);

            if (currentTemplate != null)
            {
                ShowContent();
            }
        }
        // Zeigt den Template Text an
        private void ShowContent()
        {
            if (currentTemplate != null)
            {
                editor.Text = currentTemplate.Content;
            }
        }


    }

}


