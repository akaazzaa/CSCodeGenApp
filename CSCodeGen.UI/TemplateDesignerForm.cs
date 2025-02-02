using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        Template currentTemplate;
        private bool isDoubleClick = false;
       
        public TemplateDesignerForm()
        {
            InitializeComponent();

            listBoxPlaceholder.Click += async (s, e) => await OnButtonClick(s,e);
            listBoxPlaceholder.DoubleClick += (s, e) => OnButtonDoubleClick(s,e);
            this.FormClosing += TemplateDesignerForm_FormClosing;


            templateBindingSource.DataSource = CoreGlobals.Instance.templateController.GetTemplateList();
            placeholderBindingSource.DataSource = CoreGlobals.Instance.placeholderController.GetPlaceholderList();
            currentTemplate = (Template)templateBindingSource.Current;

            
        }

        private void TemplateDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoreGlobals.Instance.Save();
        }

        private async Task OnButtonClick(object sender, EventArgs e)
        {
            isDoubleClick = false;
            await Task.Delay(SystemInformation.DoubleClickTime); // Wartezeit für Doppelklick

            if (!isDoubleClick)
            {
                var newText = PlaceholderController.SearchandRepalce(editor.Text, GetPlaceholderFromSender(sender));
                currentTemplate.Content = newText;
            }
        }

        private void OnButtonDoubleClick(object sender, EventArgs e)
        {
            isDoubleClick = true;
            PlaceholderForm placeholderForm = new PlaceholderForm(GetPlaceholderFromSender(sender));

            if (placeholderForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

       

        private Placeholder GetPlaceholderFromSender(object sender)
        {
            ListBox listBox = (ListBox)sender;

            return (Placeholder)listBox.SelectedItem;
        }
    }
}
