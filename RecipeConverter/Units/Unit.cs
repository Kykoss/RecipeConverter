using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeConverter.Units
{
    internal abstract class Unit
    {
        protected string MetricUnitText { get; set; } = String.Empty;
        protected double ConversionRate { get; set; }

        public double ConvertToMetric(double imperialValue)
        {
            if (this.ConversionRate == 0 || this.MetricUnitText == String.Empty)
                throw new Exception("Unit not initialized");

            return imperialValue * this.ConversionRate;
        }
    }
}

