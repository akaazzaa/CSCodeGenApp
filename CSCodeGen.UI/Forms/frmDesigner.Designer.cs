namespace CSCodeGen.Ui
{
    partial class frmDesigner
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesigner));
            pnlMain = new Panel();
            pnlTextbox = new Panel();
            listBox1 = new ListBox();
            templateBindingSource = new BindingSource(components);
            pnlTool = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).BeginInit();
            pnlTool.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlTextbox);
            pnlMain.Controls.Add(listBox1);
            pnlMain.Controls.Add(pnlTool);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1194, 482);
            pnlMain.TabIndex = 0;
            // 
            // pnlTextbox
            // 
            pnlTextbox.Dock = DockStyle.Left;
            pnlTextbox.Location = new Point(224, 29);
            pnlTextbox.Name = "pnlTextbox";
            pnlTextbox.Size = new Size(770, 453);
            pnlTextbox.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.DataSource = templateBindingSource;
            listBox1.DisplayMember = "TemplateName";
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 453);
            listBox1.TabIndex = 1;
           
            // 
            // templateBindingSource
            // 
           
            // 
            // pnlTool
            // 
            pnlTool.Controls.Add(toolStrip1);
            pnlTool.Dock = DockStyle.Top;
            pnlTool.Location = new Point(0, 0);
            pnlTool.Name = "pnlTool";
            pnlTool.Size = new Size(1194, 29);
            pnlTool.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1194, 29);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ForeColor = SystemColors.Control;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(95, 26);
            toolStripButton1.Text = "Neues Template";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 26);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // frmDesigner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 482);
            Controls.Add(pnlMain);
            Name = "frmDesigner";
            Text = "frmDesigner";
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)templateBindingSource).EndInit();
            pnlTool.ResumeLayout(false);
            pnlTool.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlTool;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private BindingSource templateBindingSource;
        private ListBox listBox1;
        private Panel pnlTextbox;
    }
}