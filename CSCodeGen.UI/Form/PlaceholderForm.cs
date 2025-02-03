using CSCodeGen.DataAccess.Model;
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

namespace CSCodeGen.UI
{
    public partial class PlaceholderForm : Form
    {
        Placeholder placeholder = null;

        public PlaceholderForm(Placeholder placeholder)
        {
            InitializeComponent();

           
        }

    }
}
