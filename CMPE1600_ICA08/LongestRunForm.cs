using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600_ICA08
{
    public partial class LongestRunForm : Form
    {
        bool runType = false;
        public LongestRunForm()
        {
            InitializeComponent();
        }

        private void UI_CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void UI_OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public bool RunType
        {
            get
            {
                return runType;
            }
        }

        private void UI_ZeroRuns_CheckedChanged(object sender, EventArgs e)
        {
            runType = false;
        }

        private void UI_OneRuns_CheckedChanged(object sender, EventArgs e)
        {
            runType = true;
        }
    }
}
