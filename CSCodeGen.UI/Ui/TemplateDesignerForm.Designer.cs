using CSCodeGen.Model.Main;

namespace CSCodeGen.UI
{
    partial class TemplateDesignerForm
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
            panelMain = new System.Windows.Forms.Panel();
            panelContent = new System.Windows.Forms.Panel();
            tcMain = new System.Windows.Forms.TabControl();
            pnlSidebarRight = new System.Windows.Forms.Panel();
            gvKeywords = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prefixWithCommentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsPlatzhalter = new System.Windows.Forms.BindingSource(components);
            pnalPropertys = new System.Windows.Forms.Panel();
            pgTemplate = new System.Windows.Forms.PropertyGrid();
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlList = new System.Windows.Forms.Panel();
            listTemplate = new System.Windows.Forms.ListBox();
            bsTemplates = new System.Windows.Forms.BindingSource(components);
            pnlbar = new System.Windows.Forms.Panel();
            mainMenu = new System.Windows.Forms.MenuStrip();
            btnNeuesTemplate = new System.Windows.Forms.ToolStripMenuItem();
            btnSave = new System.Windows.Forms.ToolStripMenuItem();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            pnlSidebarRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvKeywords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPlatzhalter).BeginInit();
            pnalPropertys.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTemplates).BeginInit();
            pnlbar.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(pnlSidebar);
            panelMain.Controls.Add(pnlbar);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1240, 554);
            panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelContent.Controls.Add(tcMain);
            panelContent.Controls.Add(pnlSidebarRight);
            panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContent.Location = new System.Drawing.Point(198, 30);
            panelContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new System.Drawing.Size(1042, 524);
            panelContent.TabIndex = 2;
            // 
            // tcMain
            // 
            tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tcMain.Location = new System.Drawing.Point(0, 0);
            tcMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new System.Drawing.Size(696, 522);
            tcMain.TabIndex = 1;
            tcMain.SelectedIndexChanged += tcMain_SelectedIndexChanged;
            // 
            // pnlSidebarRight
            // 
            pnlSidebarRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlSidebarRight.Controls.Add(gvKeywords);
            pnlSidebarRight.Controls.Add(pnalPropertys);
            pnlSidebarRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlSidebarRight.Location = new System.Drawing.Point(696, 0);
            pnlSidebarRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSidebarRight.Name = "pnlSidebarRight";
            pnlSidebarRight.Size = new System.Drawing.Size(344, 522);
            pnlSidebarRight.TabIndex = 0;
            // 
            // gvKeywords
            // 
            gvKeywords.AllowUserToAddRows = false;
            gvKeywords.AllowUserToDeleteRows = false;
            gvKeywords.AllowUserToResizeColumns = false;
            gvKeywords.AutoGenerateColumns = false;
            gvKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvKeywords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, prefixWithCommentDataGridViewCheckBoxColumn, Type });
            gvKeywords.DataSource = bsPlatzhalter;
            gvKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            gvKeywords.Location = new System.Drawing.Point(0, 251);
            gvKeywords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gvKeywords.MultiSelect = false;
            gvKeywords.Name = "gvKeywords";
            gvKeywords.ReadOnly = true;
            gvKeywords.Size = new System.Drawing.Size(342, 269);
            gvKeywords.TabIndex = 1;
            gvKeywords.DoubleClick += gvKeywords_DoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prefixWithCommentDataGridViewCheckBoxColumn
            // 
            prefixWithCommentDataGridViewCheckBoxColumn.DataPropertyName = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.HeaderText = "PrefixWithComment";
            prefixWithCommentDataGridViewCheckBoxColumn.Name = "prefixWithCommentDataGridViewCheckBoxColumn";
            prefixWithCommentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // bsPlatzhalter
            // 
            bsPlatzhalter.DataSource = typeof(Textbaustein);
            // 
            // pnalPropertys
            // 
            pnalPropertys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnalPropertys.Controls.Add(pgTemplate);
            pnalPropertys.Dock = System.Windows.Forms.DockStyle.Top;
            pnalPropertys.Location = new System.Drawing.Point(0, 0);
            pnalPropertys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnalPropertys.Name = "pnalPropertys";
            pnalPropertys.Size = new System.Drawing.Size(342, 251);
            pnalPropertys.TabIndex = 0;
            // 
            // pgTemplate
            // 
            pgTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            pgTemplate.Location = new System.Drawing.Point(0, 0);
            pgTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pgTemplate.Name = "pgTemplate";
            pgTemplate.Size = new System.Drawing.Size(340, 249);
            pgTemplate.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlSidebar.Controls.Add(pnlList);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 30);
            pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(198, 524);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlList
            // 
            pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlList.Controls.Add(listTemplate);
            pnlList.Dock = System.Windows.Forms.DockStyle.Left;
            pnlList.Location = new System.Drawing.Point(0, 0);
            pnlList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlList.Name = "pnlList";
            pnlList.Size = new System.Drawing.Size(197, 522);
            pnlList.TabIndex = 0;
            // 
            // listTemplate
            // 
            listTemplate.DataSource = bsTemplates;
            listTemplate.DisplayMember = "Name";
            listTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            listTemplate.FormattingEnabled = true;
            listTemplate.ItemHeight = 15;
            listTemplate.Location = new System.Drawing.Point(0, 0);
            listTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listTemplate.Name = "listTemplate";
            listTemplate.Size = new System.Drawing.Size(195, 520);
            listTemplate.TabIndex = 0;
            listTemplate.DoubleClick += listTemplate_DoubleClick;
            // 
            // bsTemplates
            // 
            bsTemplates.DataSource = typeof(Template);
            // 
            // pnlbar
            // 
            pnlbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlbar.Controls.Add(mainMenu);
            pnlbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlbar.Location = new System.Drawing.Point(0, 0);
            pnlbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlbar.Name = "pnlbar";
            pnlbar.Size = new System.Drawing.Size(1240, 30);
            pnlbar.TabIndex = 0;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNeuesTemplate, btnSave });
            mainMenu.Location = new System.Drawing.Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            mainMenu.Size = new System.Drawing.Size(1238, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // btnNeuesTemplate
            // 
            btnNeuesTemplate.Name = "btnNeuesTemplate";
            btnNeuesTemplate.Size = new System.Drawing.Size(104, 20);
            btnNeuesTemplate.Text = "Neues Template";
            btnNeuesTemplate.Click += btnNeuesTemplate_Click;
            // 
            // btnSave
            // 
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(71, 20);
            btnSave.Text = "Speichern";
            btnSave.Click += btnSave_Click;
            // 
            // TemplateDesignerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1240, 554);
            Controls.Add(panelMain);
            MainMenuStrip = mainMenu;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "TemplateDesignerForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Designer";
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            pnlSidebarRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvKeywords).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPlatzhalter).EndInit();
            pnalPropertys.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsTemplates).EndInit();
            pnlbar.ResumeLayout(false);
            pnlbar.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel pnlbar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Panel pnlSidebarRight;
        private System.Windows.Forms.Panel pnalPropertys;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsPlatzhalter;
        private System.Windows.Forms.PropertyGrid pgTemplate;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.ListBox listTemplate;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem btnNeuesTemplate;
        private System.Windows.Forms.BindingSource bsTemplates;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn gvcbDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvKeywords;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prefixWithCommentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}