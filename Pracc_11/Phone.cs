using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Phone
    {
        private int battery;

        public int BatteryLevel
        {
            get => battery;
            set
            {
                if (value < 0)
                {
                    battery = 0;
                    Console.WriteLine("Заряд не может быть меньше 0! Установлено 0.");
                }
                else if (value > 100)
                {
                    battery = 100;
                    Console.WriteLine("Заряд не может превышать 100! Установлено 100.");
                }
                else
                {
                    battery = value;
                }
            }
        }

        public string Brand { get; init; }

        public Phone(string brand, int battery)
        {
            Brand = brand;
            BatteryLevel = battery;
        }

        public void Use()
        {
            if (BatteryLevel >= 10)
            {
                BatteryLevel -= 10;
            }
            else
            {
                BatteryLevel = 0;
            }
            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%");
        }
    }
}
