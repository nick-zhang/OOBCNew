namespace SessionOne
{
    internal static class UnitAmountConvert
    {
        public static int GetBasicUnitAmount(Unit unit)
        {
            int thisBasicUnitAmount;

            switch (unit)
            {
                case Unit.FEET:
                    thisBasicUnitAmount = 12;
                    break;
                case Unit.YARD:
                    thisBasicUnitAmount = 12*3;
                    break;
                default:
                    thisBasicUnitAmount = 1;
                    break;
            }

            return thisBasicUnitAmount;
        }
    }
}