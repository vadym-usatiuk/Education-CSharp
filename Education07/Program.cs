using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                int reminder3 = counter % 3;
                int reminder5 = counter % 5;
                string result = "";

                if (reminder3 == 0)
                {
                    result += "Fizz";
                }
                if (reminder5 == 0)
                {
                    result += "Buzz";
                }
                if (reminder3 != 0 && reminder5 != 0)
                {
                    result = counter.ToString();
                }
                System.Console.WriteLine(result);
            }
            System.Console.ReadLine();

        }
    }
}
