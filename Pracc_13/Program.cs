using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Задание 1 ==========");
            Developer developer = new Developer("Владик", 120000, "2022-02-22", "C#");
            Manager manager = new Manager("Никита", 100, "2023-02-22", 5);
            Director director = new Director("Тарасик", 10, "2025-02-22", 10, "Разработка");

            Console.WriteLine("=== Разработчик ===");
            developer.DisplayInfo();
            developer.WriteCode();

            Console.WriteLine("\n=== Менеджер ===");
            manager.DisplayInfo();
            manager.Meet();

            Console.WriteLine("\n=== Директор ===");
            director.DisplayInfo();
            director.ApproveBudget();

            Console.WriteLine("\n========== Задание 2 ==========");
            CheckingAccount check = new CheckingAccount("001", "Иванов", 5000, 1000);
            SavingsAccount save = new SavingsAccount("002", "Петров", 10000, 5);
            CreditAccount credit = new CreditAccount("003", "Сидоров", -2000, 100 ,"завтра");

            Console.WriteLine("=== Текущий счет ===");
            check.DisplayInfo();

            Console.WriteLine("\n=== Сберегательный счет ===");
            save.DisplayInfo();
            save.AddInterest();

            Console.WriteLine("\n=== Кредитный счет ===");
            credit.DisplayInfo();

            Console.WriteLine("\n========== Задание 3 ==========");
            Book book = new Book("Идиот", "Достоевский", 1869, 100, "1111111");
            Magazine magazine = new Magazine("Журнальчик CSGO", "Кто-то", 2025, 12, "Ежемесячно");
            DVD dvd = new DVD("Тачки 52", "Текст...", 2025, 2, "21+");
            Audiobook audiobook = new Audiobook("Подкаст о роблокс", "Никита", 2025, 12.5, "Никитка Сергеевич");
            
            book.DisplayInfo();
            magazine.DisplayInfo();
            dvd.DisplayInfo();
            audiobook.DisplayInfo();

            Console.WriteLine("\n========== Задание 4 ==========");
            VideoCourse VideoCourse = new VideoCourse("Основы C#", "Изучение синтаксиса и ООП", "Великий человек", 0, 100, 9999);
            TextCourse TextCourse = new TextCourse("Учимся читать", "Для детей", "Учитель начальной школы", 10000000, 1, 30);
            InteractiveCourse InteractiveCourse = new InteractiveCourse("Алгоритмы", "Практические задачи", "Ну да, Я", 150, 20, true);

            VideoCourse.DisplayInfo();
            TextCourse.DisplayInfo();
            InteractiveCourse.DisplayInfo();

            Console.WriteLine("\n========== Задание 5 ==========");
            Mammal Mammal = new Mammal("Лев", 5, "Саванна", "Мясо", "Короткий мех", 110);
            Bird Bird = new Bird("Орёл", 3, "Горы", "Падаль", 2.3, "На скалах");
            Reptile Reptile = new Reptile("Игуана", 2, "Тропики", "Растения", "Чешуя", 30);
            Fish Fish = new Fish("Акула", 8, "Океан", "Рыба", "Мелкая чешуя", 200);

            Mammal.DisplayInfo();
            Bird.DisplayInfo();
            Reptile.DisplayInfo();
            Fish.DisplayInfo();
        }
    }
}
