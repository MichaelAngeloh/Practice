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
            DateTime now = DateTime.Now;
            string time = now.ToString("HH:mm");

            

            Console.Read();
        }
    }
}
