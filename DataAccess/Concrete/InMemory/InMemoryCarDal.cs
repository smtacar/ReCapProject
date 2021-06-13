using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car {Id=1, BrandId=1, ColorId=4, DailyPrice=250, Description="SUV", ModelYear=2011},
                new Car {Id=2, BrandId=3, ColorId=2, DailyPrice=300, Description="Sedan", ModelYear=2017},
                new Car {Id=3, BrandId=2, ColorId=1, DailyPrice=200, Description="Hatchback", ModelYear=2010},
                new Car {Id=4, BrandId=4, ColorId=1, DailyPrice=150, Description="Sedan", ModelYear=2008},
                new Car {Id=5, BrandId=1, ColorId=3, DailyPrice=450, Description="SUV", ModelYear=2019},
                new Car {Id=6, BrandId=2, ColorId=4, DailyPrice=800, Description="Spor", ModelYear=2020},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
