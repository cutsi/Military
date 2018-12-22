using System;
using System.Collections.Generic;
using System.Text;

namespace military
{
    public class Warship : Vehicle, ISwimmable
    {
        public Warship(int weight, int averageSpeed, int fuelConsumption = 200, int capacity = 50)
            : base(weight, averageSpeed, fuelConsumption, capacity) {}

        public int Swim(int distance)
        {
            var time = (distance / AverageSpeed) * 6; 
            var obstacleCount = 0;
            var rnd = new Random();
            for (var i = 0; i < time; i++)
            {
                var chanceForObstacleToHappen = 0;
                chanceForObstacleToHappen = rnd.Next(0, 100);
                if (chanceForObstacleToHappen <= 50)
                    obstacleCount++;
            }

            distance += obstacleCount * 3;
            return distance;

        }
        public override int GetDistance()
        {
            Console.WriteLine("Enter the distance for  War ship");
            var warshipDistance = int.Parse(Console.ReadLine());

            Swim(warshipDistance);

            Console.WriteLine("warship distance: " + warshipDistance);
            Console.WriteLine();

            return warshipDistance;
        }
    }
}
