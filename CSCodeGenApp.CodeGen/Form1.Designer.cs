﻿namespace CSCodeGenApp.CodeGen
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
            panel1 = new Panel();
            pnlProperties = new Panel();
            dataGridView1 = new DataGridView();
            bsProperties = new BindingSource(components);
            pnlPropetiesBar = new Panel();
            btnPropertiesDelete = new Button();
            btnPropertiesAdd = new Button();
            pnlMenu = new Panel();
            cbTemplate = new ComboBox();
            bsDaten = new BindingSource(components);
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlEditor = new Panel();
            fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            pnlTop = new Panel();
            menu = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Datentyp = new DataGridViewComboBoxColumn();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spMain).BeginInit();
            spMain.Panel1.SuspendLayout();
            spMain.Panel2.SuspendLayout();
            spMain.SuspendLayout();
            pnlAuswahl.SuspendLayout();
            panel1.SuspendLayout();
            pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProperties).BeginInit();
            pnlPropetiesBar.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).BeginInit();
            pnlEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
            pnlTop.SuspendLayout();
            menu.SuspendLayout();
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
            pnlAuswahl.BorderStyle = BorderStyle.FixedSingle;
            pnlAuswahl.Controls.Add(panel1);
            pnlAuswahl.Controls.Add(pnlMenu);
            pnlAuswahl.Dock = DockStyle.Fill;
            pnlAuswahl.Location = new Point(0, 0);
            pnlAuswahl.Name = "pnlAuswahl";
            pnlAuswahl.Size = new Size(463, 450);
            pnlAuswahl.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pnlProperties);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 340);
            panel1.TabIndex = 1;
            // 
            // pnlProperties
            // 
            pnlProperties.BorderStyle = BorderStyle.Fixed3D;
            pnlProperties.Controls.Add(dataGridView1);
            pnlProperties.Controls.Add(pnlPropetiesBar);
            pnlProperties.Dock = DockStyle.Fill;
            pnlProperties.Location = new Point(0, 0);
            pnlProperties.Name = "pnlProperties";
            pnlProperties.Size = new Size(459, 338);
            pnlProperties.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, Datentyp });
            dataGridView1.DataSource = bsProperties;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(29, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(426, 334);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValidated += dataGridView1_CellValidated;
            // 
            // bsProperties
            // 
            bsProperties.DataSource = typeof(CSCodeGen.DataAccess.Model.Propertie);
            // 
            // pnlPropetiesBar
            // 
            pnlPropetiesBar.Controls.Add(btnPropertiesDelete);
            pnlPropetiesBar.Controls.Add(btnPropertiesAdd);
            pnlPropetiesBar.Dock = DockStyle.Left;
            pnlPropetiesBar.Location = new Point(0, 0);
            pnlPropetiesBar.Name = "pnlPropetiesBar";
            pnlPropetiesBar.Size = new Size(29, 334);
            pnlPropetiesBar.TabIndex = 0;
            // 
            // btnPropertiesDelete
            // 
            btnPropertiesDelete.Dock = DockStyle.Top;
            btnPropertiesDelete.Location = new Point(0, 23);
            btnPropertiesDelete.Name = "btnPropertiesDelete";
            btnPropertiesDelete.Size = new Size(29, 23);
            btnPropertiesDelete.TabIndex = 1;
            btnPropertiesDelete.Text = "-";
            btnPropertiesDelete.UseVisualStyleBackColor = true;
            btnPropertiesDelete.Click += btnPropertiesDelete_Click;
            // 
            // btnPropertiesAdd
            // 
            btnPropertiesAdd.Dock = DockStyle.Top;
            btnPropertiesAdd.Location = new Point(0, 0);
            btnPropertiesAdd.Name = "btnPropertiesAdd";
            btnPropertiesAdd.Size = new Size(29, 23);
            btnPropertiesAdd.TabIndex = 0;
            btnPropertiesAdd.Text = "+";
            btnPropertiesAdd.UseVisualStyleBackColor = true;
            btnPropertiesAdd.Click += btnPropertiesAdd_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(cbTemplate);
            pnlMenu.Controls.Add(txtName);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(461, 108);
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
            cbTemplate.SelectedIndexChanged += cbTemplate_SelectedIndexChanged;
            // 
            // bsDaten
            // 
            bsDaten.DataSource = typeof(CSCodeGen.DataAccess.Model.Template);
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Template";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 63);
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
            fastColoredTextBox1.AutoScrollMinSize = new Size(67, 14);
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.CharHeight = 14;
            fastColoredTextBox1.CharWidth = 8;
            fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Dock = DockStyle.Fill;
            fastColoredTextBox1.Font = new Font("Courier New", 9.75F);
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.Location = new Point(0, 29);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new Padding(0);
            fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = null;
            fastColoredTextBox1.Size = new Size(523, 421);
            fastColoredTextBox1.TabIndex = 1;
            fastColoredTextBox1.Text = "     ";
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
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Datentyp
            // 
            Datentyp.DataPropertyName = "DataType";
            Datentyp.HeaderText = "Datentyp";
            Datentyp.Items.AddRange(new object[] { "int", "bool", "string", "float", "Date" });
            Datentyp.Name = "Datentyp";
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
            panel1.ResumeLayout(false);
            pnlProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProperties).EndInit();
            pnlPropetiesBar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).EndInit();
            pnlEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
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
        private Panel panel1;
        private Panel pnlProperties;
        private Panel pnlPropetiesBar;
        private Button btnPropertiesDelete;
        private Button btnPropertiesAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private BindingSource bsProperties;
        private DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Datentyp;
    }
}
