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

            while (Continue == "y")
            {
                Console.WriteLine(name + "! Enter a number between 1 and 100, and perhaps I will be merciful.");
                try
                {
                    integer = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Why are you not entering numbers, mortal?");
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
                    if (integer % 2 == 0 && integer >= 26)
                    {
                        Console.WriteLine(integer + " Even");
                    }
                }
                else
                {
                    Console.WriteLine(name + ", you have failed me. I asked for a specific number.");
                }
                Console.WriteLine("Shall we continue? (y/n)");
                Continue = Console.ReadLine();
                Continue.ToLower();
            }

            Console.WriteLine(name + ", press any key to exit");
            Console.ReadKey();
        }
    }
}
