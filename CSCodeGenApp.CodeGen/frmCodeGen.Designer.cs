
using CSCodeGen.Model;
using CSCodeGen.Model.Main;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            spMain = new SplitContainer();
            pnlAuswahl = new Panel();
            panel1 = new Panel();
            pnlProperties = new Panel();
            gvUserValues = new DataGridView();
            gvtxtValue = new DataGridViewTextBoxColumn();
            gvcbType = new DataGridViewComboBoxColumn();
            bsUserValues = new BindingSource(components);
            bsResult = new BindingSource(components);
            pnlPropetiesBar = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            pnlMenu = new Panel();
            btnGenerate = new Button();
            cbTemplate = new ComboBox();
            bsDaten = new BindingSource(components);
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlEditor = new Panel();
            pnlEditorMain = new Panel();
            pnlTop = new Panel();
            menu = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spMain).BeginInit();
            spMain.Panel1.SuspendLayout();
            spMain.Panel2.SuspendLayout();
            spMain.SuspendLayout();
            pnlAuswahl.SuspendLayout();
            panel1.SuspendLayout();
            pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvUserValues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUserValues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsResult).BeginInit();
            pnlPropetiesBar.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).BeginInit();
            pnlEditor.SuspendLayout();
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
            panel1.Location = new Point(0, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 248);
            panel1.TabIndex = 1;
            // 
            // pnlProperties
            // 
            pnlProperties.BorderStyle = BorderStyle.Fixed3D;
            pnlProperties.Controls.Add(gvUserValues);
            pnlProperties.Controls.Add(pnlPropetiesBar);
            pnlProperties.Dock = DockStyle.Fill;
            pnlProperties.Location = new Point(0, 0);
            pnlProperties.Name = "pnlProperties";
            pnlProperties.Size = new Size(459, 246);
            pnlProperties.TabIndex = 0;
            // 
            // gvUserValues
            // 
            gvUserValues.AllowUserToAddRows = false;
            gvUserValues.AllowUserToDeleteRows = false;
            gvUserValues.AllowUserToResizeColumns = false;
            gvUserValues.AllowUserToResizeRows = false;
            gvUserValues.AutoGenerateColumns = false;
            gvUserValues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvUserValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvUserValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvUserValues.Columns.AddRange(new DataGridViewColumn[] { gvtxtValue, gvcbType });
            gvUserValues.DataSource = bsUserValues;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gvUserValues.DefaultCellStyle = dataGridViewCellStyle2;
            gvUserValues.Dock = DockStyle.Fill;
            gvUserValues.Location = new Point(29, 0);
            gvUserValues.Name = "gvUserValues";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gvUserValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gvUserValues.Size = new Size(426, 242);
            gvUserValues.TabIndex = 1;
            // 
            // gvtxtValue
            // 
            gvtxtValue.DataPropertyName = "Value";
            gvtxtValue.HeaderText = "Value";
            gvtxtValue.Name = "gvtxtValue";
            // 
            // gvcbType
            // 
            gvcbType.DataPropertyName = "Type";
            gvcbType.HeaderText = "Type";
            gvcbType.Name = "gvcbType";
            gvcbType.Resizable = DataGridViewTriState.True;
            gvcbType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // bsUserValues
            // 
            bsUserValues.DataMember = "userValues";
            bsUserValues.DataSource = bsResult;
            // 
            // bsResult
            // 
            bsResult.DataSource = typeof(Result);
            // 
            // pnlPropetiesBar
            // 
            pnlPropetiesBar.Controls.Add(btnDelete);
            pnlPropetiesBar.Controls.Add(btnAdd);
            pnlPropetiesBar.Dock = DockStyle.Left;
            pnlPropetiesBar.Location = new Point(0, 0);
            pnlPropetiesBar.Name = "pnlPropetiesBar";
            pnlPropetiesBar.Size = new Size(29, 242);
            pnlPropetiesBar.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Location = new Point(0, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(29, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "-";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(btnGenerate);
            pnlMenu.Controls.Add(cbTemplate);
            pnlMenu.Controls.Add(txtName);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(461, 200);
            pnlMenu.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(347, 153);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(95, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
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
            // bsDaten
            // 
            bsDaten.DataSource = typeof(Template);
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", bsResult, "Name", true));
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
            label2.Size = new Size(56, 15);
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
            pnlEditor.Controls.Add(pnlEditorMain);
            pnlEditor.Controls.Add(pnlTop);
            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Location = new Point(0, 0);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(523, 450);
            pnlEditor.TabIndex = 0;
            // 
            // pnlEditorMain
            // 
            pnlEditorMain.Dock = DockStyle.Fill;
            pnlEditorMain.Location = new Point(0, 29);
            pnlEditorMain.Name = "pnlEditorMain";
            pnlEditorMain.Size = new Size(523, 421);
            pnlEditorMain.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)gvUserValues).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUserValues).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsResult).EndInit();
            pnlPropetiesBar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).EndInit();
            pnlEditor.ResumeLayout(false);
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
        private Panel pnlMenu;
        private Label label2;
        private Label label1;
        private ComboBox cbTemplate;
        private TextBox txtName;
        private BindingSource bsDaten;
        private Panel panel1;
        private Panel pnlProperties;
        private Panel pnlPropetiesBar;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView gvUserValues;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private Panel pnlEditorMain;
        private Button btnGenerate;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource bsUserValues;
        private BindingSource bsResult;
        private DataGridViewTextBoxColumn gvtxtValue;
        private DataGridViewComboBoxColumn gvcbType;
    }
}
