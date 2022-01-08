using System;
using System.Collections.Generic;

namespace _7._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('/');
            Catalog cars = new Catalog();
            cars.Cars = new List<Car>();
            Catalog trucks = new Catalog();
            trucks.Trucks = new List<Truck>();
            while (input[0]!="end")
            {
                if (input[0]=="Car")
                {
                    Car car = new Car();
                    car.Brand = input[1];
                    car.Model = input[2];
                    car.HorsePower = Convert.ToDecimal(input[3]);
                    cars.Cars.Add(car);
                }
                else if (input[0]=="Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = input[1];
                    truck.Model = input[2];
                    truck.Weight = Convert.ToDecimal(input[3]);
                    trucks.Trucks.Add(truck);
                }
                input = Console.ReadLine().Split('/');
            }

            Car[] carArr = cars.Cars.ToArray();
            Truck[] truckArr = trucks.Trucks.ToArray();

            static int SortCarOrderByBrand(Car car1, Car car2)
            {
                return car1.Brand.CompareTo(car2.Brand);
            }

            static int SortTruckOrderByBrand(Truck truck1, Truck truck2)
            {
                return truck1.Brand.CompareTo(truck2.Brand);
            }

            Array.Sort(carArr, SortCarOrderByBrand);
            Array.Sort(truckArr, SortTruckOrderByBrand);

            if (cars.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (Car car in carArr)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            if (trucks.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach (Truck truck in truckArr)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

}
