using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VizuelnoSeminarska.Properties;

namespace VizuelnoSeminarska
{
    public partial class Igra : Form
    {
        int vreme;
        bool pauza;
        int MomNivo;
        Graphics grafika;
        Pen penkalo;
        SolidBrush cetka;
        Rectangle granica;
        Bitmap baferSlika;
        int momovostija;
        float brzina;
        int lvlvreme;
        int score;
        HighScore highscore;
        Color temna;
        Color svetla;
        Color bg;
        

        public Igra()
        {
            InitializeComponent();
            granica = new Rectangle(10, 10, panel1.Bounds.Width - 20, panel1.Bounds.Height - 20);
            baferSlika = new Bitmap(panel1.Width, panel1.Height);
            grafika = panel1.CreateGraphics();
            cetka = new SolidBrush(Color.Blue);
            penkalo = new Pen(Color.Black,4f);
            vreme = 8;
            lvlvreme = vreme;
            momovostija = 4;
            brzina = 5f;
            MomNivo = 1;
            tmrVreme.Start();
            tmrTopki.Start();
            pauza = false;
            score = 0;
            int x = rnd.Next();
            GenerirajNivoa();
            highscore = new HighScore();
            openFile();
            temna = btnNovaIgra.BackColor;
            svetla = btnGlavnoMeni.BackColor;
            btnGlavnoMeni.BackColor = temna;
            bg = lblRekord.BackColor;
            lblRekord.BackColor = Color.Transparent;
            btnRekord.BackColor = temna;
            lblRekord.Parent = panel1;
            
        }

        public void SaveFile()
        {
                System.Runtime.Serialization.IFormatter fmt= new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream("HighScore.hxs", FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, highscore);
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
        private void tmrVreme_Tick(object sender, EventArgs e)
        {
            vreme--;
            if (ProvVreme())
            {
                tmrVreme.Stop();
                tmrTopki.Stop();
                grafika.Clear(Color.White);
                grafika.DrawRectangle(penkalo,granica);
                this.BackgroundImage = null;
                this.BackColor = bg;
                panel1.BackgroundImage = Resources.pobeda;
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
                lblScore.Location = new Point(203, 188);
                lblScore.Parent = panel1;
                if (highscore.CheckHighscore(score))
                {
                    lblRekord.Visible = true;
                    btnRekord.Visible = true;
                    btnRekord.Enabled = true;

                    
                }
            }

            lblVreme.Text = string.Format("00 : {0:00}", vreme);
            
        }

        private void btnGlavnoMeni_Click(object sender, EventArgs e)
        {
            Ovosja.Clear();
            MomNivo = 1;
            vreme = 8;
            brzina = 5f;
            momovostija = 4;
            score = 0;
            lblVreme.Text = string.Format("00 : {0:00}", vreme);
            lblNivo.Text = string.Format("Ниво - {0}", MomNivo);
            tmrTopki.Stop();
            tmrVreme.Stop();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnGlavnoMeni_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnGlavnoMeni.BackColor = svetla;
        }

        private void btnGlavnoMeni_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnGlavnoMeni.BackColor = temna;
        }

        private void btnPauzirajIgra_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnPauzirajIgra.BackColor = svetla;
        }

        private void btnPauzirajIgra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnPauzirajIgra.BackColor = temna;
        }

        private void btnPauzirajIgra_Click(object sender, EventArgs e)
        {
            pauza = !pauza;

            if (pauza)
            {
                tmrVreme.Stop();
                tmrTopki.Stop();
                btnPauzirajIgra.Text = "Продолжи";
            }
            else
            {
                tmrVreme.Start();
                tmrTopki.Start();
                btnPauzirajIgra.Text = "Паузирај Игра";
            }
        }

        private void tmrTopki_Tick(object sender, EventArgs e)
        {
            
            Graphics g = Graphics.FromImage(baferSlika);
            g.Clear(Color.White);
            g.DrawRectangle(penkalo, granica);
            for (int i = 0; i < Ovosja.Count; i++)
            {
               Ovosja[i].Draw(g);
               Ovosja[i].Move();
                
            }

            try
            {
                grafika.DrawImageUnscaled(baferSlika, 0, 0);
            }
            catch
            {

            }
        }
        List<Ovostie> Ovosja = new List<Ovostie>();
        Random rnd = new Random();
        public void GenerirajNivoa()
        {
                List<Image> sliki;
                sliki = new List<Image>();
                sliki.Add(Resources.Apple);
                sliki.Add(Resources.matou_strawberry_1979px);
                sliki.Add(Resources.nicubunu_Plum);
                sliki.Add(Resources.pear);

                for (int i = 0; i <= momovostija; i++)
                {
                    int gorna=(int)rnd.Next() % (panel1.Bounds.Height-60);
                    if (gorna<granica.Top)
                        gorna+=200;
                    if (gorna > granica.Bottom)
                        gorna -= 200;
                    int leva = (int)rnd.Next() % (panel1.Bounds.Width-60);
                    if (leva < granica.Left)
                        leva += 200;
                    if (leva > granica.Right)
                        leva -= 200;
                    Ovostie ovosje = new Ovostie(leva, gorna, brzina, (float)rnd.NextDouble() % 360, sliki[Math.Abs(rnd.Next()) % 4]);
                    ovosje.Bounds = granica;
                    Ovosja.Add(ovosje);
                }
                if (lvlvreme < 28)
                {
                    if (brzina < 25)
                        brzina *= 1.1f;
                    else
                    {
                        if (lvlvreme >= 15)
                        {
                            lvlvreme -= 2;
                        }
                        else
                            momovostija++;
                    }
                    if (momovostija < 20)
                        momovostija++;
                    lvlvreme++;
                }
                      
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pauza)
            {
                if (ProvPogodok(e.X, e.Y))
                {
                    if (Ovosja.Count == 0)
                    {
                        MomNivo++;
                        GenerirajNivoa();
                        vreme = lvlvreme;
                        lblNivo.Text = string.Format("Ниво - {0}", MomNivo);
                        tmrTopki_Tick(null, null);
                        tmrVreme_Tick(null, null);
                    }
                }
            }  
         }

        private bool ProvVreme()
        {
            if (vreme == 0)
                return true;
            else return false;
        }

        private bool ProvPogodok(int x, int y)
        {
           

            for(int i = 0; i<Ovosja.Count; ++i)
            {
                Ovostie ovs = (Ovostie)Ovosja[i];
                if (x >= ovs.X && x <= ovs.X + 50 && y >= ovs.Y && y <= ovs.Y + 50)
                {
                    Ovosja.Remove(ovs);
                    score++;
                    
                    lblScore.Text = String.Format("Овошја: {0}", score);
                    return true;
                }
            }

            
            return false;
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            Ovosja.Clear();
            MomNivo = 1;
            vreme = 8;
            brzina = 5f;
            momovostija = 4;
            score = 0;
            openFile();
            GenerirajNivoa();
            lblVreme.Text = string.Format("00 : {0:00}", vreme);
            lblNivo.Text = string.Format("Ниво - {0}", MomNivo);
            tmrTopki.Start();
            tmrVreme.Start();
            lblScore.Parent = this;
            lblScore.Location = new Point(519, 156);
            this.BackgroundImage = Resources.igrabg;
            lblRekord.Visible = false;
            btnRekord.Visible = false;
            btnRekord.Enabled = false;
        }

        private void btnNovaIgra_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnNovaIgra.BackColor = svetla ;
        }

        private void btnNovaIgra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnNovaIgra.BackColor = temna;
        }

        private void Igra_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 709;
            this.Height = 426;
        }

        private void Igra_Load(object sender, EventArgs e)
        {

        }

        private void btnRekord_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            btnRekord.BackColor = svetla;
        }

        private void btnRekord_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            btnRekord.BackColor = temna;
        }

        private void btnRekord_Click(object sender, EventArgs e)
        {
            
            IstecenoVreme istVr = new IstecenoVreme();
            istVr.lblScore.Text = lblScore.Text;
            istVr.ShowDialog();
            istVr.temna = temna;
            istVr.svetla = svetla;
            istVr.lblScore.Text = lblScore.Text;
            if (istVr.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                highscore.AddRezultat(new Rezultat(istVr.ime, score));
                SaveFile();
                HighScoreTable hs = new HighScoreTable();
                hs.Show();
                btnRekord.Visible = false;
                btnRekord.Enabled = false;
                return;
            }
            if (istVr.DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        }

        

        
    }

