using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace military
{
    public abstract class Vehicle
    {
       
        protected Vehicle(int weight, int averageSpeed, int fuelConsumption, int capacity)
        {
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;
            Id = GenerateGuid();
        }

        public string Id { get; set; }
        public int Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        private static string GenerateGuid()
        {
            var guid = Guid.NewGuid().ToString();
            return guid;
        }

        public virtual void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Speed: " + AverageSpeed);
            Console.WriteLine("Fuel Consumption: " + FuelConsumption);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine();
        }
    }
}

/*Id,
Weight,
AverageSpeed,
FuelConsumption,
Capacity
id | težina | brzina | potrošnja | kapacitet | ukupno potrošeno gorivo
*/
