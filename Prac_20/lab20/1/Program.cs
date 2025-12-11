public class NotEnoughMoneyException : Exception
    {
        public decimal Balance { get; }
        public decimal Amount { get; }

        public NotEnoughMoneyException(decimal balance, decimal amount)
            : base($"Недостаточно средств! Баланс: {balance}, нужно: {amount}")
        {
            Balance = balance;
            Amount = amount;
        }
    }

    public class WrongPinException : Exception
    {
        public int AttemptsLeft { get; }

        public WrongPinException(int attemptsLeft)
            : base($"Неверный PIN! Осталось попыток: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }

    public class ATM
    {
        private decimal _balance;
        private const int MaxAttempts = 3;
        private int _attemptsLeft = MaxAttempts;
        private bool _isBlocked = false;
        private const int CorrectPin = 1234;

        public ATM(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (_isBlocked)
            {
                Console.WriteLine("Карта заблокирована!");
                return;
            }
            if (amount > _balance)
            {
                throw new NotEnoughMoneyException(_balance, amount);
            }
            _balance -= amount;
        }

        public void EnterPin(int pin)
        {
            if (_isBlocked)
            {
                Console.WriteLine("Карта заблокирована!");
                return;
            }
            if (pin == CorrectPin)
            {
                _attemptsLeft = MaxAttempts;
                Console.WriteLine("PIN правильный");
            }
            else
            {
                _attemptsLeft--;
                if (_attemptsLeft == 0)
                {
                    _isBlocked = true;
                    Console.WriteLine("Карта заблокирована!");
                }
                else
                {
                    throw new WrongPinException(_attemptsLeft);
                }
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }

    class Program
    {
        static void Main()
        {
            ATM atm = new ATM(500);
            Console.WriteLine($"Баланс: {atm.GetBalance()}");
            decimal amountToWithdraw = 1000;
            Console.WriteLine($"Снимаем {amountToWithdraw}...");
            try
            {
                atm.Withdraw(amountToWithdraw);
            }
            catch (NotEnoughMoneyException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ввод PIN: ");
                string input = Console.ReadLine();
                int pin;
                if (int.TryParse(input, out pin))
                {
                    try
                    {
                        atm.EnterPin(pin);
                    }
                    catch (WrongPinException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }
    }