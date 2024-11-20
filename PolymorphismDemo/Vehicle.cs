using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Vehicle
    {
       
        public void Start(string vehicleType)
        {
            Console.WriteLine($"{vehicleType} is starting.");
        }

        public void Start(string vehicleType, int speed) // Overloaded method to start vehicle with different  no of parameters
        {
            Console.WriteLine($"{vehicleType} is starting with speed {speed}");
        }

        
        public virtual void FuelType()// Runtime polymorphism(Method Overriding)
        {
            Console.WriteLine("Vehicle may use any type of fuel");
        }
    }
}
