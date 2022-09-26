using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }

            Console.WriteLine(brandManager.GetById(2).BrandName);
        }

        private static void Cartest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var item in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(item.CarId + "=>" + item.BrandName + "=>" + item.ColorName + "=>" + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //Console.WriteLine(carManager.GetCarDetails());
        }
    }
}
