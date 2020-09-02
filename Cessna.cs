using System;

namespace InheritanceVehicles
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over. Meeeeeuuuurrrhhhhhh!");
        }
    }
}