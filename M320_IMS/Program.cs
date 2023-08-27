class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("1. ggT berechnen");
            Console.WriteLine("2. kgV berechnen");
            Console.WriteLine("3. Array-Funktionen");
            Console.WriteLine("4. Beenden");
            Console.Write("Option wählen: ");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 4)
                break;

            if (option < 1 || option > 3)
            {
                Console.WriteLine("Ungültige Option!");
                continue;
            }

            int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
            int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");


            if (option == 1)
                MyMath.ShowResult("ggT", a, b, MyMath.Calc_ggT(a, b));
            else if (option == 2)
                MyMath.ShowResult("kgV", a, b, MyMath.Calc_kgV(a, b));
            else if (option == 3)
            {
                int arraySize = MyMath.ReadInt("Geben Sie die Größe des Arrays ein: ");
                int[] numbers = new int[arraySize];
                for (int i = 0; i < arraySize; i++)
                    numbers[i] = MyMath.ReadInt($"Geben Sie die Zahl an Index {i} ein: ");

                Console.WriteLine($"Arithmetischer Mittelwert: {MyMath.CalcArithmeticMean(numbers)}");
                Console.WriteLine($"Kleinster Wert: {MyMath.FindSmallestValue(numbers)}");
                Console.WriteLine($"Größter Wert: {MyMath.FindLargestValue(numbers)}");

                MyMath.ReverseArray(numbers);
                Console.WriteLine("Umgekehrtes Array: " + string.Join(" ", numbers));
            }

            Console.WriteLine();
        }
    }
}
