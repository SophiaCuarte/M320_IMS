namespace Aufgabe_Assoziationen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vater papa = new Vater();
            Kind kind = new Kind();
            papa.setKind(kind);
            kind.setVater(papa);
        }
    }
}