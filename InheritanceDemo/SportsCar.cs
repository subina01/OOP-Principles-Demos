using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class SportsCar : Car//MultiLevel Inheritance
    {
        public int Speed { get; set; }

        public SportsCar(string company, string model, string color, int speed)
            : base(company, model, color)
        {
            Speed = speed;
        }

        public void DisplaySportsCarDetails()
        {
            DisplayCarDetails();
            Console.WriteLine($"Top Speed: {Speed} mph");
        }
    }
}
