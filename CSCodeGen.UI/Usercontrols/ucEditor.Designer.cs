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
            pnlMain = new System.Windows.Forms.Panel();
            pnlEditor = new System.Windows.Forms.Panel();
            pnlListbox = new System.Windows.Forms.Panel();
            listBox1 = new System.Windows.Forms.ListBox();
            pnlMain.SuspendLayout();
            pnlListbox.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlEditor);
            pnlMain.Controls.Add(pnlListbox);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(994, 480);
            pnlMain.TabIndex = 0;
            // 
            // pnlEditor
            // 
            pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlEditor.Location = new System.Drawing.Point(147, 0);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new System.Drawing.Size(847, 480);
            pnlEditor.TabIndex = 1;
            // 
            // pnlListbox
            // 
            pnlListbox.Controls.Add(listBox1);
            pnlListbox.Dock = System.Windows.Forms.DockStyle.Left;
            pnlListbox.Location = new System.Drawing.Point(0, 0);
            pnlListbox.Name = "pnlListbox";
            pnlListbox.Size = new System.Drawing.Size(147, 480);
            pnlListbox.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(147, 480);
            listBox1.TabIndex = 0;
            // 
            // ucEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Name = "ucEditor";
            Size = new System.Drawing.Size(994, 480);
            pnlMain.ResumeLayout(false);
            pnlListbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Panel pnlListbox;
        private System.Windows.Forms.ListBox listBox1;
    }
}
