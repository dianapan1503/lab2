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
            Book class1 = new Book();
            class1.Book1 = "Ваша книга:";

            Title class2 = new Title();
            class2.Title1 = "Введіть назву:";
            
            Author class3 = new Author();
            class3.Author1 = "ВВедіть Автора:";
            

            Content class4 = new Content();
            class4.Content1 = "Введіть зміст:";

            Console.WriteLine($"{class1.Book1}");
           

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{class2.Title1}");

            string name1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{class3.Author1}");

            string name2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{class4.Content1}");

            string name = Console.ReadLine();


            Console.ReadLine();
        }
    }
    class Book
    {
        private string book1;
        public string Book1
        {
            get
            {
                return book1;
            }
            set
            {
                book1 = value;
            }
        }

        static void Show()
        { }
    }

    class Title
    {
        private string title1;
        public string Title1
        {
            get
            {
                return title1;
            }
            set
            {
                title1 = value;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Місто");

        }
    }

        class Author
        {
            private string author1;
            public string Author1
            {
                get
                {
                    return author1;
                }
                set
                {
                    author1 = value;
                }
            }

            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Валер'ян Підмогильний");
            }

        }

        class Content
        {
            private string content1;
            public string Content1
            {
                get
                {
                    return content1;
                }
                set
                {
                    content1 = value;
                }
            }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" tth");
            }

        }

    
}
