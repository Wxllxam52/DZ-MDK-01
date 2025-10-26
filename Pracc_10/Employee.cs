using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Employee
    {
        private string name;
        private double salary;

        public string Name 
        {
            get { return name; } set { name = value; } 
        }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Зарплата должна быть от 1 до 1 млн! Установлено 1");
                    salary = 1;
                }
                else salary = value; 
            }
        }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee(string name) : this(name, 50000) { }

        public void Work()
        {
            Console.WriteLine($"{name} работает, зарплата {salary}");
        }
    }
}
