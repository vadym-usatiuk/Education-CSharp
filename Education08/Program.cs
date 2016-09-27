using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education8
{
    class Program
    {
        public static string CreatePip(string surname, string name, string fatherName)
        {
            string fip= surname + " " + name + " " + fatherName;
            return fip;
        }

        public static string CreatePipInitials(string surname, string name, string fatherName)
        {
            string fip = surname + " " + name.Substring(0, 1) + ". " + fatherName.Substring(0, 1) + ".";
            return fip;
        }


        static void Main(string[] args)
        {


            string name = "Oleksandr";
            string fatherName = "Sergiyovich";
            string surname = "Virichenko";


            string nameSecond = "Nataly";
            string fatherNameSecond = "Nikolyvna";
            string surnameSecond = "Popova";

            System.Console.WriteLine(CreatePip(surname, name, fatherName));
            System.Console.WriteLine(CreatePipInitials(surname, name, fatherName));
            System.Console.WriteLine(CreatePip(surnameSecond, nameSecond, fatherNameSecond));
            System.Console.WriteLine(CreatePipInitials(surnameSecond, nameSecond, fatherNameSecond));

            System.Console.ReadLine();

        }

    }
}
