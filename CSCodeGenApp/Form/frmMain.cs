using CSCodeGenApp.Controller;
using FastColoredTextBoxNS;

namespace CSCodeGENExtension
{
    public partial class frmMain : Form
    {
        private TemplateController controller;
        private FastColoredTextBox fastColoredTextBox;

        public frmMain()
        {
            InitializeComponent();

            fastColoredTextBox = new FastColoredTextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 12),
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                LineNumberColor = Color.Gray,
                IndentBackColor = Color.FromArgb(45, 45, 48),
                ServiceLinesColor = Color.FromArgb(60, 60, 60),
                SelectionColor = Color.FromArgb(75, 110, 175),
                Paddings = new Padding(10)
            };

            fastColoredTextBox.Language = Language.CSharp;
            fastColoredTextBox.SyntaxHighlighter.CommentStyle = new TextStyle(Brushes.DarkGreen, null, FontStyle.Italic);
            fastColoredTextBox.SyntaxHighlighter.KeywordStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Bold);
            fastColoredTextBox.SyntaxHighlighter.StringStyle = new TextStyle(Brushes.LightCoral, null, FontStyle.Regular);
            fastColoredTextBox.SyntaxHighlighter.NumberStyle = new TextStyle(Brushes.LightGoldenrodYellow, null, FontStyle.Regular);
            fastColoredTextBox.Dock = DockStyle.Fill;
            fastColoredTextBox.Text = "using System;\r\n\r\npublic class Person\r\n{\r\n    // Felder (Variablen)\r\n    private string _name;\r\n    private int _age;\r\n\r\n    // Eigenschaft für Name\r\n    public string Name\r\n    {\r\n        get { return _name; }\r\n        set\r\n        {\r\n            if (!string.IsNullOrWhiteSpace(value))\r\n                _name = value;\r\n            else\r\n                throw new ArgumentException(\"Name darf nicht leer sein.\");\r\n        }\r\n    }\r\n\r\n    // Eigenschaft für Alter\r\n    public int Age\r\n    {\r\n        get { return _age; }\r\n        set\r\n        {\r\n            if (value >= 0)\r\n                _age = value;\r\n            else\r\n                throw new ArgumentException(\"Alter muss positiv sein.\");\r\n        }\r\n    }\r\n\r\n    // Standardkonstruktor\r\n    public Person()\r\n    {\r\n        _name = \"Unbekannt\";\r\n        _age = 0;\r\n    }\r\n\r\n    // Überladener Konstruktor\r\n    public Person(string name, int age)\r\n    {\r\n        Name = name;\r\n        Age = age;\r\n    }\r\n\r\n    // Methode zur Ausgabe der Personendetails\r\n    public void PrintDetails()\r\n    {\r\n        Console.WriteLine($\"Name: {Name}, Alter: {Age}\");\r\n    }\r\n\r\n    // Methode zur Geburtstagsfeier\r\n    public void CelebrateBirthday()\r\n    {\r\n        Age++;\r\n        Console.WriteLine($\"Alles Gute zum Geburtstag, {Name}! Du bist jetzt {Age} Jahre alt.\");\r\n    }\r\n\r\n    // Statische Methode\r\n    public static void Greet()\r\n    {\r\n        Console.WriteLine(\"Hallo! Willkommen im Personensystem.\");\r\n    }\r\n}";
            pnlEditor.Controls.Add(fastColoredTextBox);

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

            bsDaten.DataSource = controller.dataModel;
        }
    }
}
