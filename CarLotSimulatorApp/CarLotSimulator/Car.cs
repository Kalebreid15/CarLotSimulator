using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        // Properties for the car
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor to increment number of cars in the lot
        public Car()
        {
            CarLot.numberOfCars++;
        }

        // Optional: Add constructor overload to set properties
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}

