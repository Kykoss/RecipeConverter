using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeConverter.Units;

namespace RecipeConverter
{
    internal class Ingredient
    {
        public Ingredient(string name, double amount, Unit unit)
        {
            this.Name = name;
            this.Unit = unit;

            if (amount > 0)
                this.Amount = amount;
            else
                throw new ArgumentException("Die Menge darf nicht kleiner als 0 sein!");
        }

        public Unit Unit { get; private set; }

        public string Name { get; private set; }

        public double Amount { get; private set; }


    }
}
