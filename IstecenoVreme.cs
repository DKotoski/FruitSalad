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
    public partial class IstecenoVreme : Form
    {
        public Color temna{get;set;}
        public Color svetla { get; set; }
        public string ime { get; set; }
        
        public IstecenoVreme()
        {
            InitializeComponent();
            temna = btnOtkazi.BackColor;
            svetla = label1.BackColor;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void btnNovaIgra_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnZapisi.BackColor = svetla;
        }

        private void btnNovaIgra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnZapisi.BackColor = temna;
        }

        private void btnGlavnoMeni_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnOtkazi.BackColor = svetla ;
        }

        private void btnGlavnoMeni_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnOtkazi.BackColor = temna;
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
                ime = tbIme.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
        }

        private void btnGlavnoMeni_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void IstecenoVreme_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 444;
            this.Height = 295;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void IstecenoVreme_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNovaIgra_Click(null, null);
            }
        }
    }
}
