using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assotiationen_03
{
    internal class Kunde
    {
        private List<Buch> buecher = new List<Buch>();

        public void leiht(Buch buch)
        {
            if (!buch.Ausgeliehen)
            {
                buecher.Add(buch);
                buch.Ausgeliehen = true;
            }
        }
        public void setBuch(Buch buch)
        {
            this.buch = buch;
        }
    }
}   
