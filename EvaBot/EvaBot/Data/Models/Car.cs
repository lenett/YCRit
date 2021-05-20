using EvaBot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public ushort price{ get; set; }
        public bool isFavorite { get; set; }
        public bool available { get; set; }
        public int catrgoryId { get; set; }
        public virtual Category catrgory { get; set; }
    }
}
