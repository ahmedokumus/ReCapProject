using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrand(int brandId);
        List<Car> GetAllByColor(int colorId);
        Car GetById(int carId);
    }
}