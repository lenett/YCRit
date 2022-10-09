using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaWeb.Models
{
    public struct NavigationBarLink
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string ClassParametrs { get; set; }
        public bool StartLi { get; set; }
        public bool EndLi { get; set; }
        public bool Content { get; set; }

        public string GetStartLi()
        {

            if (StartLi) return "<li>";
            else return "";
        }
        public string GetEndLi()
        {
            string res = "</li>";
            if (StartLi) return res.ToString();
            else return "";
        }

    }
    



}
