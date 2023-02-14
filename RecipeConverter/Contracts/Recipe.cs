using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Contracts
{
    internal class Recipe
    {
        public string Name { get; }

        public List<Ingredient> Ingredients { get; } = new();
    }
}
