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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNeueKlasse));
            pnlMain = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridView2 = new DataGridView();
            zugriffDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modifiziererDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rückgabewertDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            methodsBindingSource = new BindingSource(components);
            lblMethoden = new Label();
            dataGridView1 = new DataGridView();
            accessTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            propertiesBindingSource = new BindingSource(components);
            lblProperties = new Label();
            label1 = new Label();
            pnlToolbar = new Panel();
            pnlToolbar2 = new Panel();
            toolStrip2 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            pnlFields = new Panel();
            comboBox1 = new ComboBox();
            templateBindingSource = new BindingSource(components);
            lblTemplate = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblZugriff = new Label();
            lblNamespace = new Label();
            lblName = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)methodsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertiesBindingSource).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlToolbar2.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dataGridView2);
            splitContainer1.Panel1.Controls.Add(lblMethoden);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
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
            splitContainer1.SplitterDistance = 477;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { zugriffDataGridViewTextBoxColumn, modifiziererDataGridViewTextBoxColumn, rückgabewertDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = methodsBindingSource;
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.Location = new Point(33, 350);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(444, 161);
            dataGridView2.TabIndex = 6;
            // 
            // zugriffDataGridViewTextBoxColumn
            // 
            zugriffDataGridViewTextBoxColumn.DataPropertyName = "Zugriff";
            zugriffDataGridViewTextBoxColumn.HeaderText = "Zugriff";
            zugriffDataGridViewTextBoxColumn.Name = "zugriffDataGridViewTextBoxColumn";
            // 
            // modifiziererDataGridViewTextBoxColumn
            // 
            modifiziererDataGridViewTextBoxColumn.DataPropertyName = "Modifizierer";
            modifiziererDataGridViewTextBoxColumn.HeaderText = "Modifizierer";
            modifiziererDataGridViewTextBoxColumn.Name = "modifiziererDataGridViewTextBoxColumn";
            // 
            // rückgabewertDataGridViewTextBoxColumn
            // 
            rückgabewertDataGridViewTextBoxColumn.DataPropertyName = "Rückgabewert";
            rückgabewertDataGridViewTextBoxColumn.HeaderText = "Rückgabewert";
            rückgabewertDataGridViewTextBoxColumn.Name = "rückgabewertDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // methodsBindingSource
            // 
            methodsBindingSource.DataMember = "Methods";
            methodsBindingSource.DataSource = typeof(Library.Klassen.Template.Template);
            // 
            // lblMethoden
            // 
            lblMethoden.AutoSize = true;
            lblMethoden.Dock = DockStyle.Top;
            lblMethoden.Location = new Point(33, 335);
            lblMethoden.Name = "lblMethoden";
            lblMethoden.Size = new Size(62, 15);
            lblMethoden.TabIndex = 5;
            lblMethoden.Text = "Methoden";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { accessTypeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = propertiesBindingSource;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(33, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 174);
            dataGridView1.TabIndex = 4;
            // 
            // accessTypeDataGridViewTextBoxColumn
            // 
            accessTypeDataGridViewTextBoxColumn.DataPropertyName = "AccessType";
            accessTypeDataGridViewTextBoxColumn.HeaderText = "AccessType";
            accessTypeDataGridViewTextBoxColumn.Name = "accessTypeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // propertiesBindingSource
            // 
            propertiesBindingSource.DataMember = "Properties";
            propertiesBindingSource.DataSource = typeof(Library.Klassen.Template.Template);
            // 
            // lblProperties
            // 
            lblProperties.AutoSize = true;
            lblProperties.Dock = DockStyle.Top;
            lblProperties.Location = new Point(33, 146);
            lblProperties.Name = "lblProperties";
            lblProperties.Size = new Size(60, 15);
            lblProperties.TabIndex = 3;
            lblProperties.Text = "Properties";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(pnlToolbar2);
            pnlToolbar.Controls.Add(toolStrip1);
            pnlToolbar.Dock = DockStyle.Left;
            pnlToolbar.Location = new Point(0, 146);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(33, 365);
            pnlToolbar.TabIndex = 1;
            // 
            // pnlToolbar2
            // 
            pnlToolbar2.Controls.Add(toolStrip2);
            pnlToolbar2.Dock = DockStyle.Bottom;
            pnlToolbar2.Location = new Point(0, 204);
            pnlToolbar2.Name = "pnlToolbar2";
            pnlToolbar2.Size = new Size(33, 161);
            pnlToolbar2.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton4 });
            toolStrip2.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(33, 48);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(31, 20);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(31, 20);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(33, 48);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(31, 20);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(31, 20);
            toolStripButton2.Text = "toolStripButton2";
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
            pnlFields.Size = new Size(477, 146);
            pnlFields.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", templateBindingSource, "TemplateName", true));
            comboBox1.DataSource = templateBindingSource;
            comboBox1.DisplayMember = "TemplateName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 6;
            // 
            // templateBindingSource
            // 
            templateBindingSource.DataSource = typeof(Library.Klassen.Template.Template);
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
            // textBox3
            // 
            textBox3.Location = new Point(94, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 4;
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
            textBox1.DataBindings.Add(new Binding("Text", templateBindingSource, "ClassName", true, DataSourceUpdateMode.OnPropertyChanged));
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)methodsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertiesBindingSource).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).EndInit();
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
        private Panel pnlToolbar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private DataGridView dataGridView2;
        private Label lblMethoden;
        private DataGridView dataGridView1;
        private Label lblProperties;
        private Label label1;
        private Panel pnlToolbar2;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private DataGridViewTextBoxColumn zugriffDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modifiziererDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rückgabewertDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource methodsBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource propertiesBindingSource;
        private BindingSource templateBindingSource;
        private DataGridViewTextBoxColumn accessTypeDataGridViewTextBoxColumn;
    }
}
