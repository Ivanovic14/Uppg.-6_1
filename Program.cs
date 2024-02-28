using System;
using System.Collections.Generic;

namespace Uppg_6_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal.");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in en till.");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in sista talet.");
            int tal3 = int.Parse(Console.ReadLine());
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
    }
}
