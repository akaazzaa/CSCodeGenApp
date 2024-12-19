using FastColoredTextBoxNS;

namespace CSCodeGen.Ui
{
    public class Ui
    {
        public static FastColoredTextBox GetFastColoredTextBox()
        {
            var fastColoredTextBox = new FastColoredTextBox
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


            return fastColoredTextBox;
        }

    }
}
