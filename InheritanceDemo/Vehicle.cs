using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Vehicle //Main Parent Class
    {
        public string Company {  get; set; }
        public string Model { get; set; }   
        
        public Vehicle (string company, string model)
        {
            Company = company; 
            Model = model;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"companyName: {Company} Model: {Model}");
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started.");
        }
    }


}
