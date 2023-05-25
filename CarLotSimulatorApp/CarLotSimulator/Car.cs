using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
       
        //Default Constructor
        public Car()
        {
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) : base()
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            CarLot._numberOfCars++;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void CarType()
        {
            Console.WriteLine($"{Year} {Make} {Model} \n");
        }
        
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{EngineNoise} \n");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{HonkNoise} \n \n");
        }

        public static void CurrentNumberOfCars()
        {
            Console.WriteLine($"Current Number of Cars: {CarLot._numberOfCars}\n\n");
            CarLot._numberOfCars++;
        }

    }
}
