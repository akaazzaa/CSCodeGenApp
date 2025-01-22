namespace CSCodeGen.Ui
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
            gcMethods = new DataGridView();
            lblMethoden = new Label();
            gcProps = new DataGridView();
            lblProperties = new Label();
            label1 = new Label();
            pnlToolbar = new Panel();
            pnlToolbar2 = new Panel();
            toolStrip2 = new ToolStrip();
            btnAddMethods = new ToolStripButton();
            btnDeleteMethods = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            btnAddProperties = new ToolStripButton();
            btnDeleteProperties = new ToolStripButton();
            pnlFields = new Panel();
            btnGenerate = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblTemplate = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblZugriff = new Label();
            lblNamespace = new Label();
            lblName = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcMethods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcProps).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlToolbar2.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlFields.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(gcMethods);
            splitContainer1.Panel1.Controls.Add(lblMethoden);
            splitContainer1.Panel1.Controls.Add(gcProps);
            splitContainer1.Panel1.Controls.Add(lblProperties);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pnlToolbar);
            splitContainer1.Panel1.Controls.Add(pnlFields);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(255, 255, 192);
            splitContainer1.Size = new Size(989, 511);
            splitContainer1.SplitterDistance = 540;
            splitContainer1.TabIndex = 0;
            // 
            // gcMethods
            // 
            gcMethods.AllowUserToAddRows = false;
            gcMethods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gcMethods.BorderStyle = BorderStyle.None;
            gcMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gcMethods.Dock = DockStyle.Top;
            gcMethods.Location = new Point(58, 350);
            gcMethods.MultiSelect = false;
            gcMethods.Name = "gcMethods";
            gcMethods.Size = new Size(482, 161);
            gcMethods.TabIndex = 6;
            // 
            // lblMethoden
            // 
            lblMethoden.AutoSize = true;
            lblMethoden.Dock = DockStyle.Top;
            lblMethoden.Location = new Point(58, 335);
            lblMethoden.Name = "lblMethoden";
            lblMethoden.Size = new Size(62, 15);
            lblMethoden.TabIndex = 5;
            lblMethoden.Text = "Methoden";
            // 
            // gcProps
            // 
            gcProps.AllowUserToAddRows = false;
            gcProps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gcProps.BorderStyle = BorderStyle.None;
            gcProps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gcProps.Dock = DockStyle.Top;
            gcProps.Location = new Point(58, 161);
            gcProps.MultiSelect = false;
            gcProps.Name = "gcProps";
            gcProps.Size = new Size(482, 174);
            gcProps.TabIndex = 4;
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Dock = DockStyle.Top;
            lblProperties.Location = new Point(58, 146);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(60, 15);
            lblProperties.TabIndex = 3;
            lblProperties.Text = "Properties";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Klasse Eigenschaft";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.ControlDarkDark;
            pnlToolbar.Controls.Add(pnlToolbar2);
            pnlToolbar.Controls.Add(toolStrip1);
            pnlToolbar.Dock = DockStyle.Left;
            pnlToolbar.Location = new Point(0, 146);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(58, 365);
            pnlToolbar.TabIndex = 1;
            // 
            // pnlToolbar2
            // 
            pnlToolbar2.Controls.Add(toolStrip2);
            pnlToolbar2.Dock = DockStyle.Bottom;
            pnlToolbar2.Location = new Point(0, 189);
            pnlToolbar2.Name = "pnlToolbar2";
            pnlToolbar2.Size = new Size(58, 176);
            pnlToolbar2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = SystemColors.ControlDarkDark;
            toolStrip2.Dock = DockStyle.Fill;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAddMethods, btnDeleteMethods });
            toolStrip2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(58, 176);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAddMethods
            // 
            btnAddMethods.BackColor = SystemColors.ButtonShadow;
            btnAddMethods.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAddMethods.Image = (Image)resources.GetObject("btnAddMethods.Image");
            btnAddMethods.ImageTransparentColor = Color.Magenta;
            btnAddMethods.Name = "btnAddMethods";
            btnAddMethods.Size = new Size(56, 19);
            btnAddMethods.Text = "+";
            // 
            // btnDeleteMethods
            // 
            btnDeleteMethods.BackColor = SystemColors.ButtonShadow;
            btnDeleteMethods.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDeleteMethods.Image = (Image)resources.GetObject("btnDeleteMethods.Image");
            btnDeleteMethods.ImageTransparentColor = Color.Magenta;
            btnDeleteMethods.Name = "btnDeleteMethods";
            btnDeleteMethods.Size = new Size(56, 19);
            btnDeleteMethods.Text = "-";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlDarkDark;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddProperties, btnDeleteProperties });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(58, 365);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddProperties
            // 
            btnAddProperties.BackColor = SystemColors.ButtonShadow;
            btnAddProperties.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAddProperties.Image = (Image)resources.GetObject("btnAddProperties.Image");
            btnAddProperties.ImageTransparentColor = Color.Magenta;
            btnAddProperties.Name = "btnAddProperties";
            btnAddProperties.Size = new Size(56, 19);
            btnAddProperties.Text = "+";
            // 
            // btnDeleteProperties
            // 
            btnDeleteProperties.BackColor = SystemColors.ButtonShadow;
            btnDeleteProperties.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDeleteProperties.Image = (Image)resources.GetObject("btnDeleteProperties.Image");
            btnDeleteProperties.ImageTransparentColor = Color.Magenta;
            btnDeleteProperties.Name = "btnDeleteProperties";
            btnDeleteProperties.Size = new Size(56, 19);
            btnDeleteProperties.Text = "-";
            // 
            // pnlFields
            // 
            pnlFields.BackColor = SystemColors.ControlDarkDark;
            pnlFields.Controls.Add(btnGenerate);
            pnlFields.Controls.Add(comboBox2);
            pnlFields.Controls.Add(comboBox1);
            pnlFields.Controls.Add(lblTemplate);
            pnlFields.Controls.Add(textBox2);
            pnlFields.Controls.Add(textBox1);
            pnlFields.Controls.Add(lblZugriff);
            pnlFields.Controls.Add(lblNamespace);
            pnlFields.Controls.Add(lblName);
            pnlFields.Dock = DockStyle.Top;
            pnlFields.Location = new Point(0, 0);
            pnlFields.Name = "pnlFields";
            pnlFields.Size = new Size(540, 146);
            pnlFields.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Location = new Point(462, 108);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(94, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 6;
            // 
            // lblTemplate
            // 
            lblTemplate.AutoSize = true;
            lblTemplate.ForeColor = SystemColors.Control;
            lblTemplate.Location = new Point(19, 24);
            lblTemplate.Name = "lblTemplate";
            lblTemplate.Size = new Size(61, 15);
            lblTemplate.TabIndex = 5;
            lblTemplate.Text = "Templates";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 3;
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
            lblZugriff.ForeColor = SystemColors.Control;
            lblZugriff.Location = new Point(19, 108);
            lblZugriff.Name = "lblZugriff";
            lblZugriff.Size = new Size(43, 15);
            lblZugriff.TabIndex = 2;
            lblZugriff.Text = "Zugriff";
            // 
            // lblNamespace
            // 
            lblNamespace.AutoSize = true;
            lblNamespace.ForeColor = SystemColors.Control;
            lblNamespace.Location = new Point(19, 81);
            lblNamespace.Name = "lblNamespace";
            lblNamespace.Size = new Size(69, 15);
            lblNamespace.TabIndex = 1;
            lblNamespace.Text = "Namespace";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(19, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
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
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcMethods).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcProps).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlToolbar2.ResumeLayout(false);
            pnlToolbar2.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
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
        private TextBox textBox2;
        private Label lblTemplate;
        private ComboBox comboBox1;
        private Panel pnlToolbar;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAddProperties;
        private ToolStripButton btnDeleteProperties;
        private DataGridView gcMethods;
        private Label lblMethoden;
        private DataGridView gcProps;
        private Label lblProperties;
        private Label label1;
        private Panel pnlToolbar2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAddMethods;
        private ToolStripButton btnDeleteMethods;
        private DataGridViewTextBoxColumn zugriffDataGridViewTextBoxColumn;
        private ComboBox comboBox2;
        private Button btnGenerate;
    }
}
