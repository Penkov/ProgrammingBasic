using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class PerfectGirlfriend
{

    static void Main()
    {
        //Четем от конзолата
        string input = Console.ReadLine();
        //Брояч на жени
        int count = 0;

        //цикъл за четенето на всеки ред
        while (input != "Enough dates!")
        {
            //взимаме деня
            string dayOfWeek = input.Substring(0, input.IndexOf("\\"));
            input = input.Remove(0, dayOfWeek.Length + 1);

            //взимаме телефона
            string phone = input.Substring(0, input.IndexOf('\\'));
            input = input.Remove(0, phone.Length + 1);
                
            //взимаме сутиена
            string bra = input.Substring(0, input.IndexOf('\\'));
            input = input.Remove(0, bra.Length + 1);

            //Взимаме името
            string name = input.Substring(0, input.Length);
            //Monday, you get 1, Tuesday-> 2, Wednesday-> 3, Thursday-> 4, Friday-> 5, Saturday->6 and Sunday -> 7
            //Ден от седмицата
            int numberDayOfWeek = 0;

            switch (dayOfWeek)//извежданео на деня 
            {
                case "Monday":
                    numberDayOfWeek = 1;
                    break;
                case "Tuesday":
                    numberDayOfWeek = 2;
                    break;
                case "Wednesday":
                    numberDayOfWeek = 3;
                    break;
                case "Thursday":
                    numberDayOfWeek = 4;
                    break;
                case "Friday":
                    numberDayOfWeek = 5;
                    break;
                case "Saturday":
                    numberDayOfWeek = 6;
                    break;
                case "Sunday":
                    numberDayOfWeek = 7;
                    break;
            }
            //променливата която смята всичко и пибавяме деня от седмицата 
            int result = numberDayOfWeek;

            //Цикъл взимаме всеки елемент от стринга phone парсваме го към инт и го добавяме към резултата
            for (int i = 0; i < phone.Length - 1; i++)
            {
                int num = int.Parse(phone[i].ToString());
                result += num;
            }

            //взимаме големината на сутиена
            int braSize = int.Parse(bra.Substring(0, bra.Length - 1));

            //взимаме тайпа на сутиена
            char braType = char.Parse(bra.Remove(0, bra.Length - 1));

            //добавяме към ресултата тайпа по големината
            result += braSize * (int)braType;

            // взимаме първата буква от името 
            char firstChar = char.Parse(name.Substring(0, 1));

            //умножаваме буквата по дължината на името и вадим стойността от резултата
            result -= (int)firstChar * name.Length;
                
            //проверяваме дали резултата е по малък от 6000
            if (result < 6000)
            {
                Console.WriteLine("Keep searching, {0} is not for you.", name);
                    
            }
            else//ако не е 
            {
                Console.WriteLine("{0} is perfect for you.",name) ;
                //добавяме жена удобрената към каунта
                count++;
            }
                
            //четем пак реда
            input = Console.ReadLine();
        }
        //принтим броя на жените
        Console.WriteLine(count);

    }
}

