using System;
    using System.Collections.Generic;

    public class ProductOutOfStockException : Exception
    {
        public string ProductName { get; }
        public int RemainingQuantity { get; }

        public ProductOutOfStockException(string productName, int remainingQuantity)
            : base($"Товар \"{productName}\" закончился! Осталось: {remainingQuantity}")
        {
            ProductName = productName;
            RemainingQuantity = remainingQuantity;
        }
    }

    public class Onlineshop
    {
        private Dictionary<string, int> products;

        public Onlineshop(Dictionary<string, int> initialProducts)
        {
            products = initialProducts;
        }

        public void Buy(string product, int quantity)
        {
            if (!products.ContainsKey(product))
            {
                Console.WriteLine($"Товар \"{product}\" не найден в магазине.");
                return;
            }

            int stock = products[product];

            if (stock == 0 || stock < quantity)
            {
                throw new ProductOutOfStockException(product, stock);
            }

            products[product] -= quantity;
            Console.WriteLine($"Вы успешно купили {quantity} {product}. Остаток: {products[product]}");
        }
    }

    class Program
    {
        static void Main()
        {
            var initialProducts = new Dictionary<string, int>
        {
            { "Phone", 1 },
            { "Epol", 0 }
        };

            var shop = new Onlineshop(initialProducts);

            Console.WriteLine("Покупаем Phone");
            try
            {
                shop.Buy("Phone", 1);
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine($"Овибка: {ex.Message}");
            }

            Console.WriteLine("Покупаем Epol");
            try
            {
                shop.Buy("Epol", 1);
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine($"Овибка: {ex.Message}");
            }
        }
    }