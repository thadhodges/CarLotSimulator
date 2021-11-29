using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
        public void Driveable(bool IsDriveable)
        {
            if (IsDriveable == true)
            {
                Console.WriteLine("The car is in working condition");
            }
            else
            {
                Console.WriteLine("The car is not in working codition");
            }
        }
        

    }
    //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    
}
