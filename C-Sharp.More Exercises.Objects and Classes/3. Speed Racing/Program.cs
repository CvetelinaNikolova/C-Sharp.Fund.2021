using System;
using System.Collections.Generic;

namespace _3._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCar = int.Parse(Console.ReadLine());

            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < countOfCar; i++)
            {
                string[] CarInfo = Console.ReadLine().Split(' ');
                Car car = new Car();
                car.Model = CarInfo[0];
                car.FuelAmout = Convert.ToDecimal(CarInfo[1]);
                car.FuelConsumptionPerKm = Convert.ToDecimal(CarInfo[2]);
                car.TraveledDistance = 0;
                listOfCars.Add(car);
            }

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] driveModel = command.Split(' ');
                foreach (Car car in listOfCars)
                {
                    if (car.Model==driveModel[1])
                    {
                        car.DriveCar(car, Convert.ToDecimal(driveModel[2]));
                    }
                }
                command = Console.ReadLine();
            }

            foreach (Car car in listOfCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmout:f2} {car.TraveledDistance}");
            }
        }
    }
}
