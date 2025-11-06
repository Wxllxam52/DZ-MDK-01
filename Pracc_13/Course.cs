using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Course(string title, string description, string author, decimal price)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Курс: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Цена: {Price} руб.");
            Console.WriteLine($"Описание: {Description}");
        }
    }

    // 🔹 Видеокурс
    class VideoCourse : Course
    {
        public int VideoCount { get; set; }
        public double TotalDuration { get; set; }

        public VideoCourse(string title, string description, string author, decimal price, int videoCount, double totalDuration) : base(title, description, author, price)
        {
            VideoCount = videoCount;
            TotalDuration = totalDuration;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Видео: {VideoCount}, Общая длительность: {TotalDuration} часов\n");
        }
    }

    class TextCourse : Course
    {
        public int ChapterCount { get; set; }
        public int TotalWords { get; set; }

        public TextCourse(string title, string description, string author, decimal price, int chapters, int totalWords) : base(title, description, author, price)
        {
            ChapterCount = chapters;
            TotalWords = totalWords;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Глав: {ChapterCount}, Объем текста: {TotalWords} слов\n");
        }
    }
    class InteractiveCourse : Course
    {
        public int ExerciseCount { get; set; }
        public bool HasAutoCheck { get; set; }

        public InteractiveCourse(string title, string description, string author, decimal price, int exercises, bool hasAutoCheck) : base(title, description, author, price)
        {
            ExerciseCount = exercises;
            HasAutoCheck = hasAutoCheck;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Упражнений: {ExerciseCount}, Автопроверка: {(HasAutoCheck ? "Да" : "Нет")}\n");
        }
    }
}
