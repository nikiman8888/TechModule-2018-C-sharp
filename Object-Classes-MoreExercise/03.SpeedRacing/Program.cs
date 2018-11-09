using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int count = int.Parse(Console.ReadLine());

            var carsData = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] currentCarData = Console.ReadLine().Split(' ');

                string model = currentCarData[0];

                double fuel = double.Parse(currentCarData[1]);

                double fuelPerKm = double.Parse(currentCarData[2]);

                var currentCar = new Car(model, fuel, fuelPerKm);

                carsData.Add(currentCar);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');

                string driveModel = tokens[1];

                double driveKm = double.Parse(tokens[2]);

                foreach (var car in carsData)
                {
                    if (car.Model == driveModel)
                    {
                        car.Drive(car, driveKm);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var car in carsData)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.Traveled}");
            }
        }
    }
    class Car
    {
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double FuelKm { get; set; }
        public double Traveled { get; set; }

        public Car(string model, double fuel, double fuelKm)
        {
            Model = model;
            Fuel = fuel;
            FuelKm = fuelKm;
            Traveled = 0;
        }

        public void Drive(Car currentCar, double km)
        {
            if (km * currentCar.FuelKm <= currentCar.Fuel)
            {
                currentCar.Fuel -= (km * currentCar.FuelKm);

                currentCar.Traveled += km; 
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
