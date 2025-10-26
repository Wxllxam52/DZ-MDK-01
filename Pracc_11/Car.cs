using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Car
    {
        private int speed;

        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Скорость не может быть меньше 0!");
                }
                else if (value > 300)
                {
                    Console.WriteLine("Скорость не может превышать 300!");
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Model { get; init; } = "Unknown";

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }
    }
}
