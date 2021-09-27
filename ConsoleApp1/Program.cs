using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }

    class Point
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
        }
        private int y;
        public int Y
        {
            get
            {
                return y;
            }
        }

        private string name1;
        public string Name1
        {
            get
            {
                return name1;
            }
        }
        public Point() : this("", 0, 0) { }
        public Point(string name1, int x, int y)
        {
            Console.WriteLine("Ввудіть букву координат");
            this.name1 = Console.ReadLine();
            Console.WriteLine("Введіть X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }

    class Figure
    {
        int number;
        Point[] points;
        string name;
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
        public void InitializeFigure()
        {
            Console.WriteLine("Введіть кількість вершин фігури");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        
            public double CalculatePerimeter()
            {
                double perimeter = 0;
                for (int i = 1; i < points.Length; i++)
                {
                    perimeter += this.LengthSide(points[i - 1], points[i]);
                }
                perimeter += this.LengthSide(points[0], points[points.Length - 1]);
                return perimeter;
            }
            public Figure(string name)
            {
                InitializeFigure();
            }
        }

    }
