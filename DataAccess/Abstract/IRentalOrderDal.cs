﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalOrderDal : IEntityRepository<RentalOrder>
    {
        List<RentalOrderDetailsDto> GetCarDetails();
    }
}
