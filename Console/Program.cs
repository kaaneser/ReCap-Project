using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCars();
        }

        private static void ListCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine("----------------");
                System.Console.WriteLine("Car ID: " + car.CarId);
                System.Console.WriteLine("Car Name: " + car.CarName);
                System.Console.WriteLine("Brand: " + car.ColorName);
                System.Console.WriteLine("Color: " + car.BrandName);
                System.Console.WriteLine("Daily Price: " + car.DailyPrice);
            }
            System.Console.WriteLine("----------------\n");
        }
    }
}
