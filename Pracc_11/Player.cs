using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Player
    {
        private int level;
        private int health;

        public int Level
        {
            get => level;
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Уровень должен быть от 1 до 100!");
                }
                else
                {
                    level = value;
                }
            }
        }

        public int Health
        {
            get => health;
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > 100)
                    health = 100;
                else
                    health = value;
            }
        }

        public string Name { get; init; }
        public bool IsAlive => Health > 0;

        public Player(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            string aliveText = IsAlive ? "да" : "нет";
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {aliveText}");
        }
    }
}
