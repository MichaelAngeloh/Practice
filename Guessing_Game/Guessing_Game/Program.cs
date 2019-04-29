using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int random = rnd.Next(1, 10);
            Console.WriteLine(random);//display random number for test purposes

            //ask user to guess a number between 1 - 10:
            Console.Write("Guess a number between 1 and 10: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (random == userInput)
            {
                Console.WriteLine("\nCongrats");
            }
            else if (random > userInput)
            {
                Console.WriteLine("Higher");
            }
            else if (random < userInput)
            {
                Console.WriteLine("Lower");
            }


            Console.Read();
        }
    }
}
