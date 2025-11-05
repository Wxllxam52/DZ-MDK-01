using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43l0v3k
{
    internal class Book
    {
        private readonly string isbn;

        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn;
            Title = title;
            Author = author;
        }

        public void ShowInfo()
        {
            Console.WriteLine("=== Информация о книге ===");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine("==========================");
        }
    }
}
