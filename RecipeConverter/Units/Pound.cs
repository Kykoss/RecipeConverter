using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Units
{
    internal class Pound: Unit
    {
        public Pound()
        {
            this.MetricUnitText = "kg";
            this.ConversionRate = 0.453592;
        }
    }
}
