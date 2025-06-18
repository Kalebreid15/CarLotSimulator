using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        // Constructor to increment the static numberOfCars field in CarLot  
        public Car()
        {
            CarLot.numberOfCars++;
        }
    }
    public class CarLot
    {
        // Static field to track the number of cars  
        public static int numberOfCars = 0;

        // Property to hold a list of cars in the parking lot  
        public List<Car> ParkingLot { get; set; } = new List<Car>();
    }
}
