using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5



{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Rectangle class2 = new Rectangle(a, b);
            class2.AreaCalculator();
            class2.PerimeterCalculator();
            Console.WriteLine($" Area = {class2.AreaCalculator()}, P = {class2.PerimeterCalculator()}");
            Console.ReadLine();
        }
    }
    class Rectangle

    {
        private double side1;
        public double Side1

        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }

        private double side2;
        public double Side2

        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

    }
}

