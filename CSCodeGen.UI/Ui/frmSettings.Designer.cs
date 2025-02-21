namespace CSCodeGen.UI.Ui
{
    partial class frmSettings
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
            pnlMain = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            lblÜberschrift = new System.Windows.Forms.Label();
            lblTestdaten = new System.Windows.Forms.Label();
            cbTestdaten = new System.Windows.Forms.CheckBox();
            bsDaten = new System.Windows.Forms.BindingSource(components);
            pnlMain.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel2);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(514, 176);
            pnlMain.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblÜberschrift);
            panel2.Controls.Add(lblTestdaten);
            panel2.Controls.Add(cbTestdaten);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(157, 176);
            panel2.TabIndex = 0;
            // 
            // lblÜberschrift
            // 
            lblÜberschrift.AutoSize = true;
            lblÜberschrift.Location = new System.Drawing.Point(54, 9);
            lblÜberschrift.Name = "lblÜberschrift";
            lblÜberschrift.Size = new System.Drawing.Size(49, 15);
            lblÜberschrift.TabIndex = 2;
            lblÜberschrift.Text = "Settigns";
            // 
            // lblTestdaten
            // 
            lblTestdaten.AutoSize = true;
            lblTestdaten.Location = new System.Drawing.Point(12, 36);
            lblTestdaten.Name = "lblTestdaten";
            lblTestdaten.Size = new System.Drawing.Size(58, 15);
            lblTestdaten.TabIndex = 1;
            lblTestdaten.Text = "Testdaten";
            // 
            // cbTestdaten
            // 
            cbTestdaten.AutoSize = true;
            cbTestdaten.DataBindings.Add(new System.Windows.Forms.Binding("Checked", bsDaten, "isTest", true));
            cbTestdaten.Location = new System.Drawing.Point(118, 37);
            cbTestdaten.Name = "cbTestdaten";
            cbTestdaten.Size = new System.Drawing.Size(15, 14);
            cbTestdaten.TabIndex = 0;
            cbTestdaten.UseVisualStyleBackColor = true;
            // 
            // bsDaten
            // 
            bsDaten.DataSource = typeof(DataAccess.Model.Config.Settings);
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(514, 176);
            Controls.Add(pnlMain);
            Name = "frmSettings";
            Text = "frmSettigns";
            pnlMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDaten).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblÜberschrift;
        private System.Windows.Forms.Label lblTestdaten;
        private System.Windows.Forms.CheckBox cbTestdaten;
        private System.Windows.Forms.BindingSource bsDaten;
    }
}