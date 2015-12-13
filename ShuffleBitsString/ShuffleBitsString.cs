using System;
using System.Text;

class ShuffleBitsString
{
    static void Main()
    {
        uint firstNumber = uint.Parse(Console.ReadLine());
        string firstNumberString = Convert.ToString(firstNumber, 2).PadLeft(32,'0');

        uint secondNumber = uint.Parse(Console.ReadLine());
        string secondNumberString = Convert.ToString(secondNumber, 2).PadLeft(32, '0');

        ulong result = 0;

        StringBuilder stringResult = new StringBuilder();

        if (firstNumber >= secondNumber)
        {
            for (int i = 0; i < 32; i++)
            {
                stringResult.Append(firstNumberString[i].ToString());
                stringResult.Append(secondNumberString[i].ToString());
            }
        }
        else
        {
            for (int i = 0; i < 31; i+=2)
            {
                stringResult.Append(firstNumberString[i].ToString());
                stringResult.Append(firstNumberString[i + 1].ToString());
                stringResult.Append(secondNumberString[i].ToString());
                stringResult.Append(secondNumberString[i + 1].ToString());
            }
        }
        Console.WriteLine(Convert.ToUInt64(stringResult.ToString(), 2););
        

    }
}

