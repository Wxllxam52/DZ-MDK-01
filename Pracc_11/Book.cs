using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Book
    {
        private string title;

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Название не может быть пустым!");
                }
                else
                {
                    title = value;
                }
            }
        }

        public int Pages { get; set; } = 1;

        public bool IsLong => Pages > 300;

        public Book(string title)
        {
            Title = title;
        }
        public void Info()
        {
            string longText = IsLong ? "да" : "нет";
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {longText}");
        }
    }
}
