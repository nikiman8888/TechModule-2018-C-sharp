using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string input = Console.ReadLine();

            var data = new List<Box>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string serial = tokens[0];

                string itemName = tokens[1];

                int quanity = int.Parse(tokens[2]);

                decimal priceItem = decimal.Parse(tokens[3]);

                Item curentItem = new Item(itemName,priceItem);

                var currentBox = new Box(serial, curentItem, quanity, curentItem.Price * quanity);

                data.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in data.OrderByDescending(x =>x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quanity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    class Box 
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quanity { get; set; }
        public decimal PriceBox { get; set; }

        public Box(string serial, Item item ,int quanity,decimal price)
        {
            this.SerialNumber = serial;
            this.Item = item;
            this.Quanity = quanity;
            this.PriceBox = price;
        }
    }
}
