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
            pnlEditor = new Panel();
            pnlRight = new Panel();
            listBox2 = new ListBox();
            placeholderBindingSource = new BindingSource(components);
            pnlLeft = new Panel();
            listBox1 = new ListBox();
            templateBindingSource1 = new BindingSource(components);
            pnlTool = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            pnlMain.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)placeholderBindingSource).BeginInit();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)templateBindingSource1).BeginInit();
            pnlTool.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlEditor);
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Controls.Add(pnlLeft);
            pnlMain.Controls.Add(pnlTool);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1194, 482);
            pnlMain.TabIndex = 0;
            // 
            // pnlEditor
            // 
            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Location = new Point(183, 29);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(814, 453);
            pnlEditor.TabIndex = 2;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(listBox2);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(997, 29);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(197, 453);
            pnlRight.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.DataSource = placeholderBindingSource;
            listBox2.DisplayMember = "Name";
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(0, 0);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(197, 453);
            listBox2.TabIndex = 0;
            listBox2.DragEnter += listBox2_DragEnter;
            listBox2.DragLeave += listBox2_DragLeave;
            listBox2.DoubleClick += listBox2_DoubleClick;
            listBox2.MouseDown += listBox2_MouseDown;
            // 
            // placeholderBindingSource
            // 
            placeholderBindingSource.DataSource = typeof(Library.Placeholder);
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(listBox1);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 29);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(183, 453);
            pnlLeft.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.DataSource = templateBindingSource1;
            listBox1.DisplayMember = "Name";
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 453);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // templateBindingSource1
            // 
            templateBindingSource1.DataSource = typeof(Library.Template);
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
            toolStripButton1.Click += toolStripButton1_Click;
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
            DragDrop += Form2_DragDrop;
            pnlMain.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)placeholderBindingSource).EndInit();
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)templateBindingSource1).EndInit();
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
        private Panel pnlEditor;
        private Panel pnlRight;
        private Panel pnlLeft;
        private ListBox listBox2;
        private ListBox listBox1;
        private BindingSource templateBindingSource1;
        private BindingSource placeholderBindingSource;
    }
}