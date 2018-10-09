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

            Console.WriteLine("User! Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine(name + "! Enter a number between 1 and 100, and perhaps I will be merciful.");
            integer = int.Parse(Console.ReadLine());

            if (integer > 0 && integer <= 100)
            {
                if(integer % 2 != 0)
                {
                    Console.WriteLine(integer + " Odd");
                }
                if(integer % 2 == 0 && integer >= 2 && integer <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                if(integer % 2 == 0 && integer >= 26)
                {
                    Console.WriteLine(integer + " Even");
                }
            }
            else
            {
                Console.WriteLine(name + ", you have failed me. I asked for a specific number. I will now leave you.");
            }
            

            Console.WriteLine(name + ", press any key to exit");
            Console.ReadKey();
        }
    }
}
