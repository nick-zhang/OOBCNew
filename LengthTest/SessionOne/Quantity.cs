namespace SessionOne
{
    public class Quantity
    {
        private readonly int amount;
        private readonly Unit unit;

        public Quantity(int amount, Unit unit)
        {
            this.amount = amount;
            this.unit = unit;
        }

        public bool Equals(Quantity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            var thisBasicAmount = UnitConversionFactor.Get(unit);
            var otherBasicAmount = UnitConversionFactor.Get(other.unit);

            return thisBasicAmount*amount == other.amount*otherBasicAmount;
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
    }
}