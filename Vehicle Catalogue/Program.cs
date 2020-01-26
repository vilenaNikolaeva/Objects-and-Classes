using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[4];

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input[0] != "End")
            {
                input = Console.ReadLine().Split().ToArray();


                if (input[0] == "End")
                {
                    break;
                }
                string typeVehicle = input[0];
                string model = input[1];
                string color = input[2];
                double power = double.Parse(input[3]);

                if (input[0] == "car")
                {
                    Car car = new Car();
                    {
                        car.TypeOfVehicle = typeVehicle;
                        car.Model = model;
                        car.Color = color;
                        car.HorsePower = power;
                    }
                    cars.Add(car);
                }
                else if (input[0] == "truck")
                {
                    Truck truck = new Truck();
                    {
                        truck.TypeOfVehicle = typeVehicle;
                        truck.Model = model;
                        truck.Color = color;
                        truck.HorsePower = power;
                    }
                    trucks.Add(truck);
                }
            }

            while (true)
            {
                string newModels = Console.ReadLine();
                if (newModels == "Close the Catalogue")
                {
                    break;

                }

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model.Contains(newModels))
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {cars[i].Model}");
                        Console.WriteLine($"Color: {cars[i].Color}");
                        Console.WriteLine($"Horsepower: {cars[i].HorsePower}");
                    }
                }

                for (int k = 0; k < trucks.Count; k++)
                {
                    if (trucks[k].Model.Contains(newModels))
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {trucks[k].Model}");
                        Console.WriteLine($"Color: {trucks[k].Color}");
                        Console.WriteLine($"Horsepower: {trucks[k].HorsePower}");
                    }
                }
            }
            int carsCount = 0;
            int truckCount = 0;
            double carsHoursePower = 0.0;
            double trucksHoursePower = 0.0;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].TypeOfVehicle == "car")
                {
                    carsCount++;
                    carsHoursePower += cars[i].HorsePower;
                }
            }

            for (int i = 0; i < trucks.Count; i++)
            {
                if (trucks[i].TypeOfVehicle == "truck")
                {
                    truckCount++;
                    trucksHoursePower += trucks[i].HorsePower;
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {((double)cars.Sum(x => x.HorsePower) / cars.Count):f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {((double)trucks.Sum(x => x.HorsePower) / trucks.Count):f2}.");

            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
}
