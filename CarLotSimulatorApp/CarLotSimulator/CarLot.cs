using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CarLotSimulator
{
    public class CarLot
    {
        // Static field to track the number of Car instances created
        public static int numberOfCars = 0;

        // A list to store the cars in the lot
        public List<Car> ParkingLot { get; set; } = new List<Car>();
    }
}
