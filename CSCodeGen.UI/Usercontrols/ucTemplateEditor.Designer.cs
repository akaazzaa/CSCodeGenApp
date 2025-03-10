using CSCodeGen.Model.Main;

namespace CSCodeGen.UI.Usercontrols
{
    partial class ucTemplateEditor
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
            panel1 = new System.Windows.Forms.Panel();
            pnlMain = new System.Windows.Forms.Panel();
            pnlEditor = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            templateBindingSource = new System.Windows.Forms.BindingSource(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(pnlMain);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1279, 630);
            panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMain.Controls.Add(pnlEditor);
            pnlMain.Controls.Add(panel4);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1277, 628);
            pnlMain.TabIndex = 1;
            // 
            // pnlEditor
            // 
            pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlEditor.Location = new System.Drawing.Point(0, 29);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new System.Drawing.Size(1275, 597);
            pnlEditor.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(menuStrip1);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1275, 29);
            panel4.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnRemove });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1273, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnRemove
            // 
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(70, 20);
            btnRemove.Text = "Schließen";
            // 
            // templateBindingSource
            // 
            templateBindingSource.DataSource = typeof(Template);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ucTemplateEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ucTemplateEditor";
            Size = new System.Drawing.Size(1279, 630);
            panel1.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
        private System.Windows.Forms.Panel pnlEditor;
    }
}
