using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Counter
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Counter(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public static Counter operator +(Counter c, int amount)
        {
            c.Value += amount;
            return c;
        }

        public int this[string key]
        {
            get
            {
                if (key.ToLower() == "value")
                    return Value;
                throw new Exception("Неверный ключ");
            }
            set
            {
                if (key.ToLower() == "value")
                    Value = value;
                else
                    throw new Exception("Неверный ключ");
            }
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
