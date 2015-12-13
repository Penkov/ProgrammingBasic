using System;

class ShuffleBits
{
    static void Main()
    {
        uint firstNumber = uint.Parse(Console.ReadLine());

        uint secondNumber = uint.Parse(Console.ReadLine());

        ulong result = 0;

        if (firstNumber >= secondNumber)
        {
            for (int i = 31; i >= 0; i--)
            {
                result = result << 1 | ((firstNumber >> i) & 1);
                result = result << 1 | ((secondNumber >> i) & 1);
            }
            
        }
        else
        {
            for (int i = 31; i >= 0; i-=2)
            {
                result = result << 1 | ((firstNumber >> i) & 1);
                result = result << 1 | ((firstNumber >> i - 1) & 1);
                result = result << 1 | ((secondNumber >> i) & 1);
                result = result << 1 | ((secondNumber >> i - 1) & 1);
                
            }
        }
        Console.WriteLine(result);

    }
}

