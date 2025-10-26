using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАДАНИЕ 1 ===");
            Book book1 = new Book("Война и мир", 12000);
            Book book2 = new Book();
            Book book3 = new Book("1984");
            Book book4 = new Book("Война и мир 2", 5000);
            book1.Read();
            book2.Read();
            book3.Read();
            book4.Read();

            Console.WriteLine("\n=== ЗАДАНИЕ 2 ===");
            Employee emp1 = new Employee("Владик", 100000);
            Employee emp2 = new Employee("Никитка", -2);
            emp1.Work();
            emp2.Work();

            Console.WriteLine("\n=== ЗАДАНИЕ 3 ===");
            Laptop laptop = new Laptop("Toshiba", 16, 80);
            laptop.PowerOn();
            laptop.Work();
            laptop.Ram = 0;
            laptop.Work();

            Console.WriteLine("\n=== ЗАДАНИЕ 4 ===");
            Point p1 = new Point(3.5, 7.2);
            Point p2 = new Point(5);
            Point p3 = new Point();
            p1.Show();
            p2.Show();
            p3.Show();

            Console.WriteLine("\n=== ЗАДАНИЕ 5 ===");
            Cat cat1 = new Cat("Мурзик");
            Cat cat2 = new Cat("Барсик", 8);
            cat1.Speak();
            cat1.Meow();
            cat1.Meow();
            cat2.Speak();
            cat2.Meow();
        }
    }
}
