using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaWeb.Models
{
    public struct NavibarLink
    {
        public string text { get; set; }
        public string link { get; set; }
        public string image { get; set; }
        public string classParametrs { get; set; }
        public bool opLi { get; set; }
        public bool endLi { get; set; }
        public bool content { get; set; }

        public string GetOpLi()
        {

            if (opLi) return "<li>";
            else return "";
        }
        public string GetEndLi()
        {
            string res = "</li>";
            if (opLi) return res.ToString();
            else return "";
        }

    }
    



}
