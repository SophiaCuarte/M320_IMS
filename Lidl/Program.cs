namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() { Vorname = "Felix", Name = "Trunz"};
            var kunde1 = new Kunde() { Vorname = "Felix", Name = "Trunz", Umsatz = 9999999999999999999};
            var lagerist1 = new Lagerist() { Vorname = "Hans", Name = "Meier", Groesse = 180};

            //person1.Esse();
            kunde1.Esse(); 
            kunde1.Kaufe();
            lagerist1.Esse();
            lagerist1.LagereEin();
            kunde1.Trage();
            lagerist1.Trage();
        }
    }
}