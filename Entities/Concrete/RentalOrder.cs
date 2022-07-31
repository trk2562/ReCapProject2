using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RentalOrder : IEntity
    {
        public int RentalOrderID { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
    }
}
