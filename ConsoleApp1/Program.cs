using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            int num2 = 0;

            Console.WriteLine("KALKULATOR\r");
            Console.WriteLine("Wpisz pierwsza liczbe i nacisnij Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wpisz druga liczbe i nacisnij Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("\t1 - Dodawanie");
            Console.WriteLine("\t2 - Odejmowanie");
            Console.WriteLine("\t3 - Mnozenie");
            Console.WriteLine("\t4 - Dzielenie");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}