using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using static military.Functions;
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

        public virtual int CalculateFuelConsumption(int distance)
        {
            return (distance * FuelConsumption) / 100;
        }

        public virtual int SimulateTrip(Vehicle myVehicle, int numberOfSoldiers)
        {
            var distance = myVehicle.GetDistance();
            var numberOfTrips = CalculateNumberOfTrips(numberOfSoldiers, myVehicle.Capacity);
            Console.WriteLine("number of trips: " + numberOfTrips);
            var totalDistance = CalculateTotalDistance(numberOfTrips, distance);
            Console.WriteLine("total distance: " + totalDistance);
            var fuelConsumed = CalculateFuelConsumption(totalDistance);
            Console.WriteLine("Fuel consumed: " + fuelConsumed);
            Console.WriteLine();Console.WriteLine();
            return fuelConsumed;
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
        public virtual int GetDistance()
        {
            return 0;
        }
    }

}
