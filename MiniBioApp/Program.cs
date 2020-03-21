using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Emre Dursun";
            int leeftijd = 32;
            string geboorteplaats = "Turkije";
            string vorigBeroep = "wiskundige";
            string woonplaats = "Haaksbergen";
            Console.WriteLine("Ik ben " + fullName + ", " + leeftijd + " jaar" + "en geboren in " + geboorteplaats + ".");
            Console.WriteLine($"\n\tAls {vorigBeroep} werkte ik meer dan 3 jaar in verschillende landen.");
            Console.Write($"\n\t\tIk woon momenteel in {woonplaats}.");
            Console.ReadLine();
        }
    }
}
