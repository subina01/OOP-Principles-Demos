using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Truck : Vehicle//Hierarchial Inheritance
    {
        public double LoadCapacity { get; set; }
        public Truck(string company, string model, double loadCapacity)
        : base(company, model) 
        {
            LoadCapacity = loadCapacity;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started ....");
        }

        public void DisplayTruckDetails()
        {
            DisplayInfo();
            Console.WriteLine($"LoadCapacity = {LoadCapacity} tons");
        }
    }
}
