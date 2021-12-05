using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //Console.WriteLine("---------------------");
            //BrandTest();
            //Console.WriteLine("---------------------");
            //ColorTest();
            //Console.WriteLine("---------------------");
            //CarDetailTest();
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetails in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", carDetails.BrandName, carDetails.Description, carDetails.ColorName, carDetails.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(1).Data.ColorName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
