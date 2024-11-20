using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal interface Ivehicle
    {
        void Start(string vehicleType); 
        void Start(string vehicleType, int speed); 
        void FuelType(); 
    }
}
