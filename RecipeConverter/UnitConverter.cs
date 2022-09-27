using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeConverter.Unit;

namespace RecipeConverter
{
    internal static class UnitConverter
    {
        private static IDictionary<string, Type> UnitClasses = new Dictionary<string, Type>()
        {
            {"oz", typeof(Pound) },
            {"\"", typeof(Inch) }
        };

        public static string ConvertLine(string recipeLine)
        {
            Unit.Unit ImperialUnit;

            Type test = UnitClasses["\""];

            try
            {
                ImperialUnit = (Unit.Unit)Activator.CreateInstance(test);
            }
            catch (ArgumentNullException)
            {
                throw new Exception("Unit is not in the supported UnitList");
            }

            return ImperialUnit.ConvertToMetric(5).ToString();
        }


    }
}
