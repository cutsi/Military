using System;
using System.Collections.Generic;
using System.Text;

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
            if (capacity > numberOfSoldiers)
                return 1;
            return 2 * (numberOfSoldiers / capacity) - 1;
        }

        public static int CalculateTotalDistance(int numberOfTrips, int distance)
        {
            return numberOfTrips * distance;
        }

        public static void OptimumVehicle(int fuelConsumptionTank, int fuelConsumptionAmfibia,
            int fuelConsumptionWarship)
        {
            if (fuelConsumptionWarship < fuelConsumptionAmfibia && fuelConsumptionWarship < fuelConsumptionTank)
                Console.WriteLine("Optimum vehicle for transport is Warship");

            if (fuelConsumptionAmfibia < fuelConsumptionWarship && fuelConsumptionAmfibia < fuelConsumptionTank)
                Console.WriteLine("Optimum vehicle for transport is Amfibia");

            if (fuelConsumptionTank < fuelConsumptionWarship && fuelConsumptionTank < fuelConsumptionAmfibia)
                Console.WriteLine("Optimum vehicle for transport is Tank");
        }
    }
}
