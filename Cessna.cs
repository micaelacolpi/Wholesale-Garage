using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzzzoooooommm!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle carefully turns right")
        }

    }
}
