using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            namenEingeben();
            zahlenAusgabe();
            satzRueckwaerts();
            taschenRechner();
        }

        public static void namenEingeben()
        {
            Console.WriteLine("Geben Sie bitte ihreren Namen ein:");
            string namensVariable = Console.ReadLine();
            Console.WriteLine("Ihr Name lautet:" + namensVariable);
            string warte = Console.ReadLine();
        }

        public static void zahlenAusgabe()
        {
            Console.WriteLine("Geben Sie bitte ihreren Zahl ein:");
            int zahlenVariable = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < zahlenVariable+1; i++)
            {
                Console.WriteLine(i);
            }
            string warte = Console.ReadLine();
        }
        public static void satzRueckwaerts()
        {
            Console.WriteLine("Hallo, gibt einen Satz ein? :");
            string satz= Console.ReadLine();
            for (int i = satz.Length - 1; i >= 0; --i)
            {
                Console.Write(satz[i]);
            }

            string warte = Console.ReadLine();
        }
        public static void taschenRechner()
        {
            Console.WriteLine("Zahl 1:");
            double zahl_eins = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            double zahl_zwei = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operator eingeben");
            String theOperator = Console.ReadLine();
            double ergebnis = 0;

            switch (theOperator)
            {
                case "+":
                    ergebnis = zahl_eins + zahl_zwei;
                    break;
                case "-":
                    ergebnis = zahl_eins - zahl_zwei;
                    break;
                case "*":
                    ergebnis = zahl_eins * zahl_zwei;
                    break;
                case "/":
                    if (zahl_zwei == 0)
                    {
                        Console.WriteLine("Division durch O nicht erlaubt");
                        break;
                    }
                    else
                    {
                        ergebnis = zahl_eins / zahl_zwei;
                        break;
                    }
                default:
                    Console.WriteLine("Kein Operator angegeben");
                    break;
            }
                

            Console.WriteLine("Das Ergebnis ist:" + ergebnis);
            string warte = Console.ReadLine();
        }

    }
}
