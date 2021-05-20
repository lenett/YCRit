using EvaBot.Data.Interfaces;
using EvaBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly iCarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name="Tesla",
                        img="/img/tesla.jpg",
                        price=12,
                        isFavorite=true,
                        available=true,
                        catrgory=_categoryCars.AllCategories.ElementAtOrDefault(0)
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
