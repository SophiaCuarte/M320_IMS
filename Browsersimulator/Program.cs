using System;

namespace Browsersimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack(5);

            while (true)
            {
                Console.WriteLine("Enter a URL or 'e' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "e")
                    break;

                stack.Push(input);
            }

            Console.WriteLine("Remaining values in the stack:");
            while (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
