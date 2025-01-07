using FastColoredTextBoxNS;


namespace CSCodeGen.Ui
{
    public partial class ucNeueKlasse : UserControl
    {

        FastColoredTextBox fastColoredTextBox;
        public ucNeueKlasse()
        {
            InitializeComponent();




            fastColoredTextBox = Ui.GetFastColoredTextBox();
            splitContainer1.Panel2.Controls.Add(fastColoredTextBox);




        }



    }
}
