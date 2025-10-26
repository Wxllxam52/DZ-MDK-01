using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{name} издаёт звук.");
        }
    }
}
