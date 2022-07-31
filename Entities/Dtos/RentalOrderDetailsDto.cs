using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class RentalOrderDetailsDto : IDto
    {
        public int RentalOrderID { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }
    }
}
