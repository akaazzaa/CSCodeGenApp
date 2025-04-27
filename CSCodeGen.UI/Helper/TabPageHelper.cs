using CSCodeGen.Model.Args;
using CSCodeGen.Model.Interfaces.View;
using CSCodeGen.Model.Main;
using CSCodeGen.UI.Usercontrols;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI.UIKlassen
{
    public class TabPageHelper
    {
        public static Dictionary<TabPage, Template> Tabs = new Dictionary<TabPage, Template>();
        public static TabPage CreateTabPage(Template template, ucTemplateEditor editor)
        {
            if (template == null)
            {
                throw new ArgumentNullException("Fehler! Tabpage konnte nicht erstellt werden!");
            }

            var tabPage = new TabPage(template.Name)
            {
                ToolTipText = template.Name
            };

            tabPage.Controls.Add(editor);
            Tabs[tabPage] = template;

            return tabPage;
        }

        public static bool DictonaryContaisTabPage(TabPage tapPage)
        {
            return Tabs.ContainsKey(tapPage);
        }

        public static bool DictonaryContainsTemplate(Template template)
        {
            return Tabs.ContainsValue(template);
        }


    }
}
