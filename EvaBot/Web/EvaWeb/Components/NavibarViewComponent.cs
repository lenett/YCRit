using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvaWeb.Models;

namespace EvaWeb.Components
{
    public class NavibarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<NavibarLink> navibarLink = InicializeNavbar();


            return View(navibarLink);
        }

        private List<NavibarLink> InicializeNavbar()
        {
            List<NavibarLink> navibarLink = new List<NavibarLink>();
            navibarLink.Add(new NavibarLink { classParametrs = "nav-link text-white", image = "#home", link = "/#", text = "Главная", opLi =true});
            navibarLink.Add(new NavibarLink { classParametrs = "nav-link text-white", image = "#table", link = "/library/books/index", text = "Библиотека", opLi = true });
            navibarLink.Add(new NavibarLink { classParametrs = "nav-link text-white", image = "#grid", link = "/identity/account/login", text = "Словарь", opLi = true });
            //navibarLink.Add(new NavibarLink { classParametrs = "collapsible", image = "#home", link = "#", text = "Администрирование", opLi = true });
            //navibarLink.Add(new NavibarLink { classParametrs = "", image = "#speedometer2", link = "/identity/account/login", text = "Пользователи", endLi = true, content=true });

            return navibarLink;
        }
    }
}
