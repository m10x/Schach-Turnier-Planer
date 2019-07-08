using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schach_Turnier_Planer
{
    public class Team
    {
        public Team (string Name, string Stadt, string Partner, int Nummer)
        {
            this.Name = Name;
            this.Stadt = Stadt;
            this.Partner = Partner;
            this.Nummer = Nummer;
        }
        public string Name { get; set; }
        public string Stadt { get; set; }
        public string Partner { get; set; }
        public int Nummer { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
