﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
                _carDal.Add(car);
           
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _carDal.GetAll(p => p.BrandId == BrandId);
        }

        public List<Car> GetByColorId(int ColorId)
        {
            return _carDal.GetAll(p => p.ColorId == ColorId);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            bool IsCarValid = false;
            foreach (var _car in _carDal.GetAll())
            {
                if (_car.CarId == car.CarId) { IsCarValid = true; }
            }
            if (IsCarValid)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("No Valid Car");
            }
        }
    }
}