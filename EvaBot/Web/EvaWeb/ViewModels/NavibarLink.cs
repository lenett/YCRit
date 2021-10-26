using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EvaWeb.ViewModels
{
    public class NavibarLink 
    {
        [Key]
        public int id { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }

    }
}
