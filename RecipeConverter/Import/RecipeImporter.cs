using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Import
{
    internal abstract class RecipeImporter
    {
        protected Ingredient[] Ingredients { get; set; }

        public abstract Ingredient[] GetIngredients();
    }
}
