using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prac
{
    internal class Cat : Animal
    {
        private int lives;

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1) lives = 1;
                else if (value > 9) lives = 9;
                else lives = value;
            }
        }

        public Cat(string name, int lives) : base(name)
        {
            Lives = lives;
        }

        public Cat(string name) : this(name, 9)
        {
        }

        public void Meow()
        {
            if (Lives > 1) Lives--;
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
        }
    }
}
