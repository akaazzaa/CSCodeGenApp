using CSCodeGen.Library;
using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public partial class frmDesigner : System.Windows.Forms.Form
    {
        FastColoredTextBox fastColoredTextBox;
        List<Template> templates;
        List<Placeholder> placeholders;

        public object lb_item = null;


        private Template currentTemplate;
        public frmDesigner()
        {
            InitializeComponent();

            templates = MainController.Get<TemplateController>().Templates();
            placeholders = MainController.Get<PlaceholderController>().Placeholder();

            templateBindingSource1.DataSource = templates;
            placeholderBindingSource.DataSource = placeholders;

            fastColoredTextBox = Ui.GetFastColoredTextBox();
            fastColoredTextBox.TextChanged += TextChanged;

            pnlEditor.Controls.Add(fastColoredTextBox);



        }



        private void TextChanged(object? sender, TextChangedEventArgs e)
        {
            if (currentTemplate == null) { return; }
            currentTemplate.Content = fastColoredTextBox.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template();
            templates.Add(currentTemplate);
            templateBindingSource1.ResetBindings(false);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            currentTemplate = (Template)templateBindingSource1.Current;

            fastColoredTextBox.Text = currentTemplate.Content;

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            var placeholder = (Placeholder)placeholderBindingSource.Current;
            InsertPlaceholder(placeholder);
        }



        private void InsertPlaceholder(Placeholder placeholder)
        {
            var position = fastColoredTextBox.SelectionStart; // Aktuelle Cursorposition merken
            fastColoredTextBox.Text = fastColoredTextBox.Text.Insert(position, placeholder.DefaultValue); // Platzhalter einfügen
            fastColoredTextBox.SelectionStart = position + placeholder.DefaultValue.Length; // Cursorposition hinter den eingefügten Text setzen
        }

        private void listBox2_DragLeave(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (lb_item != null)
            {
                listBox2.Items.Add(lb_item);
                lb_item = null;
            }
        }


        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lb_item = null;

            if (listBox2.Items.Count == 0)
            {
                return;
            }

            int index = listBox2.IndexFromPoint(e.X, e.Y);
            string s = listBox2.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);
        }

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            lb_item = null;
        }



    }
}
