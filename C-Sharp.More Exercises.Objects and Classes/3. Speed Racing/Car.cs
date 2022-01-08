using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public decimal FuelAmout { get; set; }
        public decimal FuelConsumptionPerKm { get; set; }
        public decimal TraveledDistance { get; set; }
        public void DriveCar(Car car,decimal amountOfKm)
        {
            if (car.FuelAmout<amountOfKm*FuelConsumptionPerKm)
            {
                Console.WriteLine("Insufficient fuel for the drive") ;
            }
            else if (car.FuelAmout>=FuelConsumptionPerKm*amountOfKm)
            {
                car.FuelAmout -= FuelConsumptionPerKm * amountOfKm;
                car.TraveledDistance += amountOfKm;
            }
        }
    }
}
