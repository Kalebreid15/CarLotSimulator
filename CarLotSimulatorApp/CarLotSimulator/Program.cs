using CarLotSimulator;
using System;
using System.Collections.Generic;

var carLot = new CarLot();

// Car 1 - Object Initializer  
Car car1 = new Car()
{
    Year = 2020,
    Make = "Toyota",
    Model = "Camry",
    EngineNoise = "Vroom Vroom",
    HonkNoise = "Beep Beep",
    IsDriveable = true
};
carLot.ParkingLot.Add(car1);
CarLot.NumberOfCars++;

// Car 2 - Object Initializer  
Car car2 = new Car()
{
    Year = 2018,
    Make = "Honda",
    Model = "Civic",
    EngineNoise = "Silent Buzz",
    HonkNoise = "Meep",
    IsDriveable = true
};
carLot.ParkingLot.Add(car2);
CarLot.NumberOfCars++;

// Car 3 - Object Initializer  
Car car3 = new Car()
{
    Year = 2021,
    Make = "Ford",
    Model = "Mustang",
    EngineNoise = "Clatter",
    HonkNoise = "Beep Beep",
    IsDriveable = true
};
carLot.ParkingLot.Add(car3);
CarLot.NumberOfCars++;

// Display car details and noises  
DisplayCarInfo(car1);
DisplayCarInfo(car2);
DisplayCarInfo(car3);

// Final Inventory Output  
Console.WriteLine("\n--- Full Car Lot Inventory ---");
foreach (var car in carLot.ParkingLot)
{
    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
}

Console.WriteLine($"\nTotal number of cars: {CarLot.NumberOfCars}");

void DisplayCarInfo(Car car)
{
    Console.WriteLine($"\nCar: {car.Year} {car.Make} {car.Model}");
    car.MakeEngineNoise(car.EngineNoise);
    car.MakeHonkNoise(car.HonkNoise);
}

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"The engine noise is: {noise}");
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"The honk noise is: {noise}");
        }
    }

    public class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();
        public static int NumberOfCars = 0;
    }
}
