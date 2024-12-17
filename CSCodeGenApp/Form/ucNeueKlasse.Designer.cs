namespace CSCodeGenApp.Form
{
    partial class ucNeueKlasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNeueKlasse));
            pnlMain = new Panel();
            splitContainer1 = new SplitContainer();
            pnlFields = new Panel();
            textBox1 = new TextBox();
            lblZugriff = new Label();
            lblNamespace = new Label();
            lblName = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblTemplate = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            panel2 = new Panel();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlFields.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(splitContainer1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(989, 511);
            pnlMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pnlFields);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(255, 255, 192);
            splitContainer1.Size = new Size(989, 511);
            splitContainer1.SplitterDistance = 329;
            splitContainer1.TabIndex = 0;
            // 
            // pnlFields
            // 
            pnlFields.Controls.Add(comboBox1);
            pnlFields.Controls.Add(lblTemplate);
            pnlFields.Controls.Add(textBox3);
            pnlFields.Controls.Add(textBox2);
            pnlFields.Controls.Add(textBox1);
            pnlFields.Controls.Add(lblZugriff);
            pnlFields.Controls.Add(lblNamespace);
            pnlFields.Controls.Add(lblName);
            pnlFields.Dock = DockStyle.Top;
            pnlFields.Location = new Point(0, 0);
            pnlFields.Name = "pnlFields";
            pnlFields.Size = new Size(329, 146);
            pnlFields.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 0;
            // 
            // lblZugriff
            // 
            lblZugriff.AutoSize = true;
            lblZugriff.Location = new Point(19, 108);
            lblZugriff.Name = "lblZugriff";
            lblZugriff.Size = new Size(43, 15);
            lblZugriff.TabIndex = 2;
            lblZugriff.Text = "Zugriff";
            // 
            // lblNamespace
            // 
            lblNamespace.AutoSize = true;
            lblNamespace.Location = new Point(19, 81);
            lblNamespace.Name = "lblNamespace";
            lblNamespace.Size = new Size(69, 15);
            lblNamespace.TabIndex = 1;
            lblNamespace.Text = "Namespace";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 4;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.Location = new Point(19, 24);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(60, 15);
            lblTemplate.TabIndex = 5;
            lblTemplate.Text = "Templates";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(34, 365);
            panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(34, 57);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(32, 20);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(43, 20);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // panel2
            // 
            panel2.Location = new Point(77, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 104);
            panel2.TabIndex = 2;
            // 
            // ucNeueKlasse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Name = "ucNeueKlasse";
            Size = new Size(989, 511);
            pnlMain.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private SplitContainer splitContainer1;
        private Panel pnlFields;
        private Label lblZugriff;
        private Label lblNamespace;
        private Label lblName;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblTemplate;
        private ComboBox comboBox1;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Panel panel2;
    }
}
