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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1411, 523);
            this.panelMain.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(128, 485);
            this.treeView1.TabIndex = 0;
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(CSCodeGen.DataAccess.Model.Template);
            // 
            // placeholderBindingSource
            // 
            this.placeholderBindingSource.DataSource = typeof(CSCodeGen.DataAccess.Model.Placeholder);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(128, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1283, 485);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Text = "fastColoredTextBox1";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.fastColoredTextBox1);
            this.panelContent.Controls.Add(this.treeView1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1411, 485);
            this.panelContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 38);
            this.panel1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.BindingSource placeholderBindingSource;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}