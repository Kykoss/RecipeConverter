using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Import
{
    internal class RawTextImporter: RecipeImporter
    {
        private void CreateIngredient()
        {

        }

        public override Ingredient[] GetIngredients()
        {
            return Ingredients;
        }
    }
}
