using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            //İş kodları
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            //İş kodları
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            //İş kodları
            return _carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            //İş kodları
            _carDal.Update(car);
        }
    }
}
