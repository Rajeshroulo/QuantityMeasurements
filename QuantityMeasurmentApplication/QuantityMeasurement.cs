using System;

namespace QuantityMeasurmentApplication
{
   public class QuantityMeasurement
    {
        public double Value;

        public Unit UnitType;

        public QuantityMeasurement()
        {

        }

        public QuantityMeasurement(Unit unit, double value)
        {
            this.UnitType = unit;
            this.Value = value;
        }

        public enum Unit
        {
            FEET, INCH, YARD, CMS,
            GALLON,LITRE,ML,
            KG,GRAMS,TONNE,
            FAHRENHEIT,CELSIUS
        };

        override
       public bool Equals(object o)
        {
            if (this == o) return true;
            if (o == null) return false;
            QuantityMeasurement that = (QuantityMeasurement)o;
            return that.Value == Value && that.UnitType == UnitType;
        }

        private double Unitsvalue(Unit unit)
        {
            return unit switch
            {
                Unit.INCH => 1,
                Unit.FEET => 12,
                Unit.YARD => 36,
                Unit.CMS => 0.4,
                Unit.LITRE => 1,
                Unit.GALLON => 3.78,
                Unit.ML => 0.001,
                Unit.KG => 1,
                Unit.GRAMS => 0.001,
                Unit.TONNE => 1000,
                Unit.FAHRENHEIT => 100,
                Unit.CELSIUS => 212,
                _ => 0,
            };
        }

        public bool Conversion(QuantityMeasurement firstUnit, QuantityMeasurement secondUnit)
        {
            double baseUnit1 = Unitsvalue(firstUnit.UnitType);
            double baseUnit2 = Unitsvalue(secondUnit.UnitType);
            return Compare(firstUnit, secondUnit, baseUnit1, baseUnit2);
        }


        private bool Compare(QuantityMeasurement firstUnit, QuantityMeasurement secountUnit, double firstBaseUnit, double secondBaseUnit)
        {
            return Math.Round(firstUnit.Value * firstBaseUnit).CompareTo(Math.Round(secountUnit.Value * secondBaseUnit)) == 0;
        }

        public double Add(QuantityMeasurement firstUnit, QuantityMeasurement secondUnit)
        {
            double baseUnit1 = Unitsvalue(firstUnit.UnitType);
            double baseUnit2 = Unitsvalue(secondUnit.UnitType);
            return Math.Round(firstUnit.Value * baseUnit1) + Math.Round(secondUnit.Value * baseUnit2);
        }

        static void Main(string[] args)
        {
           
        }
    }
}
