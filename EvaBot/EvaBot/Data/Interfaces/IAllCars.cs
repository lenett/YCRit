﻿using EvaBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
