using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Car :Vehicle
    {
        public override void FuelType()
        {
            Console.WriteLine("Car uses petrol as fuel.");
        }
    }
}
