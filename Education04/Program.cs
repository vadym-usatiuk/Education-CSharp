using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVariable = true;

            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = true");
            }
            else
            {
                System.Console.WriteLine("boolVariable = false");
            }

            System.Console.WriteLine();

            boolVariable = false;

            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = false");
            }
            else
            {
                System.Console.WriteLine("boolVariable = false");
            }

            boolVariable = 3 < 4;

            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = 3 < 4");
            }
            else
            {
                System.Console.WriteLine("boolVariable = 3 > 4");
            }

            if (99 != 100)
            {
                System.Console.WriteLine("99 != 100");
            }

            System.Console.WriteLine();

            System.Console.ReadLine();
        }
    }
}
