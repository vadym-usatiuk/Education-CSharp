using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Generate an array X (N), N-1, a member which is defined by X (N) = 1 / N!
namespace Education13
{
    class Program
    {
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("The quantity: ");
            int count = Int16.Parse(Console.ReadLine());
            double[] array = new double[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = 1.0 / (double)Factorial(i);
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }
    }
}
