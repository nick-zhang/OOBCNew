namespace SessionOne
{
    public class Quantity
    {
        private readonly int amount;
        private readonly object unit;

        public Quantity(int amount, object unit)
        {
            this.amount = amount;
            this.unit = unit;
        }

        public bool Equals(Quantity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            var thisAmountFactor = UnitConversionFactor.Get(unit);
            var otherAmountFactor = UnitConversionFactor.Get(other.unit);

            return thisAmountFactor*amount == other.amount*otherAmountFactor;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Quantity)) return false;
            return Equals((Quantity) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (amount*397) ^ unit.GetHashCode();
            }
        }

        public Quantity Add(Quantity quantity)
        {
            var thisAmountFactor = UnitConversionFactor.Get(unit);
            var otherAmountFactor = UnitConversionFactor.Get(quantity.unit);
            return  new Quantity(thisAmountFactor*amount+otherAmountFactor*quantity.amount, LengthUnit.INCH);
        }
    }
}