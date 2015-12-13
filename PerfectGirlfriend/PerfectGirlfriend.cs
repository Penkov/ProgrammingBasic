using System;

class PerfectGirlfriend
{
    static void Main()
    {
        string input = Console.ReadLine();

        int countPerfect = 0;
        while (input != "Enough dates!")
        {
            int result = 0;
            string[] splipInput = input.Split('\\');

            string day = splipInput[0];

            string phoneNumber = splipInput[1];

            string bra = splipInput[2];

            string name = splipInput[3];

            switch (day)
            {
                case "Monday":
                    result += 1;
                    break;
                case "Tuesday":
                    result += 2;
                    break;
                case "Wednesday":
                    result += 3;
                    break;
                case "Thursday":
                    result += 4;
                    break;
                case "Friday":
                    result += 5;
                    break;
                case "Saturday":
                    result += 6;
                    break;
                case "Sunday":
                    result += 7;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                result += phoneNumber[i] -'0';
            }

            int braSize = int.Parse(bra.Substring(0, bra.Length - 1));

            result += braSize * bra[bra.Length-1];

            int firstLetter = name[0];
            result -= name.Length * firstLetter;

            if (result < 6000)
            {
                Console.WriteLine("Keep searching, {0} is not for you.",name);
            }
            else
            {
                Console.WriteLine("{0} is perfect for you.",name);
                countPerfect ++;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(countPerfect);
    }
}

