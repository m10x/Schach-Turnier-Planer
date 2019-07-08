using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach_Turnier_Planer
{
    class Termin
    {
        public Termin(int Runde, string Paarung)
        {
            this.Runde = Runde;
            this.Paarung = Paarung;
        }

        public int Runde { get; set; }
        public string Paarung { get; set; }
    }
}
