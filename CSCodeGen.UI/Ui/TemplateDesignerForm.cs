using CSCodeGen.Model.Main;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CSCodeGen.UI.Usercontrols;
using System.Collections.Generic;
using System.Linq;
using CSCodeGen.Model.Args;
using CSCodeGen.UI.Ui;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Library.Controller;
using CSCodeGen.UI.UIKlassen;
using System.Configuration;
using System.IO;

namespace CSCodeGen.UI
{
    public partial class TemplateDesignerForm : Form, ICodeTemplateView
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public event EventHandler LoadTemplates;
        public event EventHandler SaveAll;
        public event EventHandler<TemplateEventArgs> SaveTemplate;
        public event EventHandler<TemplateEventArgs> NewTemplate;
        public event EventHandler<TemplateEventArgs> AddKeyword;
        public event EventHandler<TemplateEventArgs> RemoveKeyword;
        public event EventHandler<TemplateEventArgs> DeleteKeyword;
        public TemplateDesignerForm()
        {
            InitializeComponent();
            Initialize();
        }
        #region Form Events
        /// <summary>
        /// Wird aufgerufen, wenn die Form geladen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            LoadTemplates?.Invoke(this, EventArgs.Empty);
            listTemplate.SelectedIndex = -1;
        }
        /// <summary>
        /// Wird aufgerufen, wenn die Form geschlossen wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// Wird aufgerufen, wenn der Tab gewechselt wird, die 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsSelectedTabPageNull() || !TabPageHelper.DictonaryContaisTabPage(tcMain.SelectedTab)) return;

            var template = TabPageHelper.Tabs[tcMain.SelectedTab];
            listTemplate.SelectedItem = template;
            SetKeyWordsBindings(template);
        }
        /// <summary>
        /// Wird aufgerufen, wenn das Grid doppelt angeklickt wird und öffnet eine neue Form   geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvKeywords_DoubleClick(object sender, EventArgs e)
        {
            if (IsSelectedTabPageNull()) return;

            var args = new TemplateEventArgs();

            args.Template = GetTemplateFromTap();

            OpenEditor(args);
        }
        /// <summary>
        /// Wird aufgerufen, wenn der Button Speichern geklickt wird ruft die Methode Save auf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();

            Save(this, GetSelectedTemplate());
        }
        /// <summary>
        /// Wird aufgerufen, wenn der Button Neues Template geklickt wird
        /// feuert das Event NewTemplate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNeuesTemplate_Click(object sender, EventArgs e)
        {
            var args = new TemplateEventArgs();

            args.Template = new Template();

            NewTemplate?.Invoke(this, args);
        }
        /// <summary>
        /// Wird aufgerufen wenn löschen gedrückt wird, dann wird das ausgwählte TEmplate gelöscht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLöschen_Click(object sender, EventArgs e)
        {
            var args = new TemplateEventArgs();

            args.Template = GetSelectedTemplate();

            DeleteKeyword?.Invoke(sender, args);
        }
        /// <summary>
        /// Wird aufgerufen wenn in der Liste auf ein template gedrückt wird, dann wird dieses angezeigt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listTemplate_Click(object sender, EventArgs e)
        {
            SetKeyWordsBindings(GetSelectedTemplate());
            AddNewTab(GetSelectedTemplate());
        }
        #endregion

        #region Methods
        /// <summary>
        /// Inizialisiert die Form
        /// </summary>
        public void Initialize()
        {
            this.Load += OnLoad;
            this.FormClosing += OnFormClosing;
        }
        /// <summary>
        /// Öffnet den SaveDialog und returned den Pfad
        /// </summary>
        /// <returns></returns>
        public string UseFileDialog()
        {
             using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                
                saveFileDialog.Filter = "Textdateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
                saveFileDialog.Title = "Speichern unter";
                saveFileDialog.InitialDirectory = Globals.FolderPath; 
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
            }

                return "";
        }
        /// <summary>
        /// Zeigt eine Messagebox an 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public bool ShowMessagBox(string message, string caption)
        {
           var result =  MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            return result == DialogResult.Yes;

        }
        /// <summary>
        /// Öffnet die Textbausteinliste
        /// </summary>
        /// <param name="args"></param>
        private void OpenEditor(TemplateEventArgs args)
        {
            frmTextBlockList textBlockList = new frmTextBlockList(args);
            textBlockList.ShowDialog();
        }
        /// <summary>
        /// Gibt True or false zurück je nach zustand des SelectedTab
        /// </summary>
        /// <returns></returns>
        private bool IsSelectedTabPageNull()
        {
            return tcMain.SelectedTab == null;
        }
        /// <summary>
        /// Gibt mir das Template aus dem Dictonary, anhand des ausgewählten
        /// </summary>
        /// <returns></returns>
        private Template GetTemplateFromTap()
        {
            return TabPageHelper.Tabs[tcMain.SelectedTab];
        }
        /// <summary>
        /// Zeigt eine Messagebox an
        /// </summary>
        /// <param name="message"></param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        /// <summary>
        /// Zeigt die Templates in der Liste an
        /// </summary>
        /// <param name="templates"></param>
        public void ShowTemplates(BindingList<Template> templates)
        {
            bsTemplates.DataSource = templates;
        }
        /// <summary>
        /// Setzt die Bindings für die Textbausteine
        /// </summary>
        /// <param name="currentTemplate"></param>
        private void SetKeyWordsBindings(Template currentTemplate)
        {
            bsPlatzhalter.DataSource = currentTemplate.Textbausteine;
            pgTemplate.SelectedObject = currentTemplate;
        }
        /// <summary>
        /// Erstellt einen neuen Tab und fügt diesen hinzu
        /// </summary>
        /// <param name="currentTemplate"></param>
        private void AddNewTab(Template currentTemplate)
        {
            if (currentTemplate == null ) { return; }


            if (TabPageHelper.DictonaryContainsTemplate(currentTemplate))
            {
                tcMain.SelectedTab = TabPageHelper.Tabs.FirstOrDefault(x => x.Value == currentTemplate).Key;

            }else
            {
                var editor = new ucTemplateEditor(currentTemplate)
                {
                    Dock = DockStyle.Fill
                };

                editor.OnClosingTap += CloseTab;
                editor.OnSaveChanges += Save;
                editor.OnResetChanges += ResetTextChanges;

                var tabPage = TabPageHelper.CreateTabPage(currentTemplate, editor);
                tcMain.TabPages.Add(tabPage);
                tcMain.SelectedTab = tabPage;
            }
        }
        /// <summary>
        /// Speichert die Änderungen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="template"></param>
        private void Save(object sender, Template template)
        {
            var args = new TemplateEventArgs();

            args.Template = template;

            SaveTemplate?.Invoke(this, args);
        }
        /// <summary>
        /// Schlißet den Tab und entfernt diesen aus der Liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tabPage"></param>
        private void CloseTab(object sender, TabPage tabPage)
        {
            if (tabPage == null) return;

            tcMain.TabPages.Remove(tabPage);
            TabPageHelper.Tabs.Remove(tabPage);

            if (tcMain.TabPages.Count > 0)
            {
                tcMain.SelectedTab = tcMain.TabPages[tcMain.TabPages.Count - 1];
            }

            pgTemplate.SelectedObject = null;
            bsPlatzhalter.DataSource = null;

        }
        /// <summary>
        /// Gibt das in der Listausgewählte Template zurück.
        /// </summary>
        /// <returns></returns>
        private Template GetSelectedTemplate()
        {
            return listTemplate.SelectedItem as Template;
        }
        #endregion
    }

}


