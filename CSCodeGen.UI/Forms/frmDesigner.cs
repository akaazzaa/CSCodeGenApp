
using CSCodeGen.DataAccess.Model;
using CSCodeGen.UI.Forms;
using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public partial class frmDesigner : System.Windows.Forms.Form
    {
        FastColoredTextBox fastColoredTextBox;
      
        private Point dragStartPoint;
        public object lb_item = null;
        private Template currentTemplate;


        public frmDesigner()
        {
            InitializeComponent();

           

            //templateBindingSource1.DataSource = templates;
            //placeholderBindingSource.DataSource = placeholders;

            fastColoredTextBox = Ui.GetFastColoredTextBox();
            fastColoredTextBox.TextChanged += TextChanged;
            

            pnlEditor.Controls.Add(fastColoredTextBox);

            currentTemplate = (Template)listBox1.Items[0];
            if (currentTemplate == null) { return; }
            fastColoredTextBox.Text = currentTemplate.Content;
        }

       

        private void TextChanged(object? sender, TextChangedEventArgs e)
        {
            if (currentTemplate == null) { return; }
            currentTemplate.Content = fastColoredTextBox.Text;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template();


            //frmTemName temName = new frmTemName(currentTemplate);
            //if (temName.ShowDialog() == DialogResult.OK)
            //{
            //    templates.Add(currentTemplate);
            //    templateBindingSource1.ResetBindings(false);
            //}

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
            if (placeholder == null) return;

            // Speichere die aktuelle Cursor-Position
            int startPosition = fastColoredTextBox.SelectionStart;

            // Platzhalter einfügen
            fastColoredTextBox.InsertText(placeholder.DefaultValue);

            // Markiere den eingefügten Text
            fastColoredTextBox.SelectionStart = startPosition;
            fastColoredTextBox.SelectionLength = placeholder.DefaultValue.Length;
        }
        private void listBox2_DragLeave(object sender, EventArgs e)
        {
            if (lb_item != null)
            {
                listBox2.Items.Remove(lb_item);
                lb_item = null;
            }
        }
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {

            if (lb_item != null && !listBox2.Items.Contains(lb_item))
            {
                listBox2.Items.Add(lb_item);
                lb_item = null;
            }
        }
        private void listBox2_MouseMove(object sender, MouseEventArgs e)
        {
            // Prüfe, ob die Maus weit genug bewegt wurde, um einen Drag-Vorgang zu starten
            if (e.Button == MouseButtons.Left &&
                Math.Abs(e.X - dragStartPoint.X) > SystemInformation.DragSize.Width / 2 &&
                Math.Abs(e.Y - dragStartPoint.Y) > SystemInformation.DragSize.Height / 2)
            {
                // Hole das ausgewählte Element
                int index = listBox2.IndexFromPoint(dragStartPoint);
                if (index >= 0 && index < listBox2.Items.Count)
                {
                    lb_item = listBox2.Items[index];
                    DoDragDrop(lb_item.ToString(), DragDropEffects.Copy);
                }
            }
        }
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {

            dragStartPoint = e.Location;

        }
        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            lb_item = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
