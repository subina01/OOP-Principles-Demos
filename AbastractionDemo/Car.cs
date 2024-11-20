using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractionDemo
{
    public class Car : Vehicle
    {
        public string color { get; set; }
        public Car(string? model, string? name, decimal rentalPricePerDay, string color) : base(model, name, rentalPricePerDay)
        {
            this.color = color;
        }

        public override decimal CalculateRentalCost(int day)
        {
            return RentalPricePerDay * day;
        }

    }
}
