namespace CSCodeGen.Ui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            toolBar.Renderer = new Renderer();
        }

        private void btnNeueKlasse_Click(object sender, EventArgs e)
        {
            ucNeueKlasse classWindow = new ucNeueKlasse();
            classWindow.Dock = DockStyle.Fill;
            AddNewTab(classWindow);

        }

        private void AddNewTab(UserControl userControl)
        {

            TabPage tabPage = new TabPage();
            tabPage.Text = "Neue Klasse";
            tabPage.Controls.Add(userControl);
            tabMain.TabPages.Add(tabPage);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmDesigner frmDesigner = new frmDesigner();
            if (frmDesigner.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
