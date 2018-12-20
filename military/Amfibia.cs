using System;
using System.Collections.Generic;
using System.Text;

namespace military
{
    class Amfibia : Vehicle
    {
        public Amfibia(int weight, int averageSpeed, int fuelConsumption = 70, int capacity = 20)
            : base(weight, averageSpeed, fuelConsumption, capacity)
        {
            
        }
    }
}
