using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, BrandId=1, ModelYear=2010, DailyPrice=750, Description="BMW Car"},
                new Car {CarId=2, BrandId=2, ModelYear=2002, DailyPrice=150, Description="Mercedes Car"},
                new Car {CarId=3, BrandId=3, ModelYear=2013, DailyPrice=350, Description="Honda Car"},
                new Car {CarId=4, BrandId=4, ModelYear=2019, DailyPrice=1200, Description="Audi Car"},
                new Car {CarId=5, BrandId=1, ModelYear=2008, DailyPrice=500, Description="BMW Car"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletingCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(deletingCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public void Update(Car car)
        {
            Car updatingCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            updatingCar.BrandId = car.BrandId;
            updatingCar.DailyPrice = car.DailyPrice;
            updatingCar.Description = car.Description;
            updatingCar.ModelYear = car.ModelYear;
        }
    }
}
