namespace Wasserfass_Teil1
{
    internal class Program
    {
        public class Wasserfass
        {
            private readonly double MinimalPegel = 0;
            public static double Kapazität;
            private readonly double MaximalPegel = Kapazität;
            public double Füllstand;

            public Wasserfass(double minimalPegel, double maximalPegel, double kapazität)
            {
                MinimalPegel = minimalPegel;
                MaximalPegel = maximalPegel;
                Kapazität = kapazität;
                Füllstand = minimalPegel;
            }

            public void befüllen(double menge)
            {
                if (Füllstand + menge <= Kapazität && Füllstand + menge <= MaximalPegel)
                {
                    Füllstand += menge;
                }
            }

            public void entnehmen(double menge)
            {
                if (Füllstand - menge >= MinimalPegel)
                {
                    Füllstand -= menge;
                }
            }

            public void entleeren()
            {
                Füllstand = MinimalPegel;
            }
        }
    }
}