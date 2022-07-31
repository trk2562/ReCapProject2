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
    public class EfRentalOrderDal : EfEntityRepositoryBase<RentalOrder, SofiaCarRentalContext>, IRentalOrderDal
    {
        public List<RentalOrderDetailsDto> GetCarDetails()
        {
            using (SofiaCarRentalContext context = new SofiaCarRentalContext())
            {
                var result = from p in context.RentalOrders
                             join c in context.Customers
                             on p.CustomerId equals c.CustomerId
                             join n in context.Users
                             on p.UserId equals n.UserId
                             select new RentalOrderDetailsDto
                             {
                                 RentalOrderID = p.RentalOrderID,
                                 CustomerId = c.CustomerId,
                                 FullName = c.FullName,
                                 UserId = n.UserId,
                                 RentEndDate = p.RentEndDate,
                                 RentStartDate = p.RentStartDate

                             };
                return result.ToList();
            }
        }
    }
}
