namespace AbastractionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {

            Vehicle v = new Car("tata", "tesla", 1000,"red");
            v.DisplayInfo();
            decimal rentalCost = v.CalculateRentalCost(2);
            Console.WriteLine($"Rental cost for 2 days: {rentalCost}");
        }  
    }
}
