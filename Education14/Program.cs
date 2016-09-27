using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Find the sum of first 10 natural numbers
namespace Education14
{
    class Program
    {
        public class Exercise2
        {
            public static void Main()
            {
                int j, sum = 0;
                Console.Write("The first 10 natural number is :\n");
                for (j = 1; j <= 10; j++)
                {
                    sum = sum + j;
                    Console.Write("{0} ", j);
                }
                Console.Write("\nThe Sum is : {0}\n", sum);
                Console.ReadKey();
            }
        }
    }
}
