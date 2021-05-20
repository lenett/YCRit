using EvaBot.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvaBot.ViewModels;

namespace EvaBot.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly iCarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, iCarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
