using System;
using static military.Functions;
namespace military
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new Tank(5000, 45);
            var amfibia = new Amfibia(2500, 65);
            var warship = new Warship(30000, 50);
            var soldiers = GetSoldiers();
            var fuelConsumptionTank = tank.SimulateTrip(tank, soldiers);
            var fuelConsumptionAmfibia = amfibia.SimulateTrip(amfibia, soldiers);
            var fuelConsumptionWarship = warship.SimulateTrip(warship, soldiers);
            OptimumVehicle(fuelConsumptionTank, fuelConsumptionAmfibia, fuelConsumptionWarship);
        }

        
    }
}
