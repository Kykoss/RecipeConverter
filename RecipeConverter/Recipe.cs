using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeConverter.Import;

namespace RecipeConverter
{
    internal class Recipe
    {
        protected Ingredient[] Ingredients { get; set; }

        public Recipe(Ingredient[] ingredients)
        {
            this.Ingredients = ingredients;
        }
    }
}
