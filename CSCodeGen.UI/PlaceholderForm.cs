using CSCodeGen.DataAccess.Model;
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

            this.placeholder = placeholder;
            fastColoredTextBox1.Text = placeholder.DefaultValue;
            

        }

        private void PlaceholderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            placeholder.DefaultValue = fastColoredTextBox1.Text;
        }
    }
}
