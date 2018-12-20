using System;
using System.Collections.Generic;
using System.Text;

namespace military
{
    class Warship : Vehicle
    {
        public Warship(int weight, int averageSpeed, int fuelConsumption = 200, int capacity = 50)
            : base(weight, averageSpeed, fuelConsumption, capacity)
        {
            
        }
    }
}
