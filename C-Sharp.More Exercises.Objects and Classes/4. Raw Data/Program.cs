using System;
using System.Collections.Generic;

namespace _4._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ');
                Car car = new Car();
                car.Model = carInfo[0];
                car.CarEngine.EngineSpeed = Convert.ToDecimal(carInfo[1]);
                car.CarEngine.EnginePower = Convert.ToDecimal(carInfo[2]);
                car.CarCargo.CargoWeight = Convert.ToDecimal(carInfo[3]);
                car.CarCargo.CargoType = carInfo[4];
                listOfCars.Add(car);
            }
            string command = Console.ReadLine();

            List<Car> ListOfCarsToPrint = new List<Car>();

            if (command=="fragile")
            {
                foreach (Car car in listOfCars)
                {
                    if (car.CarCargo.CargoType==command)
                    {
                        if (car.CarCargo.CargoWeight<1000)
                        {
                            ListOfCarsToPrint.Add(car);
                        }
                    }
                }
            }
            else if (command=="flamable")
            {
                foreach (Car car in listOfCars)
                {
                    if (car.CarCargo.CargoType==command)
                    {
                        if (car.CarEngine.EnginePower>250)
                        {
                            ListOfCarsToPrint.Add(car);
                        }
                    }
                }
            }

            foreach (Car car in ListOfCarsToPrint)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}

