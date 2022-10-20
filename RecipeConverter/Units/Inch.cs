using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Units
{
    internal class Inch: Unit
    {
        public Inch()
        {
            this.MetricUnitText = "cm";
            this.ConversionRate = 2.54;
        }
    }
}
