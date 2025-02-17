namespace CSCodeGen.UI
{
    partial class ucEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEditor));
            panel1 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            listBox1 = new System.Windows.Forms.ListBox();
            fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(994, 452);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(fastColoredTextBox1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(147, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(847, 452);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(147, 452);
            panel2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(147, 452);
            listBox1.TabIndex = 0;
            // 
            // fastColoredTextBox1
            // 
            fastColoredTextBox1.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.CharHeight = 14;
            fastColoredTextBox1.CharWidth = 8;
            fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            fastColoredTextBox1.Hotkeys = resources.GetString("fastColoredTextBox1.Hotkeys");
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
            fastColoredTextBox1.Size = new System.Drawing.Size(847, 452);
            fastColoredTextBox1.TabIndex = 0;
            fastColoredTextBox1.Text = "fastColoredTextBox1";
            fastColoredTextBox1.Zoom = 100;
            // 
            // ucEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucEditor";
            Size = new System.Drawing.Size(994, 452);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}
