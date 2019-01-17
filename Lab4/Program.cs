using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I'm Joe, I'm here to help you square and cube whole numbers!");

            while (true)
            {

                Console.WriteLine("So, lets get started \nPlease enter a whole number.");

                int i;
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {

                    Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", "number", "squared", "cubed");
                    Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", "======", "=======", "=====");

                    for (i = 1; i <= number; ++i)
                    {

                        var squared = Math.Pow(i, 2);
                        var cubed = Math.Pow(i, 3);


                        Console.WriteLine("{0,10:0} {1,10:0} {2,10:0}", i, squared, cubed);



                    }

                    Console.WriteLine("Do you wish to continue? y/n");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine("Please enter 'y' or 'n'.");

                    }

                }
                else
                {
                    Console.WriteLine("Are you listening?\nPlease, re-enter your selection");
                    
                    
                }

                    continue;


            }
        }
    }
}
