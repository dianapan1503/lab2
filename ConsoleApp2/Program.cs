using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User class1 = new User();
            class1.Login = "rob15";
            class1.Name = "Rob";
            class1.Surname = "Clark";
            class1.Age = 45;
            class1.Date = "15.07.21";
            Console.WriteLine($"{class1.Login}, {class1.Name}, {class1.Surname}, {class1.Age}, {class1.Date}");
            Console.ReadLine();
        }
    }

    class User
    {
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string surname;
        public string Surname

        {
            get 
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }
}
