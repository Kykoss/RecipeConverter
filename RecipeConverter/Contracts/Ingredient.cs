using RecipeConverter.Contracts.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Contracts
{
    internal class Ingredient
    {
        public Unit Unit { get; }

        public double Quantity { get; }
    }
}
