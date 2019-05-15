using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] intArray = new int[10] { 0, 0, -2, 5, 12, 0, 0, -1, 5, 0 };
            //output -2, 5, 12, -1, 5, 0, 0, 0, 0, 0


            for (int i = 0; i < intArray.Length; i++)
            {
                //Console.Write("{0} , ", intArray[i]);

                if (intArray[i] != 0 )
                {
                    int n = 0;
                    intArray[n] = intArray[i];


                    Console.Write(intArray[n] + ", ");
                }

            }

            Console.Read();
        }
    }
}
