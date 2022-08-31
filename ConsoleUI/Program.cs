using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

            
            //foreach (var car in carManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(car.BrandName);
            //}

            //foreach (var car in carManager.GetAllByBrandId(5))
            //{
            //    Console.WriteLine(car.BrandName);
            //}
        }
    }
}
 