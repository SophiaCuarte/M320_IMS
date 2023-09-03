using System;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Einfacher Taschenrechner");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Beenden");

        char option;
        do
        {
            Console.Write("Wählen Sie eine Option (1/2/3/4/5): ");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (option >= '1' && option <= '4')
            {
                Console.Write("Geben Sie die erste Zahl ein: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie die zweite Zahl ein: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                switch (option)
                {
                    case '1':
                        result = calculator.Add(num1, num2);
                        break;
                    case '2':
                        result = calculator.Subtract(num1, num2);
                        break;
                    case '3':
                        result = calculator.Multiply(num1, num2);
                        break;
                    case '4':
                        result = calculator.Divide(num1, num2);
                        break;
                }

                Console.WriteLine("Ergebnis: " + result);
            }
            else if (option == '5')
            {
                Console.WriteLine("Das Programm wird beendet.");
            }
            else
            {
                Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
            }

        } while (option != '5');
    }
}
