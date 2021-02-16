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
            //ListCarDetails();
            //ListUserDetails();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Update(new Rental { Id = 2, ReturnDate = new DateTime(2021, 02, 15, 12, 12, 12) });
            System.Console.WriteLine(result.Message);
        }

        private static void ListUserDetails()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var UserDetails = userManager.GetAll();

            if (UserDetails.isSucceded)
            {
                foreach (var user in UserDetails.Data)
                {
                    System.Console.WriteLine("First Name: " + user.FirstName);
                    System.Console.WriteLine("Last Name: " + user.LastName);
                    System.Console.WriteLine("Mail: " + user.Mail);
                }
            }
        }

        private static void ListCarDetails()
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
