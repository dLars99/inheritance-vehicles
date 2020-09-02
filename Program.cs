using System;

namespace InheritanceVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram mahTruck = new Ram()
            {
                MainColor = "silver",
                MaximumOccupancy = "4",
                FuelCapacity = 24.5
            };
            Cessna myPlane = new Cessna()
            {
                MainColor = "red",
                MaximumOccupancy = "2",
                FuelCapacity = 15.0
            };
            Tesla myElectricAutomobile = new Tesla()
            {
                MainColor = "black",
                MaximumOccupancy = "4",
                BatteryKWh = 4.5
            };
        }
    }
}