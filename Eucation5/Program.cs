using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVar1 = true;
            bool boolVar2 = true;

            if (boolVar1 && boolVar2)
            {
                System.Console.WriteLine("Return  true logical And for true and true");
            }
            if (boolVar1 || boolVar2)
            {
                System.Console.WriteLine("Return true logical Or for true and true");
            }

            boolVar1 = true;
            boolVar2 = false;

            if (boolVar1 && boolVar2)
            {
                System.Console.WriteLine("Return  true logical And for true and false");
            }
            if (boolVar1 || boolVar2)
            {
                System.Console.WriteLine("Return true logical Or for true and false");
            }

            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
