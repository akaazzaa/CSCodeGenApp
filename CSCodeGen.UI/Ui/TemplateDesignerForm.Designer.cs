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
            btnCode = new System.Windows.Forms.DataGridViewButtonColumn();
            gvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gvcbDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            gvtxtDisplaytext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsKeywords = new System.Windows.Forms.BindingSource(components);
            pnlKeywordMenu = new System.Windows.Forms.Panel();
            keywordmenu = new System.Windows.Forms.MenuStrip();
            btnAddKeyword = new System.Windows.Forms.ToolStripMenuItem();
            btnRemovekeyword = new System.Windows.Forms.ToolStripMenuItem();
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
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            pnlSidebarRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvKeywords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsKeywords).BeginInit();
            pnlKeywordMenu.SuspendLayout();
            keywordmenu.SuspendLayout();
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
            tcMain.Size = new System.Drawing.Size(709, 522);
            tcMain.TabIndex = 1;
            // 
            // pnlSidebarRight
            // 
            pnlSidebarRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlSidebarRight.Controls.Add(gvKeywords);
            pnlSidebarRight.Controls.Add(pnlKeywordMenu);
            pnlSidebarRight.Controls.Add(pnalPropertys);
            pnlSidebarRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlSidebarRight.Location = new System.Drawing.Point(709, 0);
            pnlSidebarRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlSidebarRight.Name = "pnlSidebarRight";
            pnlSidebarRight.Size = new System.Drawing.Size(331, 522);
            pnlSidebarRight.TabIndex = 0;
            // 
            // gvKeywords
            // 
            gvKeywords.AllowUserToAddRows = false;
            gvKeywords.AllowUserToDeleteRows = false;
            gvKeywords.AllowUserToResizeColumns = false;
            gvKeywords.AutoGenerateColumns = false;
            gvKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvKeywords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnCode, gvtxtName, gvcbDataType, gvtxtDisplaytext });
            gvKeywords.DataSource = bsKeywords;
            gvKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            gvKeywords.Location = new System.Drawing.Point(0, 318);
            gvKeywords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gvKeywords.Name = "gvKeywords";
            gvKeywords.Size = new System.Drawing.Size(329, 202);
            gvKeywords.TabIndex = 1;
            // 
            // btnCode
            // 
            btnCode.DataPropertyName = "Code";
            btnCode.HeaderText = "Code";
            btnCode.Name = "btnCode";
            btnCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            btnCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            btnCode.Text = "Code anschauen";
            btnCode.UseColumnTextForButtonValue = true;
            // 
            // gvtxtName
            // 
            gvtxtName.DataPropertyName = "Name";
            gvtxtName.HeaderText = "Name";
            gvtxtName.Name = "gvtxtName";
            // 
            // gvcbDataType
            // 
            gvcbDataType.DataPropertyName = "DataType";
            gvcbDataType.HeaderText = "DataType";
            gvcbDataType.Items.AddRange(new object[] { "int ", "bool ", "string", "Date", "char" });
            gvcbDataType.Name = "gvcbDataType";
            gvcbDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            gvcbDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gvtxtDisplaytext
            // 
            gvtxtDisplaytext.DataPropertyName = "DisplayText";
            gvtxtDisplaytext.HeaderText = "DisplayText";
            gvtxtDisplaytext.Name = "gvtxtDisplaytext";
            gvtxtDisplaytext.ReadOnly = true;
            // 
            // bsKeywords
            // 
            bsKeywords.DataSource = typeof(DataAccess.Model.Keyword);
            // 
            // pnlKeywordMenu
            // 
            pnlKeywordMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlKeywordMenu.Controls.Add(keywordmenu);
            pnlKeywordMenu.Dock = System.Windows.Forms.DockStyle.Top;
            pnlKeywordMenu.Location = new System.Drawing.Point(0, 294);
            pnlKeywordMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlKeywordMenu.Name = "pnlKeywordMenu";
            pnlKeywordMenu.Size = new System.Drawing.Size(329, 24);
            pnlKeywordMenu.TabIndex = 2;
            // 
            // keywordmenu
            // 
            keywordmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnAddKeyword, btnRemovekeyword });
            keywordmenu.Location = new System.Drawing.Point(0, 0);
            keywordmenu.Name = "keywordmenu";
            keywordmenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            keywordmenu.Size = new System.Drawing.Size(327, 24);
            keywordmenu.TabIndex = 0;
            keywordmenu.Text = "menuStrip2";
            // 
            // btnAddKeyword
            // 
            btnAddKeyword.Name = "btnAddKeyword";
            btnAddKeyword.Size = new System.Drawing.Size(41, 20);
            btnAddKeyword.Text = "Add";
            btnAddKeyword.Click += toolStripMenuItem1_Click;
            // 
            // btnRemovekeyword
            // 
            btnRemovekeyword.Name = "btnRemovekeyword";
            btnRemovekeyword.Size = new System.Drawing.Size(62, 20);
            btnRemovekeyword.Text = "Remove";
            btnRemovekeyword.Click += btnRemovekeyword_Click;
            // 
            // pnalPropertys
            // 
            pnalPropertys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnalPropertys.Controls.Add(pgTemplate);
            pnalPropertys.Dock = System.Windows.Forms.DockStyle.Top;
            pnalPropertys.Location = new System.Drawing.Point(0, 0);
            pnalPropertys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnalPropertys.Name = "pnalPropertys";
            pnalPropertys.Size = new System.Drawing.Size(329, 294);
            pnalPropertys.TabIndex = 0;
            // 
            // pgTemplate
            // 
            pgTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            pgTemplate.Location = new System.Drawing.Point(0, 0);
            pgTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pgTemplate.Name = "pgTemplate";
            pgTemplate.Size = new System.Drawing.Size(327, 292);
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
            listTemplate.DoubleClick += listBox1_DoubleClick;
            // 
            // bsTemplates
            // 
            bsTemplates.DataSource = typeof(DataAccess.Model.Template);
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
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNeuesTemplate, btnSave, settingsToolStripMenuItem });
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
            btnNeuesTemplate.Click += neuesTemplateToolStripMenuItem_Click;
            // 
            // btnSave
            // 
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(71, 20);
            btnSave.Text = "Speichern";
            btnSave.Click += speichernToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
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
            Text = "TemplateDesigner";
            FormClosing += TemplateDesignerForm_FormClosing;
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            pnlSidebarRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvKeywords).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsKeywords).EndInit();
            pnlKeywordMenu.ResumeLayout(false);
            pnlKeywordMenu.PerformLayout();
            keywordmenu.ResumeLayout(false);
            keywordmenu.PerformLayout();
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
        private System.Windows.Forms.DataGridView gvKeywords;
        private System.Windows.Forms.Panel pnlKeywordMenu;
        private System.Windows.Forms.MenuStrip keywordmenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddKeyword;
        private System.Windows.Forms.ToolStripMenuItem btnRemovekeyword;
        private System.Windows.Forms.Panel pnalPropertys;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsKeywords;
        private System.Windows.Forms.PropertyGrid pgTemplate;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.ListBox listTemplate;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem btnNeuesTemplate;
        private System.Windows.Forms.BindingSource bsTemplates;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.DataGridViewButtonColumn btnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvtxtName;
        private System.Windows.Forms.DataGridViewComboBoxColumn gvcbDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvtxtDisplaytext;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}