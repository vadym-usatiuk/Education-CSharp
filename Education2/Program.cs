using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Education2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToShowFirst, stringToShowSecond;

            string surName = "Uskov";
            string firstName = "Vadym";
            string secondName = "Valerievich";

            int age = 24;
            double weight = 92.2;

            stringToShowFirst = surName + " " + firstName + " " + secondName + ", year old " + age + ", weight " + weight;

            surName = "Voronsov";
            firstName = "Arthur";
            secondName = "Laslovich";

            age = 24;
            weight = 70;

            stringToShowSecond = surName + " " + firstName + " " + secondName + ", year old " + age + ", weight " + weight;

            System.Console.WriteLine(stringToShowFirst);
            System.Console.WriteLine(stringToShowSecond);

            System.Console.ReadLine();
        }
    }
}