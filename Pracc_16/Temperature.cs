using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Temperature
    {
        public int Celsius { get; set; }

        public Temperature(int celsius)
        {
            Celsius = celsius;
        }

        public static bool operator >(Temperature a, Temperature b)
        {
            return a.Celsius > b.Celsius;
        }

        public static bool operator <(Temperature a, Temperature b)
        {
            return a.Celsius < b.Celsius;
        }

        public static bool operator ==(Temperature a, Temperature b)
        {
            return a.Celsius == b.Celsius;
        }

        public static bool operator !=(Temperature a, Temperature b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Temperature t)
                return Celsius == t.Celsius;
            return false;
        }

        public override int GetHashCode()
        {
            return Celsius.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Celsius}°C";
        }
    }
}
