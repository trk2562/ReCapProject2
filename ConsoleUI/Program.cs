using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            RentalOrderTest();

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true )
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarYear + " model " + car.BrandName + " marka " + car.ColorName + " renkli bir " + car.Model);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalOrderTest()
        {
            RentalOrderManager rentalOrderManager = new RentalOrderManager(new EfRentalOrderDal());

            var result = rentalOrderManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentalOrderID + " No'lu " + rental.FullName + " isimli müşteri " + rental.RentStartDate + " tarihinde araç kiralamıştır. Araçın teslim tarihi: " + rental.RentEndDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
