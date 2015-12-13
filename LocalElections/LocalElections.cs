using System;
using System.Runtime.InteropServices;

class LocalElections
{
    static void Main()
    {
        int cand = int.Parse(Console.ReadLine());
        int check = int.Parse(Console.ReadLine());

        string checkSymbol = Console.ReadLine().ToUpper();

        for (int i = 1; i <= cand; i++)
        {
            Console.WriteLine("{0}", new string('.',13));
            Console.WriteLine("{0}+{1}+{0}",new string('.',3), new string('-',5));
            if (check == i)
            {
                if (checkSymbol == "X")
                {
                    Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3));
                    Console.WriteLine("{0}.|..{1}..|{2}", i < 10 ? "0" + i : i.ToString(), checkSymbol,
                        new string('.', 3));
                    Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3));

                }
                else
                {
                    Console.WriteLine("{0}|\\{0}/|{0}", new string('.', 3));
                    Console.WriteLine("{0:00}.|.\\./.|{1}", i, new string('.', 3));
                    Console.WriteLine("{0}|..{1}..|{0}", new string('.', 3), checkSymbol);
                }
            }
            else
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.',3),new string('.',5));
                Console.WriteLine("{0}.|{1}|{2}",
                    i.ToString().PadLeft(2,'0'),
                    new string('.',5),
                    new string('.',3));
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));

            }
            Console.WriteLine("{0}+{1}+{0}", Dots(3), new string('-', 5));
        }
        Console.WriteLine("{0}", new string('.', 13));
    }

    public static string Dots(int count)
    {
        string dots = new string('.',count);

        return dots;
    }
}

