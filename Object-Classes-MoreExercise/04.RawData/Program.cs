using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var saveData = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] current = Console.ReadLine().Split(' ');

                string model = current[0];

                int engineSpeed = int.Parse(current[1]);

                int enginePower = int.Parse(current[2]);

                int cargoWeight = int.Parse(current[3]);

                string cartgoType = current[4];

                var currentEngine = new Engine(engineSpeed, enginePower);

                var currentCargo = new Cargo(cargoWeight, cartgoType);

                var currentCar = new Car(model, currentEngine, currentCargo);

                saveData.Add(currentCar);

            }
            string searched = Console.ReadLine();

            foreach (var car in saveData)
            {
                if (searched == "fragile")
                {
                    if (car.Cargoes.Weight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else
                {
                    if (car.Engines.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

        }
    }
    class Car
    {
        public string Model { get; set; }
        public Engine Engines { get; set; }
        public Cargo  Cargoes { get; set; }

        public  Car (string model, Engine engine, Cargo cargoes)
        {
            Model = model;
            Engines = engine;
            Cargoes = cargoes;
        }
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public  Engine(int speed,int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int weight,string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
