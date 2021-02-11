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
            var CarDetails = carManager.GetCarDetails();

            if (CarDetails.isSucceded)
            {
                System.Console.WriteLine(CarDetails.Message + "\n");
                foreach (var car in CarDetails.Data)
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
}
