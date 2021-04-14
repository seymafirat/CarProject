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
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Console.WriteLine("DELETED SUCCESSFULL");
            //colorManager.Delete(new Color { ColorId = 1007 });
            //colorManager.Add(new Color { ColorName = "white" });
            //colorManager.Add(new Color { ColorName = "black" });
            //colorManager.Add(new Color { ColorName = "red" });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "-" + color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { CarName = "BMW Araba", BrandId = 1, ColorId = 1, ModelYear = "2010", DailyPrice=1500, Description = "Temizdir", });
            //carManager.Add(new Car { CarName = "Ford Araba", BrandId = 2, ColorId = 2, ModelYear = "1990", DailyPrice = 500, Description = "2.eldir.Kiralayabilirsiniz", });
            //carManager.Add(new Car { CarName = "Mercedes Araba", BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 2500, Description = "Aile için kullanıma uygun", });
            Console.WriteLine("All CARS------------");

            /*foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }*/
            /*Console.WriteLine("Brand 1 CARS------------");
            foreach (var car in carManager.GetCarsBrandId(1))
            {
                Console.WriteLine(car.BrandId + " - " + car.CarName);

            }
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ColorId + "-" + car.CarName);
            }*/
            Console.WriteLine("JOIN ISLEMI:");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "-" + car.CarName + "-" + car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
            }
            //carManager.Delete();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("ADDING SUCCESSFULL");
            brandManager.Add(new Brand { BrandName = "Nissan" });
            brandManager.Add(new Brand { BrandName = "Porsche" });
            brandManager.Add(new Brand { BrandName = "Tofaş" });
            Console.WriteLine("ALL BRANDS");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("BRANDS ACCORDING TO BRAND ID:");
            foreach (var brand in brandManager.GetBrandById(1))
            {
                Console.WriteLine(brand.BrandId + "-" + brand.BrandName);
            }
            brandManager.Delete(new Brand { BrandId = 3 });
            Console.WriteLine("DELETED SUCCESSFULL");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
