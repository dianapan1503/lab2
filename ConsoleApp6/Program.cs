using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Address class1 = new Address();
            class1.Index = 022545;
            class1.City = "Kiev";
            class1.Country = "Ukraine";
            class1.House = 121;
            class1.Street = "Shevchenka";
            class1.Apartment = 23;
            Console.WriteLine($"{class1.Index}, {class1.City}, {class1.Country}, {class1.House}, {class1.Street}, {class1.Apartment}");
            Console.ReadLine();
        }
    }
    class Address
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }


    }
}


