using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SofiaCarRentalContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (SofiaCarRentalContext context = new SofiaCarRentalContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.BrandId
                             join n in context.Colors
                             on p.ColorId equals n.ColorId
                             select new CarDetailsDto
                             {
                                 CarId= p.CarId,
                                 BrandId=p.BrandId,
                                 ColorId = p.ColorId,
                                 ColorName = n.ColorName,
                                 Model = p.Model,
                                 BrandName = c.BrandName,
                                 CarYear = p.CarYear

                             };
                return result.ToList();
            }
        }
    }
      
}

