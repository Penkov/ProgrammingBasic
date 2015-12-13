using System;

class ProspectInHospitality
{
    static void Main()
    {
        decimal buildersSalary = 1500.04m;
        decimal receptionistsSalary = 2102.10m;
        decimal chambermaidsSalary = 1465.46m;
        decimal techniciansSalary = 2053.33m;
        decimal othersSalary = 3010.98m;

        uint b = uint.Parse(Console.ReadLine());
        buildersSalary *= b;

        uint r = uint.Parse(Console.ReadLine());
        receptionistsSalary *= r;

        uint c = uint.Parse(Console.ReadLine());
        chambermaidsSalary *= c;

        uint t = uint.Parse(Console.ReadLine());
        techniciansSalary *= t;

        uint o = uint.Parse(Console.ReadLine());
        othersSalary *= o;

        decimal nikiSalary = decimal.Parse(Console.ReadLine());

        decimal usd = decimal.Parse(Console.ReadLine());

        nikiSalary *= usd;

        decimal youSalary = decimal.Parse(Console.ReadLine());

        decimal budget = decimal.Parse(Console.ReadLine());

        decimal result = buildersSalary + receptionistsSalary
                         + techniciansSalary + chambermaidsSalary + othersSalary + nikiSalary + youSalary;
        Console.WriteLine("The amount is: {0:F2} lv.",result);

        if (budget >= result)
        {
            Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - result);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", -1 *(budget - result));
        }

    }
}

