using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoSeminarska
{
    public partial class HighScoreTable : Form
    {
        Color temna;
        HighScore highscore { get; set; }
        public HighScoreTable()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            temna = btnClose.BackColor;
            highscore = new HighScore();
            openFile();

            zapisiRekordi();
        }

        public void SaveFile()
        {
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream("HighScore.hxs", FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, highscore);
            strm.Close();
        }

        public void openFile()
        {
            try
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream("HighScore.hxs", FileMode.Open, FileAccess.Read, FileShare.None);
                highscore = (HighScore)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception e)
            {

                SaveFile();
            }
        }

        void zapisiRekordi()
        {
            lblIme1.Text = highscore.Rezultati[0].Ime;
            if (highscore.Rezultati[0].score != 0)
                lblScore1.Text = highscore.Rezultati[0].score.ToString();
            else
                lblScore1.Text = "";

            lblIme2.Text = highscore.Rezultati[1].Ime;
            if (highscore.Rezultati[1].score != 0)
                lblScore2.Text = highscore.Rezultati[1].score.ToString();
            else
                lblScore2.Text = "";

            lblIme3.Text = highscore.Rezultati[2].Ime;
            if (highscore.Rezultati[2].score != 0)
                lblScore3.Text = highscore.Rezultati[2].score.ToString();
            else
                lblScore3.Text = "";

            lblIme4.Text = highscore.Rezultati[3].Ime;
            if (highscore.Rezultati[3].score != 0)
                lblScore4.Text = highscore.Rezultati[3].score.ToString();
            else
                lblScore4.Text = "";

            lblIme5.Text = highscore.Rezultati[4].Ime;
            if (highscore.Rezultati[4].score != 0)
                lblScore5.Text = highscore.Rezultati[4].score.ToString();
            else
                lblScore5.Text = "";

            lblIme6.Text = highscore.Rezultati[5].Ime;
            if (highscore.Rezultati[5].score != 0)
                lblScore6.Text = highscore.Rezultati[5].score.ToString();
            else
                lblScore6.Text = "";

            lblIme7.Text = highscore.Rezultati[6].Ime;
            if (highscore.Rezultati[6].score != 0)
                lblScore7.Text = highscore.Rezultati[6].score.ToString();
            else
                lblScore7.Text = "";

            lblIme8.Text = highscore.Rezultati[7].Ime;
            if (highscore.Rezultati[7].score != 0)
                lblScore8.Text = highscore.Rezultati[7].score.ToString();
            else
                lblScore8.Text = "";

            lblIme9.Text = highscore.Rezultati[8].Ime;
            if (highscore.Rezultati[8].score != 0)
                lblScore9.Text = highscore.Rezultati[8].score.ToString();
            else
                lblScore9.Text = "";

            lblIme10.Text = highscore.Rezultati[9].Ime;
            if (highscore.Rezultati[9].score != 0)
                lblScore10.Text = highscore.Rezultati[9].score.ToString();
            else
                lblScore10.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = label1.BackColor;
            this.Cursor = Cursors.Hand;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = temna;
            this.Cursor = Cursors.Arrow;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            highscore = new HighScore();
            SaveFile();
            zapisiRekordi();
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = label1.BackColor;
            this.Cursor = Cursors.Hand;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = temna;
            this.Cursor = Cursors.Arrow;
        }

        private void HighScoreTable_Load(object sender, EventArgs e)
        {

        }

    }
}
