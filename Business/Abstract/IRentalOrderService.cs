using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalOrderService
    {
        IResult Add(RentalOrder rentalOrder);
        IResult Update(RentalOrder rentalOrder);
        IResult Delete(RentalOrder rentalOrder);
        IDataResult<List<RentalOrder>> GetAll();
        IDataResult<List<RentalOrderDetailsDto>> GetCarDetails();
    }
}
