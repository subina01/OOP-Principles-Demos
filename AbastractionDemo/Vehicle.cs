using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractionDemo
{
    public abstract class Vehicle
    {
        public string? Model;
        public string? Name;

        public decimal RentalPricePerDay;

        public Vehicle(string? model, string? name, decimal rentalPricePerDay)
        {
            Model = model;
            Name = name;
            RentalPricePerDay = rentalPricePerDay;
        }

        public abstract decimal CalculateRentalCost(int day);

       
        public void DisplayInfo()
        {
            Console.WriteLine($"Model = {Model} Name = {Name} Price per day= {RentalPricePerDay}");
        }
    }
}
