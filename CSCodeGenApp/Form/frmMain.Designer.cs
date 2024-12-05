namespace CSCodeGENExtension
{
    partial class frmMain
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
            pnlMain = new Panel();
            pnlEditor = new Panel();
            pnlSideR = new Panel();
            dataGridView1 = new DataGridView();
            pnlSideL = new Panel();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pnlMain.SuspendLayout();
            pnlSideR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlSideL.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlEditor);
            pnlMain.Controls.Add(pnlSideR);
            pnlMain.Controls.Add(pnlSideL);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1327, 493);
            pnlMain.TabIndex = 0;
            // 
            // pnlEditor
            // 
            pnlEditor.BackColor = Color.FromArgb(64, 64, 64);
            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Location = new Point(200, 30);
            pnlEditor.Name = "pnlEditor";
            pnlEditor.Size = new Size(927, 463);
            pnlEditor.TabIndex = 3;
            // 
            // pnlSideR
            // 
            pnlSideR.Controls.Add(dataGridView1);
            pnlSideR.Dock = DockStyle.Right;
            pnlSideR.Location = new Point(1127, 30);
            pnlSideR.Name = "pnlSideR";
            pnlSideR.Size = new Size(200, 463);
            pnlSideR.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(200, 463);
            dataGridView1.TabIndex = 0;
            // 
            // pnlSideL
            // 
            pnlSideL.Controls.Add(listBox1);
            pnlSideL.Dock = DockStyle.Left;
            pnlSideL.Location = new Point(0, 30);
            pnlSideL.Name = "pnlSideL";
            pnlSideL.Size = new Size(200, 463);
            pnlSideL.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(64, 64, 64);
            listBox1.Dock = DockStyle.Fill;
            listBox1.ForeColor = SystemColors.MenuBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 463);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 30);
            panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 493);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            pnlMain.ResumeLayout(false);
            pnlSideR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlSideL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private Panel pnlSideL;
        private Panel pnlSideR;
        private Panel pnlEditor;
        private ListBox listBox1;
        private DataGridView dataGridView1;
    }
}