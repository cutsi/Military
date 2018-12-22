using System;
using System.Collections.Generic;
using System.Text;

namespace military 
{
    public class Tank : Vehicle, IDriveable
    {
        public Tank(int weight, int averageSpeed, int fuelConsumption = 30, int capacity = 6)
            : base (weight, averageSpeed, fuelConsumption, capacity) {}

        public int Move(int distance)
        {
            var obstacleCount = 0;
            var rnd = new Random();
            for (var i = 0; i < distance / 10; i++)
            {
                var chanceForObstacleToHappen = 0; // resharper mi je reka da ga ubacim u scope for-a iako mi je to malo cudno da ga definiram za svaku iteraciju
                chanceForObstacleToHappen = rnd.Next(0, 100);
                if(chanceForObstacleToHappen <= 30)
                    obstacleCount++;
            }

            distance += obstacleCount * 5;
            return distance;
        }

        public override int GetDistance()
        {
            Console.WriteLine("Enter the distance for Tank");
            var tankDistance = int.Parse(Console.ReadLine());
            tankDistance = Move(tankDistance);

            Console.WriteLine("Tank distance: " + tankDistance);
            Console.WriteLine();

            return tankDistance;
        }
    }
}
