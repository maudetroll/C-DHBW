using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Zahlen
    {
        private static void Hauptmethode(string[] args)
        {
            Console.WriteLine("Geben Sie bitte ihreren Zahl ein:");
            int zahlenVariable = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < zahlenVariable; i++)
            {
                Console.WriteLine(i);
            }
            string warte = Console.ReadLine();
        }
    } 
}

