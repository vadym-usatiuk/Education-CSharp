using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            System.Console.WriteLine("a =  " + a + ", b = " + b);

            int result = a + b;
            System.Console.WriteLine("addition, a + b =  " + result);

            result = a * b;
            System.Console.WriteLine("multiplication, a * b =  " + result);

            result = a / b;
            System.Console.WriteLine("Division, a / b =  " + result + " a и  b - integer type of numbers");

            double resultDouble = a / b;
            System.Console.WriteLine("Division, a / b =  " + resultDouble + " also something wrong");

            double aDouble = 5;
            resultDouble = aDouble / b;
            System.Console.WriteLine("Division, a / b =  " + resultDouble);

            System.Console.ReadLine();
        }
    }
}
