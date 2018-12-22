using System;
using System.Collections.Generic;
using System.Text;
using static military.Functions;
namespace military
{
    public class Amfibia : Vehicle, IDriveable, ISwimmable
    {
        public Amfibia(int weight, int averageSpeed, int fuelConsumption = 70, int capacity = 20)
            : base(weight, averageSpeed, fuelConsumption, capacity) {}

        public int Move(int distance)
        {
            var obstacleCount = 0;
            obstacleCount = ChanceForObstacleToHappen(distance/10, 30);
            Console.WriteLine("distance "+distance);
            distance += obstacleCount * 5;
            return distance;
        }

        public int Swim(int distance)
        {
            var time = (distance  / AverageSpeed) * 6; //mnozim sa 6 jer ocu da dobijem u desetinama sata 
            var obstacleCount = 0;
            obstacleCount = ChanceForObstacleToHappen(time, 50);
            distance += obstacleCount * 3;
            return distance;
            
        }
        public override int GetDistance()
        {
            Console.WriteLine("Enter the land distance for Amfibia");
            var amfibiaLandDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the water distance for Amfibia");
            var amfibiaWaterDistance = int.Parse(Console.ReadLine());
            
            amfibiaLandDistance = Move(amfibiaLandDistance);
            amfibiaWaterDistance = Swim(amfibiaWaterDistance);

            Console.WriteLine("Amfibia distance: " + (amfibiaWaterDistance + amfibiaLandDistance));
            Console.WriteLine();
            return amfibiaWaterDistance + amfibiaLandDistance;
        }
    }
}
