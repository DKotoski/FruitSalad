using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoSeminarska
{
    [Serializable]
     class HighScore
    {
        public List<Rezultat> Rezultati{set;get;}


        public HighScore()
        {
            Rezultati = new List<Rezultat>();
            for(int i = 0;i<10;i++)
            {
                Rezultati.Add(new Rezultat("",0));
            }
        }
       

        
        public void AddRezultat(Rezultat rez)
        {
            for (int i = 0; i < Rezultati.Count; i++)
            {
                if (rez.score > Rezultati[i].score)
                {
                    Rezultati.RemoveAt(9);
                    Rezultati.Insert(i, rez);
                    break;
                }
            }
        }

        public bool CheckHighscore(Rezultat rez)
        {
            bool capable=false;
            foreach (Rezultat rezz in Rezultati)
            {
                if (rez.score > rezz.score)
                    capable = true;
            }
            return capable;
        }

        public bool CheckHighscore(int rez)
        {
            bool capable = false;
            for(int i= 0 ;i<Rezultati.Count;i++)
                if (rez > Rezultati[i].score)
                {
                    capable = true;
                    break;
                }
            return capable;
        }

    }
}
