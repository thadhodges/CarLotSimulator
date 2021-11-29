using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var car1 = new Car();
            lot.CarList.Add(car1);
            car1.Year = 2015;
            car1.Make = "Toyota";
            car1.Model = "Sienna";
            car1.EngineNoise = "bing-bang-boom";
            car1.HonkNoise = "beep-beep-woo";
            car1.IsDriveable = true;

            var car2 = new Car { Year = 2015, Model = "Sante Fe", Make = "Hundai", EngineNoise = "bang-bang-click", HonkNoise = "honk-beep-woo", IsDriveable = true };
            lot.CarList.Add(car2);
            //var car2 = new Car();
            //car2.Year = 2010;
            //car2.Make = "Hundai";
            //car2.Model = "Sante Fe";
            //car2.EngineNoise = "bang-bang-click";
            //car2.HonkNoise = "honk-beep-woo";
            //car2.IsDriveable = false;

            var car3 = new Car();
            lot.CarList.Add(car3);
            car3.Year = 1998;
            car3.Make = "Ford";
            car3.Model = "Taurus";
            car3.EngineNoise = "bang-bang-click";
            car3.HonkNoise = "honk-beep-honk";
            car3.IsDriveable = true;

            var listOfCars = new List<Car>();
            listOfCars.Add(car1);
            listOfCars.Add(car2);
            listOfCars.Add(car3);
            foreach (var item in listOfCars)
            {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine($" {item.Year}  {item.Make} {item.Model}");
                Console.WriteLine($"The engine sound is");
                item.MakeEngineNoise(item.EngineNoise);
                Console.WriteLine($"The horn sound is:");
                item.MakeHonkNoise(item.HonkNoise);
                Console.WriteLine($"Running condition of the {item.Make}: ");
                item.Driveable(item.IsDriveable);
                Console.WriteLine("*********************************************");
            }

            Console.WriteLine("9999999999999999999999999999999999999999999999999999");
            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"{car.Make}");
            }

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
}
