using System;
using System.Collections.Generic;
using System.Text;

namespace military 
{
    class Tank : Vehicle
    {
        public Tank(int weight, int averageSpeed, int fuelConsumption = 30, int capacity = 6)
            : base (weight, averageSpeed, fuelConsumption, capacity)
        {
            
        }
    }
}
