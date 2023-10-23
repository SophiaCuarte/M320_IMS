using System;

namespace Fussballmannschaft
{
    public class Resultat
    {
        public Spiel Spiel { get; private set; }

        public Resultat(Spiel spiel)
        {
            Spiel = spiel;
        }
    }
}