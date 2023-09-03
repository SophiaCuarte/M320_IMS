class Calculator
{
    private int lastResult = 0; // Interner Zustand zur Speicherung des letzten Ergebnisses

    public int Add(params int[] operands)
    {
        int sum = lastResult;

        foreach (int operand in operands)
        {
            sum += operand;
        }

        lastResult = sum;
        return lastResult;
    }

    public int Subtract(params int[] operands)
    {
        if (operands.Length < 1)
        {
            Console.WriteLine("Es wurden nicht genügend Argumente angegeben.");
            return lastResult;
        }

        int result = operands[0];

        for (int i = 1; i < operands.Length; i++)
        {
            result -= operands[i];
        }

        lastResult = result;
        return lastResult;
    }

    public int Multiply(params int[] operands)
    {
        int product = 1;

        foreach (int operand in operands)
        {
            product *= operand;
        }

        lastResult = product;
        return lastResult;
    }

    public int Divide(params int[] operands)
    {
        if (operands.Length < 1)
        {
            Console.WriteLine("Es wurden nicht genügend Argumente angegeben.");
            return lastResult;
        }

        int result = operands[0];

        for (int i = 1; i < operands.Length; i++)
        {
            if (operands[i] == 0)
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                return lastResult;
            }
            result /= operands[i];
        }

        lastResult = result;
        return lastResult;
    }
}
