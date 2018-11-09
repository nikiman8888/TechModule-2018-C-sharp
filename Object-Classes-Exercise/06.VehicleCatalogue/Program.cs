using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string input = Console.ReadLine();

            var vehicles = new List<Vehicle>();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');

                string type = tokens[0];

                string firstType = type.Substring(0, 1).ToUpper();

                firstType += type.Substring(1);

                string model = tokens[1];

                string color = tokens[2];

                double horsePower = double.Parse(tokens[3]);

                var currentVehicle = new Vehicle(firstType, model, color, horsePower);

                vehicles.Add(currentVehicle);

                input = Console.ReadLine();
            }

            string informationFor = Console.ReadLine();

            while (informationFor != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == informationFor)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }

                informationFor = Console.ReadLine();
            }
            double carsSum = 0;
            double trucksSum = 0;

            foreach (var currentVehicle in vehicles)
            {
                if (currentVehicle.Type == "Car")
                {
                    carsSum += currentVehicle.HorsePower;
                }
                else
                {
                    trucksSum += currentVehicle.HorsePower;
                }
            }
            int countCar = vehicles.Where(x => x.Type == "Car").Count();
            int countCTruck = vehicles.Where(x => x.Type == "Truck").Count();

            if (countCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsSum / countCar:F2}.");
            }
            else if (countCar == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (countCTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksSum / countCTruck:F2}.");
            }
            else if (countCTruck == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }


        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
