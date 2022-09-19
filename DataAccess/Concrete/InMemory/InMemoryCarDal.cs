using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        private List<Brand> _brands;
        private List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 3, ColorId = 2, DailyPrice = 500, ModelYear = "2022", Description = "Temiz"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 500, ModelYear = "2021", Description = "Temiz"},
                new Car{CarId = 3, BrandId = 1, ColorId = 3, DailyPrice = 500, ModelYear = "2020", Description = "Temiz"},
                new Car{CarId = 4, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = "2019", Description = "Temiz"},
                new Car{CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 500, ModelYear = "2018", Description = "Temiz"}
            };
            _brands = new List<Brand>
            {
                new Brand { BrandId = 1, BrandName = "Toyota" },
                new Brand { BrandId = 2, BrandName = "Hyundai" },
                new Brand { BrandId = 3, BrandName = "Opel" }
            };
            _colors = new List<Color>
            {
                new Color { ColorId = 1, ColorName = "Black" },
                new Color { ColorId = 2, ColorName = "White" },
                new Color { ColorId = 3, ColorName = "Gray" }
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
    }
}