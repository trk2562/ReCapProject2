using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalOrderManager : IRentalOrderService
    {
        IRentalOrderDal _rentalOrderdal;

        public RentalOrderManager(IRentalOrderDal rentalOrderdal)
        {
            _rentalOrderdal = rentalOrderdal;
        }

        public IResult Add(RentalOrder rentalOrder)
        {
            _rentalOrderdal.Add(rentalOrder);
            return new SuccessResult(Messages.RentalOrderAdded);

        }

        public IResult Delete(RentalOrder rentalOrder)
        {
            _rentalOrderdal.Delete(rentalOrder);
            return new SuccessResult(Messages.RentalOrderDeleted);
        }
        

        public IDataResult<List<RentalOrder>> GetAll()
        {
            return new SuccessDataResult<List<RentalOrder>>(_rentalOrderdal.GetAll(), Messages.RentalOrderListed);

        }

        public IDataResult<List<RentalOrderDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentalOrderDetailsDto>>(_rentalOrderdal.GetCarDetails());
        }

        public IResult Update(RentalOrder rentalOrder)
        {
            bool IsCarValid = false;
            foreach (var _rentalOrder in _rentalOrderdal.GetAll())
            {
                if (_rentalOrder.RentEndDate == null) { IsCarValid = true; }
            }
            if (IsCarValid)
            {
                _rentalOrderdal.Update(rentalOrder);
                return new SuccessResult(Messages.RentalOrderVaild);
            }
            else
            {
                return new ErrorResult(Messages.RentalOrderInvaild);
            }
        }
    }
}
