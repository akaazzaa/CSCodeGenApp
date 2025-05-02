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
        /// <summary>
        /// Erstellt eine neue TabPage mit dem Template und dem Editor
        /// </summary>
        /// <param name="template"></param>
        /// <param name="editor"></param>
        /// <returns></returns>
        public static TabPage CreateTabPage(Template template, ucTemplateEditor editor)
        {
            if (template == null)
            {
                return null;
            }

            var tabPage = new TabPage(template.Name)
            {
                ToolTipText = template.Name
            };

            tabPage.Controls.Add(editor);
            Tabs[tabPage] = template;

            return tabPage;
        }
        /// <summary>
        /// Überprüft, ob die TabPage im Dictionary vorhanden ist
        /// </summary>
        /// <param name="tapPage"></param>
        /// <returns></returns>
        public static bool DictonaryContaisTabPage(TabPage tapPage)
        {
            return Tabs.ContainsKey(tapPage);
        }
        /// <summary>
        /// Überprüft, ob das Template im Dictionary vorhanden ist
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public static bool DictonaryContainsTemplate(Template template)
        {
            return Tabs.ContainsValue(template);
        }


    }
}
