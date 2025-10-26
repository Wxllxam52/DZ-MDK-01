using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Device(string brand)
        {
            this.brand = brand;
        }

        public void PowerOn()
        {
            Console.WriteLine($"{brand} включён.");
        }
    }
}
