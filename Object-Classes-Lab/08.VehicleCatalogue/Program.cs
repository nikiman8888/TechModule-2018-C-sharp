using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var cars = new List<Car>();

            var trucks = new List<Trucks>();

            while (input != "end") 
            {
                string[] tokens = input.Split('/');

                string type = tokens[0];

                string brand = tokens[1];

                string model = tokens[2];

                switch (type)
                {
                    case "Car":

                        string hp = tokens[3];

                        var currentCar = new Car(type, brand, model, hp);

                        cars.Add(currentCar);

                        break;
                    case "Truck":
                        string weight = tokens[3];

                        var currentTrucks = new Trucks(type,brand, model, weight);

                        trucks.Add(currentTrucks);
                        break;
                }


                input = Console.ReadLine();
            }
            var catagalog = new CatalogueVehicle(cars, trucks);
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (var vehicle in catagalog.Cars.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach (var vehicle in catagalog.Trucks.OrderBy(X=>X.Brand))
            {
                Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.Weight}kg");
            }
        }
    }
    class Trucks
    {
        public string Type { get; set; }
        public string  Brand { get; set; }
        public string  Model { get; set; }
        public string Weight { get; set; }

        public Trucks (string type, string brand, string model, string weight)
        {
            this.Type = type;
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }
    class Car
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

        public Car(string type, string brand, string model, string horsePower)
        {
            this.Type = type;
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
    }
    class CatalogueVehicle
    {
        public List<Car> Cars { get; set; }
        public List<Trucks> Trucks { get; set; }

        public CatalogueVehicle(List<Car> car,List<Trucks> truck)
        {
            this.Cars = car;
            this.Trucks = truck;
        }

    }
}
