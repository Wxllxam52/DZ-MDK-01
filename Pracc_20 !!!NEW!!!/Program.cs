using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // =============================== ЗАДАНИЕ 1 ===============================
        public class NotEnoughMoneyException : Exception
        {
            public NotEnoughMoneyException(decimal amount, decimal Balance) : base($"Недостаточно средств! У вас {Balance}, а нужно {amount}") { }
        }
        public class WrongPinException : Exception
        {
            public WrongPinException() : base($"Карта заблокирована. Пожалуйста, обратитесь в поддержку банка!") { }
        }
        internal class ATM
        {
            private string Name;
            private decimal Balance;
            private int attemptsLeft = 3;
            private int PIN;
            private bool Auth = false;

            public ATM(string name, decimal balance, int pin)
            {
                Name = name; Balance = balance; PIN = pin;
            }

            public void Withdraw(decimal amount)
            {
                if (Auth == false)
                {
                    Console.WriteLine("Сначала необходимо ввести пинкод!");
                }
                else
                {
                    if (amount <= 0) throw new ArgumentException("Ошибка: Сумма должна быть больше 0!");
                    if (amount > Balance) throw new NotEnoughMoneyException(amount, Balance);

                    Balance -= amount;
                    Console.WriteLine($"Снято {amount}. Остаток: {Balance}");

                }
            }

            public void EnterPin(int pin)
            {
                if (Auth == true)
                {
                    Console.WriteLine("Вы уже ввели пинкод.");
                }
                else
                {
                    if (pin != PIN)
                    {
                        attemptsLeft--;
                        if (attemptsLeft == 0) throw new WrongPinException();
                        Console.WriteLine($"Пинкод не верный осталось попыток: {attemptsLeft}");
                    }
                    else
                    {
                        Console.WriteLine("PIN верный. Добро пожаловать!");
                        attemptsLeft = 3;
                        Auth = true;
                    }
                }
            }
            public void Logout()
            {
                Auth = false;
                Console.WriteLine("Вы успешно вышли из аккаунта");
            }
        }

        // =============================== ЗАДАНИЕ 2 ===============================
        public class ProductOutOfStockException : Exception
        {
            public ProductOutOfStockException(string product, int left) : base($"Товар '{product}' закончился! Остаток: {left} шт. ") { }
        }

        public class OnlineShop
        {
            private Dictionary<string, int> products;

            public OnlineShop(Dictionary<string, int> Products)
            {
                products = Products;
            }

            public void Buy(string product, int quantity)
            {
                Console.WriteLine($"Попытка покупки '{product}' в размере {quantity} шт.");
                
                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"Товара '{product}' нет в магазине.");
                    return;
                }

                int left = products[product];
                if (left < quantity)
                {
                    throw new ProductOutOfStockException(product, left);
                }
                else
                {
                    products[product] -= quantity;
                    Console.WriteLine($"Успешно куплено: {product} - {quantity} шт.");
                }
            }
        }

        // =============================== ЗАДАНИЕ 3 ===============================
        public class LoginAlreadyExistsException : Exception
        {
            public LoginAlreadyExistsException(string login) : base($"Ошибка! Логин: {login} уже занят!") { }
        }
        public class WeakPasswordException : Exception
        {
            public WeakPasswordException() : base($"Слабый пароль! Необходимо минимум 6 символов") { }
        }
        public class UserService
        {
            private List<string> Logins = new List<string>();

            public void Register(string login, string password)
            {
                if (Logins.Contains(login)) throw new LoginAlreadyExistsException(login);
                if (password.Length < 6) throw new WeakPasswordException();

                Logins.Add(login);
                Console.WriteLine($"Пользователь {login} успешно зарегистрирован!");
            }
        }

        // =============================== ЗАДАНИЕ 4 ===============================
        class HeroIsDeadException : Exception
        {
            public HeroIsDeadException(string Nick, int health) : base($"Герой '{Nick}' погиб! Здоровье стало {health}") { }
        }
        class Game
        {
            private string Nick { get; set; }
            private int Health { get; set; }

            public Game(string nick, int health)
            {
                Nick = nick; Health = health;
            }

            public void TakeDamage(int damage)
            {
                Health -= damage;

                if (Health <= 0) throw new HeroIsDeadException(Nick, Health);
                else Console.WriteLine($"Герой '{Nick}' получил урон, текущее здоровье: {Health}");
            }
        }

        // =============================== ЗАДАНИЕ 5 ===============================
        class BookAlreadyTakenException : Exception
        {
            public BookAlreadyTakenException(string book, string reader) : base($"Книга '{book}' уже у {reader}!") { }
        }
        class Library
        {
            private Dictionary<string, string> takenBooks = new Dictionary<string, string>();

            public void TakeBook(string bookName, string reader)
            {
                if (takenBooks.ContainsKey(bookName))
                    throw new BookAlreadyTakenException(bookName, takenBooks[bookName]);

                takenBooks[bookName] = reader;
                Console.WriteLine($"{reader} берёт: '{bookName}'");
            }

            public void ReturnBook(string bookName, string reader)
            {
                if (takenBooks.ContainsKey(bookName))
                {
                    Console.WriteLine($"{reader} возвращает книгу: '{bookName}'");
                    takenBooks.Remove(bookName);
                }
                else
                {
                    Console.WriteLine($"Книга '{bookName}' и так свободна");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== ЗАДАНИЕ 1 =====");
            ATM test = new ATM("Тест", 500, 1234);
            test.Withdraw(100);
            test.EnterPin(1235);
            test.EnterPin(1236);
            try
            {
                test.EnterPin(1237);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n===== ЗАДАНИЕ 2 =====");
            OnlineShop shop = new OnlineShop(new Dictionary<string, int>(){ { "iPhone", 2 } });
            shop.Buy("iPhone", 2);
            try
            {
                shop.Buy("iPhone", 2);
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n===== ЗАДАНИЕ 3 =====");
            UserService service = new UserService();
            service.Register("Admin", "12345678");
            try
            {
                service.Register("Admin", "Другой пароль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                service.Register("User", "badp");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n===== ЗАДАНИЕ 4 =====");
            Game pers = new Game("Рандомный перс", 100);
            try
            {
                pers.TakeDamage(150);
            }
            catch (HeroIsDeadException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n===== ЗАДАНИЕ 5 =====");
            Library library = new Library();
            try
            {
                library.TakeBook("Война и мир", "Анна");
                library.TakeBook("Война и мир", "Петр");
            }
            catch (BookAlreadyTakenException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                library.ReturnBook("Война и мир", "Анна");
                library.ReturnBook("Война и мир", "Анна");
            }
            catch (BookAlreadyTakenException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
