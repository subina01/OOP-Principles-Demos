using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Car : Vehicle //When its just car single  Inheritance
    {
        public string Color;
        public Car(string company, string model, string color) : base(company, model)
        {
            Color = color;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started ...");
        }
        public void DisplayCarDetails()
        {
            DisplayInfo();
            Console.WriteLine($"color of car is = {Color}");
        }
    }
}
