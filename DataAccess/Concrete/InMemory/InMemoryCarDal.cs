using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() { Id = 1, BrandId = 1, ColorId=1, ModelYear=2020, DailyPrice=250, Description="İlk araba"},
                new Car() { Id = 2, BrandId = 1, ColorId=2, ModelYear=2021, DailyPrice=350, Description="İkinci araba"},
                new Car() { Id = 3, BrandId = 1, ColorId=3, ModelYear=2022, DailyPrice=450, Description="Üçüncü araba"},
                new Car() { Id = 4, BrandId = 1, ColorId=4, ModelYear=2020, DailyPrice=280, Description="Dördüncü araba"},
                new Car() { Id = 5, BrandId = 1, ColorId=5, ModelYear=2021, DailyPrice=370, Description=""},
                new Car() { Id = 6, BrandId = 2, ColorId=1, ModelYear=2022, DailyPrice=260, Description=""},
                new Car() { Id = 7, BrandId = 2, ColorId=2, ModelYear=2020, DailyPrice=345, Description=""},
                new Car() { Id = 8, BrandId = 2, ColorId=3, ModelYear=2021, DailyPrice=450, Description=""},
                new Car() { Id = 9, BrandId = 2, ColorId=4, ModelYear=2022, DailyPrice=560, Description=""},
                new Car() { Id = 10, BrandId = 2, ColorId=5, ModelYear=2020, DailyPrice=350, Description=""}                
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.FirstOrDefault(c=>c.Id == car.Id);
            if (carDelete != null)
                _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.FirstOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
            }
        }
    }
}
