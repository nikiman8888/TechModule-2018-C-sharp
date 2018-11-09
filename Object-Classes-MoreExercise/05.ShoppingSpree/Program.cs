using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string [] personsData = Console.ReadLine().Split(';');

            string [] productPrice = Console.ReadLine().Split(';');

            var savePersons = new List<Person>();

            var saveProduct = new List<Product>();

            for (int i = 0; i < personsData.Length; i++)
            {
                string[] tokens = personsData[i].Split('=');

                string currentPersonName = tokens[0];

                decimal currentMoney = decimal.Parse(tokens[1]);

                var currentPerson = new Person(currentPersonName, currentMoney,new List<string>());

                savePersons.Add(currentPerson);

            }
            for (int i = 0; i < productPrice.Length; i++)
            {
                string[] tokens = productPrice[i].Split('=');
                if (tokens.Length < 2)
                {
                    continue;// zashtoto ima niakakva ; nakraia i pravi nepravilen element 
                }

                string currentProductName = tokens[0];

                decimal price = decimal.Parse(tokens[1]);

                var currentProduct = new Product(currentProductName, price);

                saveProduct.Add(currentProduct);

            }
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                string buyerName = tokens[0];

                string productName = tokens[1];

                bool existBuyer = savePersons.Any(x => x.Name == buyerName);
                bool existProduct = saveProduct.Any(x => x.Name == productName);

                if (existBuyer && existProduct)
                {
                    foreach (var person in savePersons)
                    {
                        if (person.Name == buyerName)
                        {     
                            //take the price of needed product
                            decimal cost = saveProduct.Where(x => x.Name == productName).Select(x => x.Cost).First();
                            
                            if (person.Money >= cost)
                            {
                                person.Money -= cost;

                                Console.WriteLine($"{person.Name} bought {productName}");

                                person.Bag.Add(productName);

                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{person.Name} can't afford {productName}");

                                break;
                            }
                        }
                    }
                }
                                                              
                input = Console.ReadLine();
            }

            foreach (var currentPerson in savePersons)
            {
                if (currentPerson.Bag.Count > 0)
                {
                    Console.WriteLine($"{currentPerson.Name} - {string.Join(", ",currentPerson.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} - Nothing bought");
                }
                
            }                    
        }
    }
    class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Bag { get; set; }

        public Person (string name,decimal money,List<string> products)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = products;
        }
    }
    class Product
    {
        public string  Name { get; set; }
        public decimal Cost { get; set; }

        public  Product (string name,decimal cost)
        {
            Name = name;
            Cost = cost;
        }                                 
    }
}
