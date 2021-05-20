using EvaBot.Data.Interfaces;
using EvaBot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaBot.Data.Mocks
{
    public class MockCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName="ASfasdf",desc="sadfsdf"},
                    new Category{categoryName="2ASfasdf",desc="2sadfsdf"}
                };
            }
        }
    }
}
