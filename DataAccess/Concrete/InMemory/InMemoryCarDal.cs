using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                //new Car{Id=1, BrandId=1,ColorId=1,DailyPrice=500000,ModelYear=2002,Description="2002 Model siyah Mazda Rx8"},
                //new Car{Id=1, BrandId=2,ColorId=1,DailyPrice=700000,ModelYear=2020,Description="2020 Model siyah Toyota Corolla"},
                //new Car{Id=1, BrandId=3,ColorId=2,DailyPrice=750000,ModelYear=2007,Description="2007 Model beyaz BMW X8"},
                //new Car{Id=1, BrandId=2,ColorId=2,DailyPrice=450000,ModelYear=2012,Description="2012 Model beyaz Toyota Corolla"},
                //new Car{Id=1, BrandId=3,ColorId=3,DailyPrice=50000,ModelYear=1997,Description="1997 Model mavi Tofaş Şahin"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarYear = car.CarYear;
        }
    }
}
