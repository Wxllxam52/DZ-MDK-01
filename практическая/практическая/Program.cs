using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    // Задание 1: Person
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                    age = value;
                else
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                }
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
        }
    }

    // Задание 2: Phone
    class Phone
    {
        private string brand;
        private int batteryLevel;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                    batteryLevel = value;
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
            }
        }

        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void UsePhone()
        {
            batteryLevel -= 10;
            if (batteryLevel < 0) batteryLevel = 0;
            Console.WriteLine($"Телефон {Brand}, заряд: {BatteryLevel}%.");
        }
    }

    // Задание 3: BankAccount
    class BankAccount
    {
        private string owner;
        private double balance;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным!");
                    balance = 0;
                }
            }
        }

        public BankAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств!");
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
        }
    }

    // Задание 4: Circle
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0!");
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
    }

    // Задание 5: Pet
    class Pet
    {
        private string name;
        private int energy;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                    energy = value;
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                }
            }
        }

        public Pet(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public void Play()
        {
            energy -= 20;
            if (energy < 0) energy = 0;
            Console.WriteLine($"{Name} играет, энергия: {Energy}.");
        }

        public void Rest()
        {
            energy += 30;
            if (energy > 100) energy = 100;
            Console.WriteLine($"{Name} отдыхает, энергия: {Energy}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Person
            Person person = new Person("Никитка", 17);
            person.SayHello();
            person.Age = 150;
            person.Age = -5;

            Console.WriteLine();

            // Phone
            Phone phone = new Phone("apple", 90);
            phone.UsePhone();
            phone.UsePhone();
            phone.BatteryLevel = -10; // проверка

            Console.WriteLine();

            // BankAccount
            BankAccount account = new BankAccount("Семен", 1000000);
            account.Deposit(500);
            account.Withdraw(500);
            account.Withdraw(10000000); // попытка снять больше

            Console.WriteLine();

            // Тестируем Circle
            Circle circle = new Circle(-2); // проверка
            circle.GetArea();
            circle.Radius = 5;
            circle.GetArea();

            Console.WriteLine();

            // Pet
            Pet pet = new Pet("крыс", 150); // проверка
            pet.Play();
            pet.Rest();
            pet.Energy = 100;
            pet.Play();
            pet.Play();
            pet.Rest();

            Console.ReadLine();
        }
    }
}