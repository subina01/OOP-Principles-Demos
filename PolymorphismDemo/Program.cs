﻿namespace PolymorphismDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Start("truck");
            v.Start("car", 60);
            Vehicle c = new Car();
            c.FuelType();

        }
    }
}