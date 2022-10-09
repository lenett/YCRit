using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvaWeb.Models;

namespace EvaWeb.Components
{
    public class NavigationBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<NavigationBarLink> navibarLink = InicializeNavbar();


            return View(navibarLink);
        }

        private List<NavigationBarLink> InicializeNavbar()
        {
            List<NavigationBarLink> navibarLink = new List<NavigationBarLink>();
            navibarLink.Add(new NavigationBarLink { ClassParametrs = "nav-link text-white", Image = "#home", Link = "/#", Text = "Главная", StartLi =true});
            navibarLink.Add(new NavigationBarLink { ClassParametrs = "nav-link text-white", Image = "#table", Link = "/library/books/index", Text = "Библиотека", StartLi = true });
            navibarLink.Add(new NavigationBarLink { ClassParametrs = "nav-link text-white", Image = "#grid", Link = "/identity/account/login", Text = "Словарь", StartLi = true });
            //navibarLink.Add(new NavibarLink { classParametrs = "collapsible", image = "#home", link = "#", text = "Администрирование", opLi = true });
            //navibarLink.Add(new NavibarLink { classParametrs = "", image = "#speedometer2", link = "/identity/account/login", text = "Пользователи", endLi = true, content=true });

            return navibarLink;
        }
    }
}
