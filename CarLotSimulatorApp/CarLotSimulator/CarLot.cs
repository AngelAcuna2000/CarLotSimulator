using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int _numberOfCars = 1;

        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (var car in ParkingLot)
            {
                car.CarType();
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Car.CurrentNumberOfCars();
            }
        }
    }
}