namespace Assotiationen_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde = new Kunde();
            Buch buch = new Buch(kunde);

            Kunde.setBuch(buch);
        }
    }
}