using System;

namespace Fussballmannschaft
{
    public class Spiel
    {
        public Fussballms HeimMannschaft { get; private set; }
        public Fussballms GastMannschaft { get; private set; }

        public Spiel(Fussballms heimMannschaft, Fussballms gastMannschaft)
        {
            HeimMannschaft = heimMannschaft;
            GastMannschaft = gastMannschaft;
        }

        public void Spielen()
        {
            Console.WriteLine("Spiel beginnt...");
            int toreHeim = HeimMannschaft.Spielzug();
            int toreGast = GastMannschaft.Spielzug();
            Console.WriteLine($"Spiel beendet! Ergebnis: Heim {toreHeim} - {toreGast} Gast");
        }
    }
}