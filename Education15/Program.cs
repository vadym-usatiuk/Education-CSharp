using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Reverse string
namespace Education15
{
    class Program
    {
        static void Main(string[] args)
        {
            string comp = "computer";
            Console.WriteLine(comp = new string(comp.Reverse().ToArray()));
            Console.ReadKey();
        }
    }
}
