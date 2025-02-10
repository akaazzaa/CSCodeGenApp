namespace CSCodeGen.UI
{
    partial class TemplateDesignerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateDesignerForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteTextbaustein = new System.Windows.Forms.Button();
            this.btnAddTextbaustein = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ListBoxTemplates = new System.Windows.Forms.ListBox();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ListBoxPlaceholder = new System.Windows.Forms.ListBox();
            this.placeholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1411, 523);
            this.panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 523);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteTextbaustein);
            this.panel4.Controls.Add(this.btnAddTextbaustein);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 251);
            this.panel4.TabIndex = 1;
            // 
            // btnDeleteTextbaustein
            // 
            this.btnDeleteTextbaustein.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteTextbaustein.Location = new System.Drawing.Point(0, 36);
            this.btnDeleteTextbaustein.Name = "btnDeleteTextbaustein";
            this.btnDeleteTextbaustein.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteTextbaustein.TabIndex = 2;
            this.btnDeleteTextbaustein.Text = "Delete";
            this.btnDeleteTextbaustein.UseVisualStyleBackColor = true;
            this.btnDeleteTextbaustein.Click += new System.EventHandler(this.btnDeleteTextbaustein_Click);
            // 
            // btnAddTextbaustein
            // 
            this.btnAddTextbaustein.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTextbaustein.Location = new System.Drawing.Point(0, 13);
            this.btnAddTextbaustein.Name = "btnAddTextbaustein";
            this.btnAddTextbaustein.Size = new System.Drawing.Size(96, 23);
            this.btnAddTextbaustein.TabIndex = 1;
            this.btnAddTextbaustein.Text = "Add";
            this.btnAddTextbaustein.UseVisualStyleBackColor = true;
            this.btnAddTextbaustein.Click += new System.EventHandler(this.btnAddTextbaustein_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Textbaustein";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteTemplate);
            this.panel3.Controls.Add(this.btnAddTemplate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 72);
            this.panel3.TabIndex = 0;
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(0, 36);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteTemplate.TabIndex = 2;
            this.btnDeleteTemplate.Text = "Delete";
            this.btnDeleteTemplate.UseVisualStyleBackColor = true;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTemplate.Location = new System.Drawing.Point(0, 13);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(96, 23);
            this.btnAddTemplate.TabIndex = 1;
            this.btnAddTemplate.Text = "Add";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Templates";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SplitContainerMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(96, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 523);
            this.panel1.TabIndex = 1;
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.ListBoxTemplates);
            this.SplitContainerMain.Panel1MinSize = 100;
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.splitContainer2);
            this.SplitContainerMain.Size = new System.Drawing.Size(1315, 523);
            this.SplitContainerMain.SplitterDistance = 104;
            this.SplitContainerMain.TabIndex = 0;
            // 
            // ListBoxTemplates
            // 
            this.ListBoxTemplates.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.templateBindingSource, "Name", true));
            this.ListBoxTemplates.DataSource = this.templateBindingSource;
            this.ListBoxTemplates.DisplayMember = "Name";
            this.ListBoxTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxTemplates.FormattingEnabled = true;
            this.ListBoxTemplates.Location = new System.Drawing.Point(0, 0);
            this.ListBoxTemplates.MinimumSize = new System.Drawing.Size(100, 4);
            this.ListBoxTemplates.Name = "ListBoxTemplates";
            this.ListBoxTemplates.Size = new System.Drawing.Size(104, 523);
            this.ListBoxTemplates.TabIndex = 0;
            this.ListBoxTemplates.Click += new System.EventHandler(this.ListBoxTemplates_Click);
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(CSCodeGen.DataAccess.Model.Template);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.editor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ListBoxPlaceholder);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(1207, 523);
            this.splitContainer2.SplitterDistance = 1097;
            this.splitContainer2.TabIndex = 0;
            // 
            // editor
            // 
            this.editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editor.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.editor.BackBrush = null;
            this.editor.CharHeight = 14;
            this.editor.CharWidth = 8;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.editor.IsReplaceMode = false;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editor.ServiceColors")));
            this.editor.Size = new System.Drawing.Size(1097, 523);
            this.editor.TabIndex = 0;
            this.editor.Text = "fastColoredTextBox1";
            this.editor.Zoom = 100;
            // 
            // ListBoxPlaceholder
            // 
            this.ListBoxPlaceholder.DataSource = this.placeholderBindingSource;
            this.ListBoxPlaceholder.DisplayMember = "Name";
            this.ListBoxPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxPlaceholder.FormattingEnabled = true;
            this.ListBoxPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPlaceholder.MinimumSize = new System.Drawing.Size(122, 4);
            this.ListBoxPlaceholder.Name = "ListBoxPlaceholder";
            this.ListBoxPlaceholder.Size = new System.Drawing.Size(122, 523);
            this.ListBoxPlaceholder.TabIndex = 0;
            // 
            // placeholderBindingSource
            // 
            this.placeholderBindingSource.DataSource = typeof(CSCodeGen.DataAccess.Model.Textbaustein);
            // 
            // TemplateDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 523);
            this.Controls.Add(this.panelMain);
            this.Name = "TemplateDesignerForm";
            this.Text = "TemplateDesignerForm";
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private FastColoredTextBoxNS.FastColoredTextBox editor;
        private System.Windows.Forms.ListBox ListBoxTemplates;
        private System.Windows.Forms.ListBox ListBoxPlaceholder;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.BindingSource placeholderBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTextbaustein;
        private System.Windows.Forms.Button btnAddTextbaustein;
    }
}