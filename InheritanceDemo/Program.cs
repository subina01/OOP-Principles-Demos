
using InheritanceDemo;

namespace InhertanceDemo
{
    public class Program
        {
        public static void Main(string[] args)
        {
         Vehicle v = new Vehicle("SpaceX", "i10");
            Car c = new Car("Tesla", "123", "red");
            Truck t = new Truck("Tesla", "123", 1000);
            SportsCar sc = new SportsCar("Ferrari", "488", "blue", 211);

            v.DisplayInfo();
            v.StartEngine();
            v.Drive();
            v.Repair();
            Console.WriteLine();
           c.DisplayCarDetails();
            c.StartEngine();
            Console.WriteLine();
            t.DisplayTruckDetails();
            t.StartEngine();
            Console.WriteLine();
            sc.DisplaySportsCarDetails();
            sc.StartEngine();
        }

    }
}