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
            Zero whatIsAZero = new Zero()
            {
                MainColor = "white",
                MaximumOccupancy = "4",
                BatteryKWh = 4.5
            };

            mahTruck.Drive();
            myPlane.Drive();
            myElectricAutomobile.Drive();
            whatIsAZero.Drive();

            mahTruck.Turn("right");
            mahTruck.Stop();
            myPlane.Turn("left");
            myPlane.Stop();
            myElectricAutomobile.Turn("right");
            myElectricAutomobile.Stop();
            whatIsAZero.Turn("left");
            whatIsAZero.Stop();

        }
    }
}