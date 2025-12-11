using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### ЗАДАНИЕ 1 ###");
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band)
                i.Play();

            Console.WriteLine("### ЗАДАНИЕ 2 ###");
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages)
                m.Send();

            Console.WriteLine("### ЗАДАНИЕ 3 ###");
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch)
                f.Eat();

            Console.WriteLine("### ЗАДАНИЕ 4 ###");
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes)
                Console.WriteLine(s.Draw());

            Console.WriteLine("### ЗАДАНИЕ 5 ###");
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team)
                p.Attack();

            Console.ReadLine();
        }
    }
}
