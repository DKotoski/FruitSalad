using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoSeminarska
{
    [Serializable]
    class Rezultat
    {
        public string Ime { get; set; }
        public int score { get; set; }

        public Rezultat(string Ime, int score)
        {
            this.Ime = Ime;
            this.score = score;
        }
    }
}
