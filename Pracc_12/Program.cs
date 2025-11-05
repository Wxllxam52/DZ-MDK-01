using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43l0v3k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАДАНИЕ 1 ===");
            double num1 = 15;
            double num2 = 3;

            Console.WriteLine($"Сложение: {num1} + {num2} = {Calculator.Add(num1, num2)}");
            Console.WriteLine($"Вычитание: {num1} - {num2} = {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Умножение: {num1} * {num2} = {Calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Деление: {num1} / {num2} = {Calculator.Divide(num1, num2)}");

            double num3 = 10;
            double num4 = 0;

            Console.WriteLine($"\nПопытка деления: {num3} / {num4}");
            double result = Calculator.Divide(num3, num4);
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("\n=== ЗАДАНИЕ 2 ===");
            ProgramConfig.ShowInfo();

            Console.WriteLine("\n=== ЗАДАНИЕ 3 ===");
            ObjectCounter.ShowCount();
            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter obj3 = new ObjectCounter();
            ObjectCounter.ShowCount();

            Console.WriteLine("\n=== ЗАДАНИЕ 4 ===");
            Book book = new Book("111-666-000", "Идиот", "Достоевский");
            book.ShowInfo();

            Console.WriteLine("\n=== ЗАДАНИЕ 5 ===");
            Settings.ShowConfigPath();
            Console.ReadLine();
        }
    }
}
