using System;

class SudokuResults
{
    static void Main()
    {
        string input = Console.ReadLine();

        int sec = 0;

        int countGames = 0;
        while (input != "Quit")
        {
            countGames++;

            int min = int.Parse(input.Substring(0, 2));

            sec += int.Parse(input.Substring(3, 2));

            sec += min * 60;

            input = Console.ReadLine();
        }

        double avr = Math.Ceiling((double)sec/countGames);

        if (avr < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if(avr <= 1440 && avr >= 720)
        {
            Console.WriteLine("Silver Star");
        }
        else if (avr > 1440)
        {
            Console.WriteLine("Bronze Star");
        }
        Console.WriteLine("Games - {0} \\ Average seconds - {1}", countGames,
            avr);
    }
}

