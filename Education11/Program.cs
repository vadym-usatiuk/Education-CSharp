using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//There are 3 numbers. Bring them in increasing order
namespace Education11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Number 3: ");
            num3 = int.Parse(Console.ReadLine());
            int[] arr = new int[] { num1, num2, num3 };
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write("{0} ", i);
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
