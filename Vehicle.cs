using System;

namespace InheritanceVehicles
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }

    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public class Cessna : Vehicle // Propellor light aircraft
        {
            public double FuelCapacity { get; set; }
            public void RefuelTank()
            {
                // method definition omitted
            }
        }

        public class Ram : Vehicle // Gas powered truck
        {
            public double FuelCapacity { get; set; }

            public void RefuelTank()
            {
                // method definition omitted
            }
        }
    }
}