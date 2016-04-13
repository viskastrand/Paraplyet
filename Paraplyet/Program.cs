using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraplyet
{
    class Program
    {
        static Boolean gamecomplete = false;
        static Boolean paraply = false;
        static string input;
        static void Main(string[] args)
        {
            Console.WriteLine("--Välkommen till Jens morgonrutin--");
            Console.WriteLine("\nDet är en regnig morgon, Jens ska gå till arbetet, han kollar ut genom fönstret ser att det är regn som faller. Han tar på sig kläder men hittar inte sitt paraply. Vart vill du leta?");
            sovrummet();
            Console.WriteLine("\nDu vann!!! Spelet stängs av...");
            Console.ReadLine();
        }

        private static void sovrummet() {
            while (true)
            {
                Console.WriteLine("\nDu är i sovrummet. Hallen är rakt framför dig");
                Console.Write("\n>");
                input = Console.ReadLine();      

                if (input == "hallen")
                        break;
                else if (input == "leta efter paraply" || input == "paraply")
                    Console.WriteLine("Du hittar ingenting.");
                else if (input == "kolla omkring" || input == "titta")
                    Console.WriteLine("Du ser en säng och en dörr till hallen");
                else if (input == "tips" || input == "hjälp")
                    Console.WriteLine("kanske finns i hallen?");
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");
            }
        hallen();
        }
        private static void hallen()
        {
            while (true)
            {
                Console.WriteLine("\nDu är i hallen. Sovrummet är bakom dig.");
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "sovrummet")
                    break;
                else if (input == "leta efter paraply" || input == "paraply")
                {
                    Console.WriteLine("Du hittade paraplyet och du kan nu gå ut utan att bli blöt.");
                    gamecomplete = true;
                    paraply = true;
                    break;
                }

                else if (input == "kolla omkring" || input == "titta" || input == "titta omkring")
                    Console.WriteLine("Du ser en bänk, garderob, hatthylla och en dörr.");
                else if (input == "tips" || input == "hjälp")
                    Console.WriteLine("kanske finns i hallen?");
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");
            }
            if (gamecomplete)
            { }
            else
                sovrummet();
        }

   }
}