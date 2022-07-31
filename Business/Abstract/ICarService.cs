using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<List<Car>> GetByBrandId(int BrandId);
        IDataResult<List<Car>> GetByColorId(int ColorId);
        IDataResult<List<Car>> GetAll();
    }
}
