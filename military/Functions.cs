using System;

namespace military
{
    public class Functions
    {
        public static int GetSoldiers()
        {
            Console.WriteLine("Enter the number of soldiers that need to be transported");
            var numberOfSoldiers = int.Parse(Console.ReadLine());
            return numberOfSoldiers;
        }

        public static int ChanceForObstacleToHappen(int distanceOrTime, int chance)
        {
            var rnd = new Random();
            var obstacleCount = 0;
            for (var i = 0; i < distanceOrTime; i++)
            {
                var chanceForObstacleToHappen = 0;
                chanceForObstacleToHappen = rnd.Next(0, 100);
                if (chanceForObstacleToHappen <= chance)
                    obstacleCount++;
            }
            return obstacleCount;
        }

        public static int CalculateNumberOfTrips(int numberOfSoldiers, int capacity)
        {
            if (capacity >= numberOfSoldiers)
                return 1;
            if(numberOfSoldiers > capacity && numberOfSoldiers % capacity == 0)
                return 2 * (numberOfSoldiers / capacity) - 1;
            return 2 * (numberOfSoldiers / capacity + 1) - 1;
        }

        public static int CalculateTotalDistance(int numberOfTrips, int distance)
        {
            return numberOfTrips * distance;
        }

        public static void OptimumVehicle(int fuelConsumptionTank, int fuelConsumptionAmfibia,
            int fuelConsumptionWarship)
        {
            var minimumConsumption = Math.Min(fuelConsumptionAmfibia, Math.Min(fuelConsumptionTank, fuelConsumptionWarship));

            if(minimumConsumption == fuelConsumptionAmfibia)
                Console.WriteLine("Optimum vehicle for transport is Amfibia");
   
            if(minimumConsumption == fuelConsumptionTank)
                Console.WriteLine("Optimum vehicle for transport is Tank");

            if(minimumConsumption == fuelConsumptionWarship)
                Console.WriteLine("Optimum vehicle for transport is Warship");
        }

        public static void Start()
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
