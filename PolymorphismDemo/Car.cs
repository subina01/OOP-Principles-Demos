using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Car : Ivehicle
    {
        public  void FuelType()
        {
            Console.WriteLine("Car uses petrol as fuel.");
        }

        public void Start(string vehicleType)
        {
            Console.WriteLine($"{vehicleType}");
        }

        public void Start(string vehicleType, int speed)
        {
            throw new NotImplementedException();
        }
    }
}
