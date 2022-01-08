using System;
using System.Collections.Generic;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] VehicleInfo = input.Split(' ');
                Vehicles vehicle = new Vehicles();
                vehicle.CarType = VehicleInfo[0];
                vehicle.Model = VehicleInfo[1];
                vehicle.Color = VehicleInfo[2];
                vehicle.Horsepower = Convert.ToDecimal(VehicleInfo[3]);
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }


            List<string> modelsToDisplay = new List<string>();
            string catalogInput = Console.ReadLine();
            while (catalogInput!="Close the Catalogue")
            {
                modelsToDisplay.Add(catalogInput);
                catalogInput = Console.ReadLine();
            }


            decimal carsHorsePower = 0;
            decimal trucksHorsePower = 0;
            List<Vehicles> cars = new List<Vehicles>();
            List<Vehicles> trucks = new List<Vehicles>();


            foreach (Vehicles vehicle in vehicles)
            {
                if (vehicle.CarType == "car")
                {
                    cars.Add(vehicle);
                    carsHorsePower += vehicle.Horsepower;
                }
                else if (vehicle.CarType == "truck")
                {
                    trucks.Add(vehicle);
                    trucksHorsePower += vehicle.Horsepower;
                }
            }

            decimal carAvHorsePower = 0;
            if (cars.Count>0)
            {
                carAvHorsePower = carsHorsePower / (decimal)cars.Count;
            }

            decimal truckAvHorsePower = 0;
            if (trucks.Count>0)
            {
                truckAvHorsePower = trucksHorsePower / (decimal)trucks.Count;
            }
            

            foreach (string model in modelsToDisplay)
            {
                foreach (Vehicles vehicle in vehicles)
                {
                    if (model == vehicle.Model && vehicle.CarType == "car")
                    {
                        Console.WriteLine($"Type: Car\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                    }
                }
            }

            foreach (string model in modelsToDisplay)
            {
                foreach (Vehicles vehicle in vehicles)
                {
                    if (model == vehicle.Model && vehicle.CarType == "truck")
                    {
                        Console.WriteLine($"Type: Truck\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                    }
                }
            }

            Console.WriteLine($"Cars have average horsepower of: {carAvHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvHorsePower:f2}.");
        }
    }
}
