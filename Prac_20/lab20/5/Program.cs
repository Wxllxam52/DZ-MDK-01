public class BookAlreadyTakenException : Exception
    {
        public string BookName { get; }
        public string Reader { get; }

        public BookAlreadyTakenException(string bookName, string reader)
            : base($"Ошибка: Книга \"{bookName}\" уже у {reader}!")
        {
            BookName = bookName;
            Reader = reader;
        }
    }
    public class KaccLibrary
    {
        private class BookInfo
        {
            public string Reader { get; set; }
        }
        private Dictionary<string, BookInfo> books = new Dictionary<string, BookInfo>();
        public void TakeBook(string bookName, string reader)
        {
            if (!books.ContainsKey(bookName))
            {
                books[bookName] = new BookInfo();
            }
            if (books[bookName].Reader != null)
            {
                throw new BookAlreadyTakenException(bookName, books[bookName].Reader);
            }
            else
            {
                books[bookName].Reader = reader;
                Console.WriteLine($"{reader} берёт \"{bookName}\"");
            }
        }
        public void ReturnBook(string bookName)
        {
            if (books.ContainsKey(bookName) && books[bookName].Reader != null)
            {
                Console.WriteLine($"{books[bookName].Reader} возвращает книгу");
                books[bookName].Reader = null;
                Console.WriteLine("Теперь можно брать");
            }
            else
            {
                Console.WriteLine($"Книга \"{bookName}\" свободна или не взята");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            var library = new KaccLibrary();
            library.TakeBook("Война и мир", "Анна");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Петр пытается взять \"Война и мир\"");
                library.TakeBook("Война и мир", "Петр");
            }
            catch (BookAlreadyTakenException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            library.ReturnBook("Война и мир");
            Console.WriteLine();
            library.TakeBook("Война и мир", "Петр");
        }
    }