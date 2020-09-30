using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to the High or Low game");

            //Choose random number
            Random rng = new Random();
            int number = rng.Next(1, 11);
            int tries = 0;
            while (true)
            {
                //User enters guess
                Console.Write("Enter your guess : ");
                tries = tries + 1;
                int guess = Convert.ToInt32(Console.ReadLine());

                //Compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low, go higher.");
                    Console.WriteLine("---------------------");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high, go lower.");
                    Console.WriteLine("---------------------");
                }
                else
                {
                    Console.WriteLine("Correct, welldone");
                    Console.WriteLine(tries.ToString() + " ,attemps");
                    break;
                }
            }

            Console.ReadKey();
            
        }
    }
}
