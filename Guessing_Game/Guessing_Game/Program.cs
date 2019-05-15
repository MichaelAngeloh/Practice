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
            Console.WriteLine("I am thinkig of a number between 1 and 10: ");

            for (int i = 0; i < 3; i++)
            {
                //ask user to guess a number between 1 - 10:
                Console.Write("Enter Guess #{0}: ", i + 1);
                int userInput = Convert.ToInt32(Console.ReadLine());


                if (i == 2)
                {
                    Console.WriteLine("Max number of tries reached");
                    break;
                }

                if (random == userInput)
                {
                    Console.WriteLine("\nCongrats You Won");
                    break;
                }
                else if (random > userInput)
                {
                    Console.WriteLine("Higher");
                }
                else if (random < userInput)
                {
                    Console.WriteLine("Lower");
                }


            }


            Console.Read();
        }
    }
}
