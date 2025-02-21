namespace CSCodeGenApp.CodeGen
{
    partial class frmCodeGen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGen));
            pnlMain = new Panel();
            spMain = new SplitContainer();
            pnlAuswahl = new Panel();
            pnlMenu = new Panel();
            cbTemplate = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlEditor = new Panel();
            fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            pnlTop = new Panel();
            menu = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            bsDaten = new BindingSource(components);
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spMain).BeginInit();
            spMain.Panel1.SuspendLayout();
            spMain.Panel2.SuspendLayout();
            spMain.SuspendLayout();
            pnlAuswahl.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
            pnlTop.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(spMain);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(990, 450);
            pnlMain.TabIndex = 0;
            // 
            // spMain
            // 
            spMain.Dock = DockStyle.Fill;
            spMain.Location = new Point(0, 0);
            spMain.Name = "spMain";
            // 
            // spMain.Panel1
            // 
            spMain.Panel1.Controls.Add(pnlAuswahl);
            // 
            // spMain.Panel2
            // 
            spMain.Panel2.Controls.Add(pnlEditor);
            spMain.Size = new Size(990, 450);
            spMain.SplitterDistance = 463;
            spMain.TabIndex = 0;
            // 
            // pnlAuswahl
            // 
            pnlAuswahl.Controls.Add(pnlMenu);
            pnlAuswahl.Dock = DockStyle.Fill;
            pnlAuswahl.Location = new Point(0, 0);
            pnlAuswahl.Name = "pnlAuswahl";
            pnlAuswahl.Size = new Size(463, 450);
            pnlAuswahl.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(cbTemplate);
            pnlMenu.Controls.Add(txtName);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(463, 130);
            pnlMenu.TabIndex = 0;
            // 
            // cbTemplate
            // 
            cbTemplate.DataSource = bsDaten;
            cbTemplate.DisplayMember = "Name";
            cbTemplate.FormattingEnabled = true;
            cbTemplate.Location = new Point(117, 26);
            cbTemplate.Name = "cbTemplate";
            cbTemplate.Size = new Size(229, 23);
            cbTemplate.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Template";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Klassen Name ";
            // 
            // pnlEditor
            // 
            pnlEditor.Controls.Add(fastColoredTextBox1);
            pnlEditor.Controls.Add(pnlTop);
            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Location = new Point(0, 0);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(523, 450);
            pnlEditor.TabIndex = 0;
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
            fastColoredTextBox1.AutoScrollMinSize = new Size(27, 14);
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.CharHeight = 14;
            fastColoredTextBox1.CharWidth = 8;
            fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Dock = DockStyle.Fill;
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.Location = new Point(0, 29);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new Padding(0);
            fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
            fastColoredTextBox1.Size = new Size(523, 421);
            fastColoredTextBox1.TabIndex = 1;
            fastColoredTextBox1.Zoom = 100;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(menu);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(523, 29);
            pnlTop.TabIndex = 0;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, removeToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(523, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(62, 20);
            removeToolStripMenuItem.Text = "Remove";
            // 
            // bsDaten
            // 
            bsDaten.DataSource = typeof(CSCodeGen.DataAccess.Model.Template);
            // 
            // frmCodeGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 450);
            Controls.Add(pnlMain);
            MainMenuStrip = menu;
            Name = "frmCodeGen";
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            spMain.Panel1.ResumeLayout(false);
            spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spMain).EndInit();
            spMain.ResumeLayout(false);
            pnlAuswahl.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private SplitContainer spMain;
        private Panel pnlAuswahl;
        private Panel pnlEditor;
        private Panel pnlTop;
        private MenuStrip menu;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private Panel pnlMenu;
        private Label label2;
        private Label label1;
        private ComboBox cbTemplate;
        private TextBox txtName;
        private BindingSource bsDaten;
    }
}
