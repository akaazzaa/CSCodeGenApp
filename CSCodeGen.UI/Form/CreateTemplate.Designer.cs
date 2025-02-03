namespace CSCodeGen.UI
{
    partial class CreateTemplateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.labelTemplatename = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.labelTemplatename);
            this.panel1.Controls.Add(this.txtTemplateName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 68);
            this.panel1.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(39, 46);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(127, 13);
            this.Info.TabIndex = 2;
            this.Info.Text = "Zum Speichern schließen";
            // 
            // labelTemplatename
            // 
            this.labelTemplatename.AutoSize = true;
            this.labelTemplatename.Location = new System.Drawing.Point(12, 19);
            this.labelTemplatename.Name = "labelTemplatename";
            this.labelTemplatename.Size = new System.Drawing.Size(85, 13);
            this.labelTemplatename.TabIndex = 1;
            this.labelTemplatename.Text = "Template Name:";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(100, 16);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(109, 20);
            this.txtTemplateName.TabIndex = 0;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 68);
            this.Controls.Add(this.panel1);
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label labelTemplatename;
    }
}