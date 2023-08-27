using System;

class MyMath
{
    public static int Calc_ggT(int a, int b)
    {
        while (b != 0) (b, a) = (a % b, b);
        return a;
    }

    public static int Calc_kgV(int a, int b) => (a * b) / Calc_ggT(a, b);

    public static int ReadInt(string prompt)
    {
        int result;
        do Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);
        return result;
    }

    public static void ShowResult(string operation, int a, int b, int result) =>
        Console.WriteLine($"{operation} von {a} und {b} ist {result}");

    public static int Calc_ggT_r(int a, int b) => b == 0 ? a : Calc_ggT_r(b, a % b);

    public static double CalcArithmeticMean(int[] numbers) => (double)numbers.Sum() / numbers.Length;

    public static int FindSmallestValue(int[] numbers) => numbers.Min();

    public static int FindLargestValue(int[] numbers) => numbers.Max();

    public static void Swap(ref int a, ref int b) => (a, b) = (b, a);

    public static void ReverseArray(int[] array)
    {
        for (int left = 0, right = array.Length - 1; left < right; left++, right--)
            Swap(ref array[left], ref array[right]);
    }
}
