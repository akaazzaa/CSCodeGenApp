
using CSCodeGen.Library.Controller;
using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public partial class frmMain : Form
    {
        private TemplateController controller;
        private FastColoredTextBox fastColoredTextBox;


        public frmMain()
        {
            InitializeComponent();
            toolBar.Renderer = new Renderer();





            /// To DO::
            /// Klassen von der Form trennen 
            /// 
            /// Models anpassen, hinzufügen was noch fehlt (usings, Property, Variabeln, Auswahl an Datentypen mit einem Enum villeicht.
            /// 
            /// Methode zum darstellen von Templates
            /// - string aus Template erstellen erstellen  
            /// - In die FCTB schreiben.
            /// 

            /// Funktion zum erstellen und bearbeiten 
            /// - Template Designer mit <#<NodeClass>#> umd die per laufzeit durch die hinzugfügten Daten zu tauschen. 
            /// - Suchen un ersetzten 
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            controller = new TemplateController();


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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
