using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paedafwe
{
    internal class Product
    {
        private double price;
        private double discount;

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                }
                else
                {
                    price = value;
                }
            }
        }

        public double Discount
        {
            get => discount;
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Скидка должна быть от 0 до 100%");
                }
                else
                {
                    discount = value;
                }
            }
        }
        public double FinalPrice => Price * (1 - Discount / 100);

        public string Name { get; set; } = "Без названия";

        public Product(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
        }
    }
}
