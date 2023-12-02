using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JarrettVance.ChapterTools
{
    public partial class DelayForm : Form
    {
        public DelayForm()
        {
            InitializeComponent();
        }

        public double DelaySeconds
        {
            get { return (double)numUpDown.Value; }
            set { numUpDown.Value = (decimal)value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
