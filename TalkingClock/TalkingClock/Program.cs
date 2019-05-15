using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingClock
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime now = DateTime.Now;
            //string time = now.ToString("HH:mm");
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] ten = { "ten","twenty","thirty","fourty","fifty" };

            string time = "09:59";
            string[] timeSplit = time.Split(':');
            int hour = Convert.ToInt32(timeSplit[0]);
            int min = Convert.ToInt32(timeSplit[1]);

            //Console.Write("{0},{1}", hour, min);

            Console.Write("The time is ");

            if (hour > 13)
            {
                Console.Write("{0}", hour % 12);
            }
            else if(hour < 13)
            {
                Console.Write("{0} {1} {2}",digits[hour-1],ten[min /10 - 1], digits[min % 10 - 1]);
            }


            Console.Read();
        }
    }
}
