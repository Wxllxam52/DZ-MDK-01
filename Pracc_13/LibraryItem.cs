using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; private set; }

        public LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
        }
        public abstract void DisplayInfo();
    }

    class Book : LibraryItem
    {
        public int PageCount { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int year, int pageCount, string isbn) : base(title, author, year)
        {
            PageCount = pageCount;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title} ({Year})");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Страниц: {PageCount}, ISBN: {ISBN}");
            Console.WriteLine($"Доступна: {(IsAvailable ? "Да" : "Нет")}\n");
        }
    }

    class Magazine : LibraryItem
    {
        public int Number { get; set; }
        public string Frequency { get; set; }

        public Magazine(string title, string author, int year, int number, string frequency) : base(title, author, year)
        {
            Number = number;
            Frequency = frequency;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Журнал: {Title} ({Year})");
            Console.WriteLine($"Редактор: {Author}");
            Console.WriteLine($"Выпуск №{Number}, Периодичность: {Frequency}");
            Console.WriteLine($"Доступен: {(IsAvailable ? "Да" : "Нет")}\n");
        }
    }

    class DVD : LibraryItem
    {
        public int Duration { get; set; }
        public string Rating { get; set; }

        public DVD(string title, string author, int year, int duration, string rating) : base(title, author, year)
        {
            Duration = duration;
            Rating = rating;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD: {Title} ({Year})");
            Console.WriteLine($"Режиссер: {Author}");
            Console.WriteLine($"Длительность: {Duration} мин, Рейтинг: {Rating}");
            Console.WriteLine($"Доступен: {(IsAvailable ? "Да" : "Нет")}\n");
        }
    }

    class Audiobook : LibraryItem
    {
        public double Length { get; set; }
        public string Narrator { get; set; }

        public Audiobook(string title, string author, int year, double length, string narrator) : base(title, author, year)
        {
            Length = length;
            Narrator = narrator;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Аудиокнига: {Title} ({Year})");
            Console.WriteLine($"Автор: {Author}, Диктор: {Narrator}");
            Console.WriteLine($"Длительность: {Length} ч");
            Console.WriteLine($"Доступна: {(IsAvailable ? "Да" : "Нет")}\n");
        }
    }
}
