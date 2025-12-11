using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Point - Задание 1 ===");
            var p1 = new Point(1, 2);
            var p2 = new Point(3, 4);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p2 - p1);

            Console.WriteLine("=== Counter - Задание 2 ===");
            var c = new Counter("Счётчик", 10);
            c = c + 5;
            Console.WriteLine(c);
            c["value"] = 20;
            Console.WriteLine(c["value"]);

            Console.WriteLine("=== Temperature - Задание 3 ===");
            var t1 = new Temperature(25);
            var t2 = new Temperature(30);
            Console.WriteLine(t1);
            Console.WriteLine(t2 > t1);
            Console.WriteLine(t1 == new Temperature(25));

            Console.WriteLine("=== Book - Задание 4 ===");
            var book = new Book();
            book[0] = "Введение";
            book[1] = "Глава 1";
            Console.WriteLine(book[0]);
            Console.WriteLine(book);

            Console.WriteLine("=== Vector - Задание 5 ===");
            var v1 = new Vector(1, 2, 3);
            var v2 = new Vector(4, 5, 6);
            Console.WriteLine(v1 * v2);
            v1[1] = 10;
            Console.WriteLine(v1);
        }
    }
}
