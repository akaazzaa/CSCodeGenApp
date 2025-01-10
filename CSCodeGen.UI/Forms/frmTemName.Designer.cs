namespace CSCodeGen.UI.Forms
{
    partial class frmTemName
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
            panel1 = new Panel();
            btnOK = new Button();
            txtTemname = new TextBox();
            lblTemplateName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(txtTemname);
            panel1.Controls.Add(lblTemplateName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 48);
            panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(219, 18);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(92, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtTemname
            // 
            txtTemname.Location = new Point(3, 18);
            txtTemname.Name = "txtTemname";
            txtTemname.Size = new Size(210, 23);
            txtTemname.TabIndex = 1;
            // 
            // lblTemplateName
            // 
            lblTemplateName.AutoSize = true;
            lblTemplateName.Dock = DockStyle.Left;
            lblTemplateName.Location = new Point(0, 0);
            lblTemplateName.Name = "lblTemplateName";
            lblTemplateName.Size = new Size(85, 15);
            lblTemplateName.TabIndex = 0;
            lblTemplateName.Text = "Templatename";
            lblTemplateName.Click += label1_Click;
            // 
            // frmTemName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 48);
            Controls.Add(panel1);
            Name = "frmTemName";
            Text = "frmTemName";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTemplateName;
        private Button btnOK;
        private TextBox txtTemname;
    }
}