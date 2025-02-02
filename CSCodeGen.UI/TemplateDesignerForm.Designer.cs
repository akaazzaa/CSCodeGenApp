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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxTemplates = new System.Windows.Forms.ListBox();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.listBoxPlaceholder = new System.Windows.Forms.ListBox();
            this.placeholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(968, 450);
            this.panelMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxTemplates);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(968, 450);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxTemplates
            // 
            this.listBoxTemplates.DataSource = this.templateBindingSource;
            this.listBoxTemplates.DisplayMember = "Name";
            this.listBoxTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTemplates.FormattingEnabled = true;
            this.listBoxTemplates.Location = new System.Drawing.Point(0, 0);
            this.listBoxTemplates.Name = "listBoxTemplates";
            this.listBoxTemplates.Size = new System.Drawing.Size(201, 450);
            this.listBoxTemplates.TabIndex = 0;
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
            this.splitContainer2.Panel2.Controls.Add(this.listBoxPlaceholder);
            this.splitContainer2.Size = new System.Drawing.Size(763, 450);
            this.splitContainer2.SplitterDistance = 573;
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
            this.editor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.templateBindingSource, "Content", true));
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.IsReplaceMode = false;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editor.ServiceColors")));
            this.editor.Size = new System.Drawing.Size(573, 450);
            this.editor.TabIndex = 0;
            this.editor.Text = "fastColoredTextBox1";
            this.editor.Zoom = 100;
            // 
            // listBoxPlaceholder
            // 
            this.listBoxPlaceholder.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.placeholderBindingSource, "DefaultValue", true));
            this.listBoxPlaceholder.DataSource = this.placeholderBindingSource;
            this.listBoxPlaceholder.DisplayMember = "Name";
            this.listBoxPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPlaceholder.FormattingEnabled = true;
            this.listBoxPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.listBoxPlaceholder.Name = "listBoxPlaceholder";
            this.listBoxPlaceholder.Size = new System.Drawing.Size(186, 450);
            this.listBoxPlaceholder.TabIndex = 0;
            
            // 
            // placeholderBindingSource
            // 
            this.placeholderBindingSource.DataSource = typeof(CSCodeGen.DataAccess.Model.Placeholder);
            // 
            // TemplateDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "TemplateDesignerForm";
            this.Text = "TemplateDesignerForm";
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBoxTemplates;
        private FastColoredTextBoxNS.FastColoredTextBox editor;
        private System.Windows.Forms.ListBox listBoxPlaceholder;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.BindingSource placeholderBindingSource;
    }
}