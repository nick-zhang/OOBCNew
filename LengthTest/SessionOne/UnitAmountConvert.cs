namespace SessionOne
{
    static internal class UnitAmountConvert
    {
        public static int GetBasicUnitAmount(Unit unit)
        {
            var thisBasicUnitAmount = 1;
            if (unit.Equals(Unit.FEET))
                thisBasicUnitAmount = 12;
            return thisBasicUnitAmount;
        }
    }
}