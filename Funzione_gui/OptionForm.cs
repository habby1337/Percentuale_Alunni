using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funzione_gui
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            lver.Text = "Versione: " + Application.ProductVersion;
        }

        private void lver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versione software: " + Application.ProductVersion, "INFO [" + Application.ProductVersion + "]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
