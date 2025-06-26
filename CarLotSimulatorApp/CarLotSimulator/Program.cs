using CarLotSimulator;
using System;
using System.Collections.Generic;



namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of CarLot
            var lot = new CarLot();

            // Create and add cars
            var car1 = new Car("Ford", "Mustang", 2020);
            var car2 = new Car("Tesla", "Model 3", 2022);
            var car3 = new Car("Toyota", "Corolla", 2018);

            lot.ParkingLot.Add(car1);
            lot.ParkingLot.Add(car2);
            lot.ParkingLot.Add(car3);

            // Print out each car’s details
            foreach (var car in lot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            // Display total number of cars
            Console.WriteLine($"Total number of cars created: {CarLot.numberOfCars}");
        }
    }
}
