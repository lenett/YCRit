using EvaBot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Data.Interfaces
{
    public interface iCarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
