namespace CSCodeGen.UI.Ui
{
    partial class KeywordCodeForm
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
            pnlMain = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1150, 505);
            pnlMain.TabIndex = 0;
            // 
            // KeywordCodeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1150, 505);
            Controls.Add(pnlMain);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "KeywordCodeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "KeywordCodeForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
    }
}