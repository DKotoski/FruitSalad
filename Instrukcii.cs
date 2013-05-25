using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoSeminarska
{
    public partial class Instrukcii : Form
    {
        public Color temna { get; set; }
        public Color svetla { get; set; }

        public Instrukcii()
        {
            InitializeComponent();
        }

        private void Instrukcii_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 522;
            this.Height = 328;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = svetla;
            this.Cursor = Cursors.Hand;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = temna;
            this.Cursor = Cursors.Arrow;
        }
    }
}
