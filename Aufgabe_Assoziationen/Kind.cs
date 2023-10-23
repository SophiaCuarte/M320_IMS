using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Assoziationen
{
    internal class Kind
    {
        private Vater vater;

        public void setVater(Vater vater)
        {
            this.vater = vater;
        }
    }
}
