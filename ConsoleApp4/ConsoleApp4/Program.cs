using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int integer = 0;
            string Continue = "y";


            Console.WriteLine("User! Enter your name: ");
            name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("If my patience endures I will give you meaningless information about a select few numbers.");
                Console.WriteLine(name + "! Enter a number between 1 and 100, and perhaps I will be merciful.");
                try
                {
                    integer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Why are you not entering numbers, mortal?");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Man, I don't even know what you're doing, just try it again.");
                    continue;
                }

                if (integer > 0 && integer <= 100)
                {
                    if (integer % 2 != 0)
                    {
                        Console.WriteLine(integer + " Odd");
                    }
                    if (integer % 2 == 0 && integer >= 2 && integer <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    if (integer % 2 == 0 && integer >= 26 && integer <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    if (integer % 2 == 0 && integer > 60)
                    {
                        Console.WriteLine(integer + " Even");
                    }
                }
                else
                {
                    Console.WriteLine(name + ", you have failed me. I asked for a specific number.");
                }
                outer:
                Console.WriteLine("Shall we continue? (y/n)");
                Continue = Console.ReadLine();
                Continue.ToLower();
                if (Continue == "y")
                { 
                    continue;                    
                }
                else if (Continue == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Can you please just use \"y\", \"n\"? Is that so hard?");
                    goto outer;
                }
            }
            Console.WriteLine("Very well. The pact is made.");
            Console.WriteLine("Press any key to remove yourself from my presence.");
            Console.ReadKey();
        }
    }
}
