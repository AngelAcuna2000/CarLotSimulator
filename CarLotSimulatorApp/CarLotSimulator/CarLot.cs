using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (var car in ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} \n");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }
        }
    }
}