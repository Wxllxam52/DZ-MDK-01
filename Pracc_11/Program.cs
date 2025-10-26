using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАДАНИЕ 1 ===");
            Car BMW = new Car("MERCEDES C63", 150);
            BMW.Drive();
            BMW.Speed = 400;
            BMW.Drive();
            BMW.Speed = -50;
            BMW.Drive();

            Console.WriteLine("\n=== ЗАДАНИЕ 2 ===");
            Phone myPhone = new Phone("Apple Сифон", 80);
            myPhone.Use();
            myPhone.Use();
            myPhone.Use();
            myPhone.BatteryLevel = 150;

            Console.WriteLine("\n=== ЗАДАНИЕ 3 ===");
            Book book1 = new Book("Война и мир");
            book1.Pages = 999;
            book1.Info();
            book1.Title = "";
            Book book2 = new Book("Моя жизнь");
            book2.Info();

            Console.WriteLine("\n=== ЗАДАНИЕ 4 ===");
            Player player = new Player("Noob228", 1, 100);
            player.TakeDamage(30);
            player.TakeDamage(30);
            player.TakeDamage(40);
            player.Level = 0;

            Console.WriteLine("\n=== ЗАДАНИЕ 5 ===");
            Product macbook = new Product(1000, 20);
            macbook.Name = "Apple Macbook";
            macbook.Show();
            macbook.Discount = 10;
            macbook.Show();
            macbook.Price = -50;
        }
    }
}
