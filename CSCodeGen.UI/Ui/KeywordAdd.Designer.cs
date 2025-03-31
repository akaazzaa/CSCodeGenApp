namespace CSCodeGen.UI.Ui
{
    partial class KeywordAdd
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
            pnlRight = new System.Windows.Forms.Panel();
            gvDaten = new System.Windows.Forms.DataGridView();
            textbausteinBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prefixWithCommentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            displayTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlMain.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvDaten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbausteinBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1113, 547);
            pnlMain.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(gvDaten);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRight.Location = new System.Drawing.Point(0, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(1113, 547);
            pnlRight.TabIndex = 0;
            // 
            // gvDaten
            // 
            gvDaten.AutoGenerateColumns = false;
            gvDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            gvDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, prefixWithCommentDataGridViewCheckBoxColumn, displayTextDataGridViewTextBoxColumn });
            gvDaten.DataSource = textbausteinBindingSource;
            gvDaten.Dock = System.Windows.Forms.DockStyle.Fill;
            gvDaten.Location = new System.Drawing.Point(0, 0);
            gvDaten.Name = "gvDaten";
            gvDaten.Size = new System.Drawing.Size(1113, 547);
            gvDaten.TabIndex = 0;
            // 
            // textbausteinBindingSource
            // 
            textbausteinBindingSource.DataSource = typeof(Model.Main.Textbaustein);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // prefixWithCommentDataGridViewCheckBoxColumn
            // 
            prefixWithCommentDataGridViewCheckBoxColumn.DataPropertyName = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.HeaderText = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.Name = "prefixWithCommentDataGridViewCheckBoxColumn";
            // 
            // displayTextDataGridViewTextBoxColumn
            // 
            displayTextDataGridViewTextBoxColumn.DataPropertyName = "DisplayText";
            displayTextDataGridViewTextBoxColumn.HeaderText = "DisplayText";
            displayTextDataGridViewTextBoxColumn.Name = "displayTextDataGridViewTextBoxColumn";
            displayTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KeywordAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1113, 547);
            Controls.Add(pnlMain);
            Name = "KeywordAdd";
            Text = "KeywordAdd";
            pnlMain.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvDaten).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbausteinBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView gvDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prefixWithCommentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource textbausteinBindingSource;
    }
}