using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI.UIKlassen
{
    public class TabPageHelper
    {
        private static Dictionary<TabPage, Template> _tabs = new Dictionary<TabPage, Template>();
        private Template _template;
        public static Dictionary<TabPage,Template> GetTabs()
        {
            return _tabs;
        }
        public static TabPage CreateTabPage(Template template, ICodeTemplateView templateView)
        {
            if (template == null || templateView == null)
            {
                throw new ArgumentNullException("Fehler! Tabpage konnte nicht erstellt werden!");
            }

            var tabPage = new TabPage(template.Name)
            {
                ToolTipText = template.Name
            };

            var editor = new ucTemplateEditor(template)
            {
                Dock = DockStyle.Fill
            };

            editor.OnClosingTap += (sender, e) => CloseTab(tabPage, form);
            editor.OnSaveChanges += templateView.
            editor.OnResetChanges += (sender, e) => form.ResetTemplate?.Invoke(sender, new TemplateEventArgs { Template = template });


            tabPage.Controls.Add(editor);
            _tabs[tabPage] = template;

            return tabPage;
        }

       
    }
}
))