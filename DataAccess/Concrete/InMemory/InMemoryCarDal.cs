using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
                new Car{Id=1,ColorId=1,BrandId=2,DailyPrice=250,ModelYear=new DateTime(2015,1,1), Description="HYUNDAI i10 - Black"},
                new Car{Id=2,ColorId=1,BrandId=2,DailyPrice=720,ModelYear=new DateTime(2020,1,1), Description="PORSCHE P911 Turbo S - Black"}
            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);

            cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int categoryId)
        {
            return cars.Where(c => c.Id == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
