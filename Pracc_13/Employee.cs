using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string HireDate { get; set; }

        public Employee(string name, string position, double salary, string hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Зарплата: {Salary} руб.");
            Console.WriteLine($"Дата приема: {HireDate}");
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, double salary, string hireDate, int teamSize) : base(name, "Менеджер", salary, hireDate)
        {
            TeamSize = teamSize;
        }

        public void Meet()
        {
            Console.WriteLine($"{Name} проводит собрание команды из {TeamSize} человек.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размер команды: {TeamSize}");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, double salary, string hireDate, string language) : base(name, "Разработчик", salary, hireDate)
        {
            ProgrammingLanguage = language;
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пишет код на {ProgrammingLanguage}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Язык программирования: {ProgrammingLanguage}");
        }
    }

    class Director : Manager
    {
        public string Department { get; set; }

        public Director(string name, double salary, string hireDate, int teamSize, string department) : base(name, salary, hireDate, teamSize)
        {
            Position = "Директор";
            Department = department;
        }

        public void ApproveBudget()
        {
            Console.WriteLine($"{Name} утвердил бюджет отдела {Department}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
    }
}
