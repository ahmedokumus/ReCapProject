using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _carDal.GetAllByBrand(brandId);
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _carDal.GetAllByColor(colorId);
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(carId);
        }
    }
}