using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            _cars = new List<Car> {

                new Car{CarId=1,BrandId=2,ColorId=1,ModelYear="2020",DailyPrice=700,Descriptions="abcdef"},
                new Car{CarId=2,BrandId=3,ColorId=2,ModelYear="2010",DailyPrice=450,Descriptions="abcdef"},
                new Car{CarId=3,BrandId=4,ColorId=1,ModelYear="2015",DailyPrice=650,Descriptions="abcdef"},
                new Car{CarId=4,BrandId=5,ColorId=3,ModelYear="2008",DailyPrice=400,Descriptions="abcdef"},
                new Car{CarId=5,BrandId=6,ColorId=2,ModelYear="2016",DailyPrice=680,Descriptions="abcdef"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDerails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Descriptions = car.Descriptions;
        }
    }
}
