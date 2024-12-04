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
            components = new System.ComponentModel.Container();
            pnlMain = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            propertiesBindingSource = new BindingSource(components);
            bsDaten = new BindingSource(components);
            pnlSideL = new Panel();
            pnlSideR = new Panel();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)propertiesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDaten).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlSideR);
            pnlMain.Controls.Add(pnlSideL);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1470, 625);
            pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 122);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 44);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1470, 78);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1470, 44);
            panel2.TabIndex = 0;
            // 
            // propertiesBindingSource
            // 
            propertiesBindingSource.DataMember = "Properties";
            propertiesBindingSource.DataSource = bsDaten;
            // 
            // bsDaten
            // 
            bsDaten.DataSource = typeof(Klassen.Template);
            // 
            // pnlSideL
            // 
            pnlSideL.Dock = DockStyle.Left;
            pnlSideL.Location = new Point(0, 122);
            pnlSideL.Name = "pnlSideL";
            pnlSideL.Size = new Size(200, 503);
            pnlSideL.TabIndex = 1;
            // 
            // pnlSideR
            // 
            pnlSideR.Dock = DockStyle.Right;
            pnlSideR.Location = new Point(1270, 122);
            pnlSideR.Name = "pnlSideR";
            pnlSideR.Size = new Size(200, 503);
            pnlSideR.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 625);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "frmMain";
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)propertiesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDaten).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bsDaten;
        private BindingSource propertiesBindingSource;
        private Panel pnlSideL;
        private Panel pnlSideR;
    }
}