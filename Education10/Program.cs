using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education10
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two exemplars of class with difrent pip
            Person person1 = new Person("Klimkin", "Anton", "Antonovich");
            Person person2 = new Person("Nolova", "Anna", "Nikolaevna");

            System.Console.WriteLine(person1.Pip);
            System.Console.WriteLine(person1.PipInitials);
            System.Console.WriteLine(person2.Pip);
            System.Console.WriteLine(person2.PipInitials);
            System.Console.WriteLine(Person.ClassDescription);
            System.Console.ReadLine();
        }
    }

    // class of human
    public class Person
    {
        // three string variables properties available outside the class - public
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _surname = "";
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private string _fatherName = "";
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        public string Pip
        {
            get
            {
                string Pip = Surname + " " + Name + " " + FatherName;
                return Pip;
            }
        }

        public string PipInitials
        {
            get
            {
                string Pip = Surname + " " + Name.Substring(0, 1) + ". " + FatherName.Substring(0, 1) + ".";
                return Pip;
            }
        }

        // Constructor, a special function that is called when an instance of the class using the new words
        public Person(string surname, string name, string fatherName)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
        }

        public static string ClassDescription
        {
            get
            {
                return "Class Person. Have information about  human.";
            }
        }
    }
}
