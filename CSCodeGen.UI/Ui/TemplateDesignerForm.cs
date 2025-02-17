﻿using CSCodeGen.DataAccess.Model;
using CSCodeGen.Library;
using CSCodeGen.UI.Ui;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form
    {
        #region Variabeln
        private BindingList<Template> templates;
        private Dictionary<TabPage, Template> tabs = new Dictionary<TabPage, Template>();
        private Template currentTemplate;

        #endregion
        public TemplateDesignerForm()
        {
            InitializeComponent();

            // Datasource binding
            templates = CoreGlobals.Instance.templateController.Templates;
            templateBindingSource.DataSource = templates;

            //Events
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

        }

        #region Methoden
        private void Save()
        {
            if (currentTemplate == null) return;


            if (currentTemplate.IsChanged)
            {
                CoreGlobals.Instance.templateController.SaveTemplate(currentTemplate);
                currentTemplate = null;
            }
        }
        private void AddNewTap()
        {
            TabPage tabPage = new TabPage(currentTemplate.Name);
            ucTemplateEditor ucEditor = new ucTemplateEditor(currentTemplate);
            ucEditor.OnClosingTap += UcEditor_OnClosingTap;
            ucEditor.OnSaveChanges += () => Save();

            tabs[tabPage] = currentTemplate;

            tabPage.Controls.Add(ucEditor);
            tabControl1.TabPages.Add(tabPage);

            tabControl1.SelectedTab = tabPage;

        }




        #endregion

        #region Events
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0)
            {
                return;
            }

            var selectedKeyword = (Keyword)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (selectedKeyword == null) { return; }

            // Überprüfe, ob die geklickte Zelle zur Button-Spalte gehört
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                KeywordCodeForm keywordCodeForm = new KeywordCodeForm(selectedKeyword);
                keywordCodeForm.ShowDialog();

            }

        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabs.ContainsKey(tabControl1.SelectedTab))
            {
                Template currentTemplate = tabs[tabControl1.SelectedTab];  // Hole das Template der ausgewählten TabPage
                SetPropertyGrid(currentTemplate);  // Übergib das Template an die Methode
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentTemplate == null)
            {
                MessageBox.Show("Bitte zuerst ein Template erstellen oder auswählen.");
                return;
            }

            currentTemplate.Keywords.Add(new Keyword());
            dataGridView1.Refresh(); // Grid aktualisieren
        }
        private void neuesTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTemplate = new Template { Name = "Neues Template" };

            AddNewTap();
            SetPropertyGrid(currentTemplate);

        }
        private void UcEditor_OnClosingTap(TabPage tabPage)
        {
            if (tabPage == null)
            {
                return;
            }

            // Jetzt die TabPage entfernen
            tabControl1.TabPages.Remove(tabPage);

            if (tabControl1.TabPages.Count > 0)
            {
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];  // Setze den ersten Tab als aktiv
            }

            propertyGrid1.SelectedObject = null;
            dataGridView1.DataSource = null;

        }
        private void SetPropertyGrid(Template template)
        {
            propertyGrid1.SelectedObject = template;
            dataGridView1.DataSource = template.Keywords;
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            currentTemplate = (Template)listBox1.SelectedItem;
            AddNewTap();
            SetPropertyGrid(currentTemplate);
        }
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void TemplateDesignerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (templates == null) return;

            int nichtgespeichert = 0;
            foreach (Template template in templates)
            {
                if (template.IsChanged)
                {
                    nichtgespeichert++;
                }
            }

            if (nichtgespeichert > 0)
            {
                DialogResult result = MessageBox.Show(
               "Änderungen speichern?",
               "Speichern",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question
           );

                if (result == DialogResult.Yes)
                {
                    Save();
                }

            }

        }
        private void allesSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoreGlobals.Instance.templateController.SaveAllTemplates();
        }
        #endregion
    }

}


