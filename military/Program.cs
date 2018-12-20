using System;

namespace military
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Vehicle a = new Tank(1, 2);
            a.Print();
            Amfibia b = new Amfibia(5,6);
            b.Print();
            Warship c = new Warship(40,50);
            c.Print();
        }
    }
}
