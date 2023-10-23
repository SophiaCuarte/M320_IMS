using System;
using Fussballmannschaft;

class Program
{
    static void Main()
    {
        Fussballms heimMannschaft = new Fussballms();
        Fussballms gastMannschaft = new Fussballms();

        heimMannschaft.HinzufuegenSpieler(new Feldspieler("Spieler1"));
        heimMannschaft.HinzufuegenSpieler(new Feldspieler("Spieler2"));
        gastMannschaft.HinzufuegenSpieler(new Feldspieler("Spieler3"));
        gastMannschaft.HinzufuegenSpieler(new Feldspieler("Spieler4"));

        Spiel spiel = new Spiel(heimMannschaft, gastMannschaft);
        spiel.Spielen();
    }
}