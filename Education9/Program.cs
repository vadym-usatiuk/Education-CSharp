using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education9
{
    class Program
    {

        static void Main(string[] args)
        {

            Person person1 = new Person("Mahon", "Dyma", "Antonovich");
            Person person2 = new Person("Goncharenko", "Anna", "Sergiyvna");

            System.Console.WriteLine(person1.GetPip());
            System.Console.WriteLine(person1.GetPipInitials());
            System.Console.WriteLine(person2.GetPip());
            System.Console.WriteLine(person2.GetPipInitials());

            System.Console.WriteLine(Person.GetClassDescription());

            System.Console.ReadLine();

        }

    }

    // class of human
    public class Person
    {
        public string Name = "";
        public string Surname = "";
        public string FatherName = "";

        public Person(string surname, string name, string fatherName)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
        }

        public string GetPip()
        {
            string Pip = Surname + " " + Name + " " + FatherName;
            return Pip;
        }

        public string GetPipInitials()
        {
            string Pip = Surname + " " + Name.Substring(0, 1) + ". " + FatherName.Substring(0, 1) + ".";
            return Pip;
        }


        public static string GetClassDescription()
        {
            return "Class Person. Have information about man.";
        }

    }

}
