using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Instrument
    {
        public virtual void Play() => Console.WriteLine("Играет музыка...");
    }

    class Guitar : Instrument
    {
        public override void Play() => Console.WriteLine("Брень-брень!");
    }

    class Drum : Instrument
    {
        public override void Play() => Console.WriteLine("Бум-бум!");
    }
    class Message
    {
        public virtual void Send() => Console.WriteLine("Сообщение отправлено.");
    }

    class Email : Message
    {
        public override void Send() => Console.WriteLine("Email отправлен!");
    }

    class SMS : Message
    {
        public override void Send() => Console.WriteLine("SMS отправлено!");
    }

    class Food
    {
        public virtual void Eat() => Console.WriteLine("Едим...");
    }

    class Pizza : Food
    {
        public override void Eat() => Console.WriteLine("Едим пиццу!");
    }

    class Burger : Food
    {
        public override void Eat() => Console.WriteLine("Едим бургер!");
    }

    abstract class Shape
    {
        public abstract string Draw();
    }

    class Circle : Shape
    {
        public override string Draw() => "Рисую круг";
    }

    class Triangle : Shape
    {
        public override string Draw() => "Рисую треугольник";
    }

    class Player
    {
        public virtual void Attack() => Console.WriteLine("Атакую!");
    }

    class Warrior : Player
    {
        public override void Attack() => Console.WriteLine("Рублю мечом!");
    }

    class Archer : Player
    {
        public override void Attack() => Console.WriteLine("Стреляю из лука!");
    }
}
