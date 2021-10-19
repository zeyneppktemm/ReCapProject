using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();

          

        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            List<Car> cars = new List<Car>()
            {
                new Car(){BrandId = 1, ColorId = 1, CarName = "Audi A3", ModelYear = new DateTime(2021), DailyPrice = 600000, Description="Sedan 35 Turbo FSI 150 hp Advanced S Tronic Otomatik"},
                new Car(){BrandId = 1, ColorId = 3, CarName = "Audi A3", ModelYear = new DateTime(2021), DailyPrice = 600000, Description="Sedan 35 Turbo FSI 150 hp Advanced S Tronic Otomatik"},
                new Car(){BrandId = 1, ColorId = 6, CarName = "Audi A3", ModelYear = new DateTime(2021), DailyPrice = 600000, Description="Sedan 35 Turbo FSI 150 hp Advanced S Tronic Otomatik"},
                new Car(){BrandId = 1, ColorId = 1, CarName = "Audi A6", ModelYear = new DateTime(2021), DailyPrice = 1490000, Description="Sedan 40 TDI quattro 204 hp Sport S Tronic Otomatik"},
                new Car(){BrandId = 2, ColorId = 2, CarName = "BMW 320i", ModelYear = new DateTime(2021), DailyPrice = 752000, Description="Sedan Sport Line Otomatik Benzin"},
                new Car(){BrandId = 2, ColorId = 6, CarName = "BMW 740Ld xDrive", ModelYear = new DateTime(2021), DailyPrice = 3778100, Description="Pure Excellence Otomatik Mild Hybrid"},
                new Car(){BrandId = 2, ColorId = 6, CarName = "BMW 740Ld xDrive", ModelYear = new DateTime(2021), DailyPrice = 3847300, Description="M Excellence Dizel"},
                new Car(){BrandId = 3, ColorId = 7, CarName = "Fiat Egea", ModelYear = new DateTime(2021), DailyPrice = 171900, Description="Easy 1.4 Fire 95 HP"},
                new Car(){BrandId = 3, ColorId = 5, CarName = "Fiat Egea", ModelYear = new DateTime(2021), DailyPrice = 237900, Description="Lounge 1.3 M.Jet 95 HP"},
                new Car(){BrandId = 3, ColorId = 6, CarName = "Fiat Egea", ModelYear = new DateTime(2021), DailyPrice = 250900, Description="Cross 1.4 Fire 95 HP MT"},
                new Car(){BrandId = 4, ColorId = 5, CarName = "Ford Focus", ModelYear = new DateTime(2021), DailyPrice = 253000, Description="Trend X - 1.5L Ti-VCT 123PS 6 Ileri Manuel Benzin"},
                new Car(){BrandId = 4, ColorId = 6, CarName = "Ford Focus", ModelYear = new DateTime(2021), DailyPrice = 370400, Description="Trend X 5 Kapı 1.5L EcoBlue 120PS 8 Ileri Otomatik Dizel"},
                new Car(){BrandId = 5, ColorId = 3, CarName = "Honda Civic", ModelYear = new DateTime(2021), DailyPrice = 374600, Description="Hatchback 1.5L VTEC Turbo Benzin Otomatik Sport+"},
                new Car(){BrandId = 5, ColorId = 1, CarName = "Honda CR-V", ModelYear = new DateTime(2021), DailyPrice = 576700, Description="1.5L VTEC Turbo Benzin Otomatik Executive+"},
                new Car(){BrandId = 6, ColorId = 6, CarName = "Hyundai i10", ModelYear = new DateTime(2021), DailyPrice = 176800, Description="1.2 MPI AMT Style Benzinli"},
                new Car(){BrandId = 6, ColorId = 1, CarName = "Hyundai Elentra", ModelYear = new DateTime(2021), DailyPrice = 326689, Description="1.6 MPI CVT Otomatik Smart Benzinli"},
                new Car(){BrandId = 7, ColorId = 3, CarName = "Kia Sportage", ModelYear = new DateTime(2021), DailyPrice = 439900, Description="1.6L 136 PS 4x2 DCT Otomatik Dizel"},
                new Car(){BrandId = 7, ColorId = 6, CarName = "Kia Sportage", ModelYear = new DateTime(2021), DailyPrice = 499900, Description="1.6L 136 PS 4x4 DCT Otomatik Dizel"},
                new Car(){BrandId = 8, ColorId = 7, CarName = "Opel Corsa", ModelYear = new DateTime(2014), DailyPrice = 68500, Description="1.2 75 HP Benzin MT5 ESSENTIAL"},
                new Car(){BrandId = 8, ColorId = 3, CarName = "Opel Astra", ModelYear = new DateTime(2021), DailyPrice = 338900, Description="1.4 145 HP Benzin CVT Edition"},
                new Car(){BrandId = 9, ColorId = 3, CarName = "Seat Ibiza", ModelYear = new DateTime(2019), DailyPrice = 136000, Description="1.0 EcoTSI 110 HP DSG Style"},
                new Car(){BrandId = 9, ColorId = 3, CarName = "Seat Ibiza", ModelYear = new DateTime(2021), DailyPrice = 239000, Description="1.0 EcoTSI 110 HP DSG Style"},
                new Car(){BrandId = 10, ColorId = 6, CarName = "Volkwagen Golf", ModelYear = new DateTime(2021), DailyPrice = 375189, Description="1.0 eTSI 110 PS Life DSG"},
                new Car(){BrandId = 10, ColorId = 2, CarName = "Volkwagen Tiguan", ModelYear = new DateTime(2021), DailyPrice = 533929, Description="1.5 TSI ACT 150 PS Elegance DSG"}
            };


            foreach (var car in cars)
            {
                carManager.Add(car);
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            List<Brand> brandList = new List<Brand>()
           {
               new Brand(){BrandName="Audi"},
               new Brand(){BrandName="BMW"},
               new Brand(){BrandName="Fiat"},
               new Brand(){BrandName="Ford"},
               new Brand(){BrandName="Honda"},
               new Brand(){BrandName="Hyundai"},
               new Brand(){BrandName="Kia"},
               new Brand(){BrandName="Opel"},
               new Brand(){BrandName="Seat"},
               new Brand(){BrandName="Volkswagen"}
           };

            foreach (var brand in brandList)
            {
                brandManager.Add(brand);
            }
        }

        private static void AddColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            List<Color> colorList = new List<Color>()
            {
                new Color() { ColorName = "Black" },
                new Color() { ColorName="Blue" },
                new Color() {  ColorName = "Grey" },
                new Color() { ColorName="Yellow" },
                new Color() { ColorName = "Red" },
                new Color() { ColorName="White" },
                new Color() { ColorName = "Brown" }
            };
            foreach (var color in colorList)
            {
                colorManager.Add(color);
            }
        }

        private static void CarTest()
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
