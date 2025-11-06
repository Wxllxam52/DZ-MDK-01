using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        protected string Species;
        protected int Age;
        protected string Habitat;
        protected string Diet;

        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Среда обитания: {Habitat}");
            Console.WriteLine($"Рацион: {Diet}");
        }
    }

    class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; }

        public Mammal(string species, int age, string habitat, string diet, string furType, int gestation) : base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationPeriod = gestation;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип меха: {FurType}");
            Console.WriteLine($"Беременность: {GestationPeriod} дней\n");
        }
    }

    class Bird : Animal
    {
        public double WingSpan { get; set; }
        public string NestType { get; set; }

        public Bird(string species, int age, string habitat, string diet, double wingSpan, string nestType) : base(species, age, habitat, diet)
        {
            WingSpan = wingSpan;
            NestType = nestType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Размах крыльев: {WingSpan} м");
            Console.WriteLine($"Тип гнезда: {NestType}\n");
        }
    }

    class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double PreferredT { get; set; }

        public Reptile(string species, int age, string habitat, string diet, string skinType, double temperature) : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            PreferredT = temperature;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип кожи: {SkinType}");
            Console.WriteLine($"Температура среды: {PreferredT}°C\n");
        }
    }

    class Fish : Animal
    {
        public string ScaleType { get; set; }
        public double Depth { get; set; }

        public Fish(string species, int age, string habitat, string diet, string scaleType, double depth) : base(species, age, habitat, diet)
        {
            ScaleType = scaleType;
            Depth = depth;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип чешуи: {ScaleType}");
            Console.WriteLine($"Глубина обитания: {Depth} м\n");
        }
    }
}
