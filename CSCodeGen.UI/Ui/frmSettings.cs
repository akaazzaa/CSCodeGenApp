using CSCodeGen.DataAccess.Model.Config;
using CSCodeGen.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCodeGen.UI.Ui
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();

            bsDaten.DataSource = CoreGlobals.Instance.settings;
            this.FormClosing += Close;

        }

        private void Close(object sender, FormClosingEventArgs e)
        {
           this.Validate();
        }
    }
}
