using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
