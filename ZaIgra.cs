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
    public partial class ZaIgra : Form
    {
        public Color temna { get; set; }
        public Color svetla { get; set; }
        
        public ZaIgra()
        {
            InitializeComponent();
        }

        private void ZaIgra_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 398;
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
