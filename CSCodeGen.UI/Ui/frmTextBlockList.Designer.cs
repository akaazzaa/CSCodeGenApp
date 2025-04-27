using CSCodeGen.Model.Main;
using System;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    partial class frmTextBlockList
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
            gvDaten = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prefixWithCommentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            Type = new DataGridViewComboBoxColumn();
            displayTextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textbausteinBindingSource = new BindingSource(components);
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            btnAdd = new ToolStripMenuItem();
            btnDelete = new ToolStripMenuItem();
            pnlRight = new Panel();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvDaten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbausteinBindingSource).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(gvDaten);
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1530, 615);
            pnlMain.TabIndex = 0;
            // 
            // gvDaten
            // 
            gvDaten.AllowUserToAddRows = false;
            gvDaten.AllowUserToDeleteRows = false;
            gvDaten.AllowUserToResizeColumns = false;
            gvDaten.AllowUserToResizeRows = false;
            gvDaten.AutoGenerateColumns = false;
            gvDaten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvDaten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDaten.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, prefixWithCommentDataGridViewCheckBoxColumn, Type, displayTextDataGridViewTextBoxColumn });
            gvDaten.DataBindings.Add(new Binding("DataContext", textbausteinBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            gvDaten.DataSource = textbausteinBindingSource;
            gvDaten.Dock = DockStyle.Fill;
            gvDaten.Location = new System.Drawing.Point(645, 25);
            gvDaten.MultiSelect = false;
            gvDaten.Name = "gvDaten";
            gvDaten.RowHeadersVisible = false;
            gvDaten.Size = new System.Drawing.Size(885, 590);
            gvDaten.TabIndex = 0;
            gvDaten.CellDoubleClick += gvDaten_CellDoubleClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // prefixWithCommentDataGridViewCheckBoxColumn
            // 
            prefixWithCommentDataGridViewCheckBoxColumn.DataPropertyName = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.HeaderText = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.Name = "prefixWithCommentDataGridViewCheckBoxColumn";
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // displayTextDataGridViewTextBoxColumn
            // 
            displayTextDataGridViewTextBoxColumn.DataPropertyName = "DisplayText";
            displayTextDataGridViewTextBoxColumn.HeaderText = "DisplayText";
            displayTextDataGridViewTextBoxColumn.Name = "displayTextDataGridViewTextBoxColumn";
            displayTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textbausteinBindingSource
            // 
            textbausteinBindingSource.DataSource = typeof(Textbaustein);
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(645, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(885, 25);
            panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnDelete });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(885, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(81, 21);
            btnAdd.Text = "Hinzufügen";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(63, 21);
            btnDelete.Text = "Löschen";
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlRight
            // 
            pnlRight.Dock = DockStyle.Left;
            pnlRight.Location = new System.Drawing.Point(0, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(645, 615);
            pnlRight.TabIndex = 0;
            // 
            // frmTextBlockList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1530, 615);
            Controls.Add(pnlMain);
            MainMenuStrip = menuStrip1;
            Name = "frmTextBlockList";
            Text = "KeywordAdd";
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvDaten).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbausteinBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView gvDaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource textbausteinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prefixWithCommentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}