using System;
using System.Collections.Generic;

namespace SessionOne
{
    internal static class UnitConversionFactor
    {
        public static int LengthFactor(object unit)
        {
            var conversionFactorMap = new Dictionary<LengthUnit, int>
                                          {
                                              {LengthUnit.INCH, 1}, 
                                              {LengthUnit.FEET, 12},
                                              {LengthUnit.YARD, 12*3},
                                              {LengthUnit.MILE, 1760*12*3}
                                          };

            return conversionFactorMap[(LengthUnit) unit];
        }

        public static int Get(object unit)
        {
            if (unit is LengthUnit)
                return LengthFactor(unit);

            if (unit is VolumeUnit)
                return VolumeFactor(unit);
                
            throw new ApplicationException();
        }

        private static int VolumeFactor(object unit)
        {
            var conversionFactorMap = new Dictionary<VolumeUnit, int>
                                          {
                                              {VolumeUnit.TSP,  1}, 
                                              {VolumeUnit.TBSP, 3},
                                              {VolumeUnit.OZ, 3*2}
                                          };

            return conversionFactorMap[(VolumeUnit)unit];
        }
    }
}