using System.Collections.Generic;

namespace SessionOne
{
    internal static class UnitConversionFactor
    {
        public static int Get(Unit unit)
        {
            var conversionFactorMap = new Dictionary<Unit, int>
                                          {
                                              {Unit.INCH, 1}, 
                                              {Unit.FEET, 12},
                                              {Unit.YARD, 12*3},
                                              {Unit.MILE, 1760*12*3}
                                          };


            return conversionFactorMap[unit];
        }
    }
}