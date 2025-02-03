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
        BindingList<Placeholder> placeholderList = CoreGlobals.Instance.placeholderController.GetPlaceholderList();
        BindingList<Template> templateList = CoreGlobals.Instance.templateController.GetTemplateList();

        private bool isDoubleClick = false;

        public TemplateDesignerForm()
        {
            InitializeComponent();

            ListBoxPlaceholder.Click += async (s, e) => await OnButtonClick(s,e);
            ListBoxPlaceholder.DoubleClick += (s, e) => OnButtonDoubleClick(s,e);
            this.FormClosing += TemplateDesignerForm_FormClosing;

            templateBindingSource.DataSource = templateList;
            placeholderBindingSource.DataSource = placeholderList;
            currentTemplate = (Template)templateBindingSource.Current;
        }
        private void OnButtonDoubleClick(object s, EventArgs e)
        {
            
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
        private Placeholder GetPlaceholderFromSender(object sender)
        {
            ListBox listBox = (ListBox)sender;

            return (Placeholder)listBox.SelectedItem;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    } 
}

