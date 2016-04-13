using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraplyet
{
    class Program
    {
        static Boolean gamecomplete;
        static Boolean paraply;
        static Boolean gameover;
        static string input;
        static void Main(string[] args)
        {
            while (true)
            {
                gamecomplete = false;
                paraply = false;
                gameover = false;

                Console.WriteLine("--Välkommen till Jens morgonrutin--");
                Console.WriteLine("\nDet är en regnig morgon, Jens ska gå till arbetet, han kollar ut genom fönstret ser att det är regn som faller. Han tar på sig kläder men hittar inte sitt paraply. Vart vill du leta?");
                sovrummet();
                if (gameover)
                    Console.WriteLine("\nDu förlorade!!! Vill du spela igen? y/n");
                else
                    Console.WriteLine("\nDu vann!!! Vill du spela igen? y/n");
                input = Console.ReadLine();
                if (input == "n" || input == "no" || input == "nej")
                {
                    Console.WriteLine("Spelet stängs av...");
                    break;          
                }
                Console.WriteLine("Spelet startas om...");
                Console.ReadLine();
            }
        }

        private static void sovrummet()
        {
            while (true)
            {
                Console.WriteLine("\nDu är i sovrummet. Hallen är rakt framför dig");
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "hallen" || input == "gå till hallen" || input == "hallen gå")
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

                if (input == "utomhus" || input == "gå ut")
                {
                    if (paraply)
                    {
                        Console.WriteLine("Du går ut och kollar runtomkring");
                            break;
                            }
                    else
                        Console.WriteLine("Du kommer dö om du går ut");
                    }
                else if (input == "leta efter paraply" || input == "paraply")
                {
                    Console.WriteLine("Du hittade paraplyet och du kan nu gå ut utan att bli blöt.");
                    paraply = true;
                }


                else if (input == "kolla omkring" || input == "titta" || input == "titta omkring")
                    Console.WriteLine("Du ser en bänk, garderob, hatthylla och en dörr.");
                else if (input == "tips" || input == "hjälp")
                    Console.WriteLine("kanske finns i hallen?");
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");
            }
            utomhus();
        }
              
        private static void utomhus()
        {
            while (true)
            {
                Console.WriteLine("\nDu är nu utomhus. Hallen är bakom dörren du precis gick igenom. Vill du gå till vänster eller höger?");
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "hallen")
                    break;
                else if (input == "kolla omkring" || input == "titta" || input == "titta omkring")
                    Console.WriteLine("Du ser massor av bilar som kör förbi.");
                else if (input == "tips" || input == "hjälp")
                    Console.WriteLine("Gå till vänster eller höger?");
                else if (input == "vänster")
                {

                    Console.WriteLine("Du går till vänster och ser ett gäng som är skitarga och dödar dig. Du är död.");
                    gameover = true;
                    break;
                }
                else if (input == "höger")
                {
                    Console.WriteLine("Du går till höger och ser jobbet framför dig. Du har kommit till jobbet, Grattis!");
                    break;
                    gamecomplete = true;
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");
                {
                   
                }
            }
            if (gamecomplete)
                { }

            }

        }
    }