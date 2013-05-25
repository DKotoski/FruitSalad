using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VizuelnoSeminarska.Properties;

namespace VizuelnoSeminarska
{
    public partial class Form1 : Form
    {
        Color temna;
        Color svetla;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            temna = label1.BackColor;
            label1.BackColor = Color.Transparent;
            label1.Text = "";
            svetla = label2.BackColor;
            label2.BackColor = Color.Transparent;
            label2.Text = "";
        }

        private void lblInstc_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblInstc_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void lblAbout_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void lblNovaIgra_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblNovaIgra.Image = Resources.newmouseover;
        }

        private void lblNovaIgra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            lblNovaIgra.Image = null;
        }

        private void lblNovaIgra_Click(object sender, EventArgs e)
        {
            Igra novaIgra = new Igra();
            this.Hide();
            novaIgra.StartPosition = FormStartPosition.CenterScreen;
            novaIgra.Top = this.Top-40;
            novaIgra.Left = this.Left;
            if (novaIgra.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Show();
            }
            else
                this.Close();
            
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            ZaIgra zaIgra = new ZaIgra();
            zaIgra.StartPosition = FormStartPosition.CenterScreen;
            zaIgra.Height = this.Height;
            zaIgra.Width = this.Width;
            zaIgra.temna = temna;
            zaIgra.svetla = svetla;
            this.Hide();
            if (zaIgra.ShowDialog() == DialogResult.Ignore)
            {
                this.Show();
            }
            else
                this.Show();
        }

        private void lblInstc_Click(object sender, EventArgs e)
        {
            Instrukcii ins = new Instrukcii();
            ins.StartPosition = FormStartPosition.CenterScreen;
            ins.Height = this.Height;
            ins.Width = this.Width;
            ins.temna = temna;
            ins.svetla = svetla;
            this.Hide();
            if (ins.ShowDialog() == DialogResult.Ignore)
            {
                this.Show();
            }
            else
                this.Show();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 720;
            this.Height = 460;
        }

        private void lblRekordi_Click(object sender, EventArgs e)
        {
            HighScoreTable hs = new HighScoreTable();
            hs.Show();
        }

        

        
    }
}
