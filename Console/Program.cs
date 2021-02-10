using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            CarManager carManager = new CarManager(new EfCarDal());

            while (loop)
            {
                System.Console.WriteLine("1. List Cars \t 2. Add a Car \t 3. Delete a Car \t 4. Update a Car \t 5. Exit");
                System.Console.WriteLine("Insert a choice: ");
                int menu_choice = Convert.ToInt32(System.Console.ReadLine());
                switch (menu_choice)
                {
                    case 1: // List the Cars
                        System.Console.WriteLine("1. List all Cars \t 2. List by Brand \t 3. List by Color");
                        System.Console.WriteLine("Insert a choice: ");
                        int list_choice = Convert.ToInt32(System.Console.ReadLine());
                        if (list_choice == 1)
                        {
                            foreach (var car in carManager.GetAll()) // Executes the CarManager's method
                            {
                                System.Console.WriteLine("-- Car --");
                                System.Console.WriteLine(car.CarId);
                                System.Console.WriteLine(car.BrandId);
                                System.Console.WriteLine(car.CarName);
                                System.Console.WriteLine(car.ModelYear);
                                System.Console.WriteLine(car.DailyPrice);
                                System.Console.WriteLine(car.Description);
                                System.Console.WriteLine("---------\n");
                            }
                        }
                        else if (list_choice == 2)
                        {
                            System.Console.WriteLine("Brand Id:");
                            int brandId = Convert.ToInt32(System.Console.ReadLine());
                            foreach (var car in carManager.GetCarsByBrandId(brandId)) // Executes the CarManager's method
                            {
                                System.Console.WriteLine("-- Car --");
                                System.Console.WriteLine(car.CarId);
                                System.Console.WriteLine(car.BrandId);
                                System.Console.WriteLine(car.CarName);
                                System.Console.WriteLine(car.ModelYear);
                                System.Console.WriteLine(car.DailyPrice);
                                System.Console.WriteLine(car.Description);
                                System.Console.WriteLine("---------\n");
                            }
                        }
                        else if (list_choice == 3)
                        {
                            System.Console.WriteLine("Color Id:");
                            int colorId = Convert.ToInt32(System.Console.ReadLine());
                            foreach (var car in carManager.GetCarsByColorId(colorId)) // Executes the CarManager's method
                            {
                                System.Console.WriteLine("-- Car --");
                                System.Console.WriteLine(car.CarId);
                                System.Console.WriteLine(car.BrandId);
                                System.Console.WriteLine(car.ColorId);
                                System.Console.WriteLine(car.CarName);
                                System.Console.WriteLine(car.ModelYear);
                                System.Console.WriteLine(car.DailyPrice);
                                System.Console.WriteLine(car.Description);
                                System.Console.WriteLine("---------\n");
                            }
                        }
                        else
                            System.Console.WriteLine("Inserted wrong number!\n");
                        break;
                    case 2:
                        System.Console.WriteLine("Insert a brand Id: ");
                        int bId = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Color Id: ");
                        int cId = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Car Name: ");
                        string carName = System.Console.ReadLine();
                        System.Console.WriteLine("Model Year: ");
                        int modelYear = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.WriteLine("Daily Price: ");
                        decimal price = Convert.ToDecimal(System.Console.ReadLine());
                        System.Console.WriteLine("Description: ");
                        string desc = System.Console.ReadLine();
                        Car newCar = new Car { BrandId = bId, ColorId = cId, CarName = carName, ModelYear = modelYear, DailyPrice = price, Description = desc, };
                        carManager.Add(newCar);
                        break;
                    case 3: // Delete from the Db
                        break;
                    case 4: // Update from the Db
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        System.Console.WriteLine("You inserted wrong number!\n");
                        break;
                }
            }
        }
    }
}
