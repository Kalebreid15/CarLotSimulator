using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car 1
            Car car1 = new Car();
            car1.Year = 2020;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            //Car 2
            Car car2 = new Car();
            car2.Year = 2018;
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "Silent Buzz";
            car2.HonkNoise = "Meep";
            car2.IsDriveable = true;

            //Car 3
            Car car3 = new Car();
            car3.Year = 2021;
            car3.Make = "Ford";
            car3.Model = "Mustang";
            car3.EngineNoise = "Clatter";
            car3.HonkNoise = "Beep Beep";
            car3.IsDriveable = true;


            // Call method for each car 

            Console.WriteLine($"Car 1: {car1.Year} {car1.Make} {car1.Model}");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            Console.WriteLine($"\nCar 2: {car2.Year} {car2.Make} {car2.Model}");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            Console.WriteLine($"\nCar 3: {car3.Year} {car3.Make} {car3.Model}");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            //TODO
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable 
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
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
}
// CarLot class to hold a list of cars
