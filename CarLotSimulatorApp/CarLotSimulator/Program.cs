using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car - DONE

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE

            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars - DONE

            
            //Object Initializer Syntax

            var car1 = new Car()
            {
                Year = 2023,

                Make = "Rolls Royce",

                Model = "Phantom",

                EngineNoise = "Engine Noise: Purr",

                HonkNoise = "Honk Noise: Boom",

                IsDriveable = true

            };


            carLot.ParkingLot.Add(car1);



            //Dot Notation

            var car2 = new Car();

            car2.Year = 2023;

            car2.Make = "Mercedes-Benz";

            car2.Model = "Maybach S-Class";

            car2.EngineNoise = "Engine Noise: Hum";

            car2.HonkNoise = "Honk Noise: Blare";

            car2.IsDriveable = true;


            carLot.ParkingLot.Add(car2);



            //Custom Constructor

            var car3 = new Car(2023, "Bentley", "Flying Spur", "Engine Noise: Growl", "Honk Noise: Bellow", true);


            carLot.ParkingLot.Add(car3);



            //Call each of the methods for each car - DONE



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.CheckCars();
        }
    }
}
