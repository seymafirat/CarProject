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
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { DailyPrice = 500, Description = "Ford", ModelYear = "2010", BrandId = 5, ColorId = 1 });
            Console.WriteLine("All CARS------------");
          
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("Brand 1 CARS------------");
            foreach (var car in carManager.GetCarsBrandId(1))
            {
                Console.WriteLine(car.BrandId + " - " + car.Description);

            }
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ColorId + "-" + car.Description);
            }
            //carManager.Delete();

        }
    }
}
