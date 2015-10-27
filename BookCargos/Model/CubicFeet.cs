﻿namespace BookCargos.Model
{
    public class CubicFeet
    {
        private readonly int _value;

        public CubicFeet(int value)
        {
            _value = value;
        }

        public static CubicFeet Zero = new CubicFeet(0);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CubicFeet) obj);
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static bool operator <= (CubicFeet c1, CubicFeet c2)
        {
            return c1._value <= c2._value;
        }

        public static bool operator >= (CubicFeet c1, CubicFeet c2)
        {
            return c1._value >= c2._value;
        }

        public static CubicFeet operator + (CubicFeet c1, CubicFeet c2)
        {
            return new CubicFeet(c1._value + c2._value);
        }

        protected bool Equals(CubicFeet other)
        {
            return _value == other._value;
        }
    }
}