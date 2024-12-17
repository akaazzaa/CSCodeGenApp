﻿namespace CSCodeGENExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlMain = new Panel();
            tabMain = new TabControl();
            panel1 = new Panel();
            toolBar = new ToolStrip();
            btnNeueKlasse = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            toolBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(64, 64, 64);
            pnlMain.Controls.Add(tabMain);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1327, 493);
            pnlMain.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 30);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1327, 463);
            tabMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(toolBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 30);
            panel1.TabIndex = 0;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(64, 64, 64);
            toolBar.Dock = DockStyle.Fill;
            toolBar.GripStyle = ToolStripGripStyle.Hidden;
            toolBar.Items.AddRange(new ToolStripItem[] { btnNeueKlasse, toolStripButton2, toolStripButton1 });
            toolBar.Location = new Point(0, 0);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(1327, 30);
            toolBar.TabIndex = 0;
            toolBar.Text = "toolStrip1";
            // 
            // btnNeueKlasse
            // 
            btnNeueKlasse.BackColor = Color.FromArgb(64, 64, 64);
            btnNeueKlasse.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNeueKlasse.ForeColor = SystemColors.ControlDark;
            btnNeueKlasse.Image = (Image)resources.GetObject("btnNeueKlasse.Image");
            btnNeueKlasse.ImageTransparentColor = Color.Magenta;
            btnNeueKlasse.Name = "btnNeueKlasse";
            btnNeueKlasse.Size = new Size(74, 27);
            btnNeueKlasse.Text = "Neue Klasse";
            btnNeueKlasse.Click += btnNeueKlasse_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackColor = Color.FromArgb(64, 64, 64);
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.ForeColor = SystemColors.ControlDark;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(102, 27);
            toolStripButton2.Text = "Klasse bearbeiten";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = Color.FromArgb(64, 64, 64);
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ForeColor = SystemColors.ControlDark;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(74, 27);
            toolStripButton1.Text = "Neue Klasse";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private TabControl tabMain;
        private ToolStrip toolBar;
        private ToolStripButton btnNeueKlasse;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
    }
}