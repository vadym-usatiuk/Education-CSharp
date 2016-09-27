using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Make reverse of number
namespace Education12
{
    public static class IntExtension
    {
        public static int Reverse(this int num)
        {
            int result = 0;
            while (num != 0)
            {
                result += num % 10;
                num /= 10;
                result *= 10;
            }
            return result / 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num.Reverse());
            Console.ReadKey(true);
        }
    }
}
