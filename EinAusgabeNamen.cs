using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EinAusgabeNamen
    {
        static void Namen(string[] args)
        {
            Console.WriteLine("Geben Sie bitte ihreren Namen ein:");
            string namensVariable= Console.ReadLine();
            Console.WriteLine("Ihr Name lautet:" + namensVariable);
            string warte= Console.ReadLine();


        }
    }
}
