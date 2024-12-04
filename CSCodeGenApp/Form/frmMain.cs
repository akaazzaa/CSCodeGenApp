using CSCodeGenApp.Controller;
using FastColoredTextBoxNS;

namespace CSCodeGENExtension
{
    public partial class frmMain : Form
    {
        TemplateController controller;

        public frmMain()
        {
            InitializeComponent();

            /// TO DO:: Text Box richtig einstellen 
            FastColoredTextBox fastColoredTextBox = new FastColoredTextBox();
            fastColoredTextBox.Language = Language.CSharp;
            //pnlEditor.Controls.Add(fastColoredTextBox);
            fastColoredTextBox.Dock = DockStyle.Fill;
            fastColoredTextBox.BackColor = Color.Khaki;



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


    }
}
