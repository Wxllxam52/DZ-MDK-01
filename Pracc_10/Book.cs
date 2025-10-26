using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; } set { title = value; } 
        }

        public int Pages 
        { 
            get { return pages; } 
            set 
            {
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Страницы должны быть от 1 до 5000! Установлено 1");
                    pages = 1;
                }
                else 
                {
                    pages = value;
                }
            } 
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public Book(string title) : this(title, 100) { }
        public Book() : this("Без названия", 1) { }

        public void Read()
        {
            Console.WriteLine($"Читаю книгу '{title}', страниц {pages}.");
        }
    }
}
