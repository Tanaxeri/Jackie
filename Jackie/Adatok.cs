using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    internal class Adatok
    {

        public Adatok(string Sor)
        {
            string[] sorelemek = Sor.Split('\t');
            this.Ev = Convert.ToInt32(sorelemek[0]);
            this.Verseny = Convert.ToInt32(sorelemek[1]);
            this.Nyert = Convert.ToInt32(sorelemek[2]);
            this.Dobogos = Convert.ToInt32(sorelemek[3]);
            this.Elso_helyrol = Convert.ToInt32(sorelemek[4]);
            this.Leggyorsabb = Convert.ToInt32(sorelemek[5]);
        }
        public int Ev { get; set; }
        public int Verseny { get; set; }
        public int Nyert { get; set; }
        public int Dobogos { get; set; }
        public int Elso_helyrol { get; set; }
        public int Leggyorsabb { get; set; }

    }
}
