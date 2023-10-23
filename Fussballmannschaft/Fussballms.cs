using System;
using System.Collections.Generic;

namespace Fussballmannschaft
{
    public class Fussballms
    {
        private List<Feldspieler> feldspielerList;
        private Torwart torwart;

        public Fussballms()
        {
            feldspielerList = new List<Feldspieler>();
            torwart = new Torwart("Torwart");
        }

        public void HinzufuegenSpieler(Feldspieler spieler)
        {
            feldspielerList.Add(spieler);
        }

        public int Spielzug()
        {
            int tore = 0;
            foreach (var spieler in feldspielerList)
            {
                spieler.AufsTorSchiessen();
                spieler.Graetschen();
                spieler.Dribbeln();
                tore++;
            }

            torwart.SchussHalten();
            torwart.Abstoss();

            return tore;
        }
    }
}