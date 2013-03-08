namespace SessionOne
{
    internal static class UnitConversionFactor
    {
        public static int Get(Unit unit)
        {
            int conversionFactor;

            switch (unit)
            {
                case Unit.FEET:
                    conversionFactor = 12;
                    break;
                case Unit.YARD:
                    conversionFactor = 12*3;
                    break;
                case Unit.MILE:
                    conversionFactor = 1760*12*3;
                    break;
                default:
                    conversionFactor = 1;
                    break;
            }

            return conversionFactor;
        }
    }
}