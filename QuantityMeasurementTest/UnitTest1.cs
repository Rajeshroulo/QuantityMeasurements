using NUnit.Framework;
using QuantityMeasurmentApplication;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementTest : QuantityMeasurement
    {
        QuantityMeasurement quantityMeasurement;

        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement();
        }

        [Test]
          public void GivenValuesOfInchandFoot_WhenConversionIsProper_ShouldReturnTrue()
            {

                QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 12.0);
                QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1.0);
                bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
                Assert.IsTrue(check);
            }
        [Test]
        public void GivenTwofFeetValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.FEET, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 0.0);
            Assert.AreEqual(quantityMeasurement1, quantityMeasurement2);
        }

        [Test]
        public void GivenTwoFeetValues_whenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.FEET, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1.0);
            Assert.AreNotEqual(quantityMeasurement1, quantityMeasurement2);
        }

        [Test]
        public void GivenTwoInchValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 0.0);
            Assert.AreEqual(quantityMeasurement1, quantityMeasurement2);
        }

        [Test]
        public void GivenTwoInchValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 2.0);
            Assert.AreNotEqual(quantityMeasurement1, quantityMeasurement2);
        }

        [Test]
        public void GivenInchandFeetValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 0.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenInchandfeetValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GiveninchandfeetValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.INCH, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 12.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivenYardandFeetValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 3.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenYardandFeetValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 3.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1.0);
            Assert.AreNotEqual(quantityMeasurement1, quantityMeasurement2);
        }

        [Test]
        public void GivenYardandFeetValues_WhenNotEqual_shouldReturnNotEquals()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivenYardandfeetValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.FEET, 3.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }


        [Test]
        public void GivenYardandInchValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 36.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenYardandcentimeterValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.YARD, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.CMS, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivencentimeterandinchValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.CMS, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivencentimeterandInchValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.CMS, 2.5);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivencentimeterandinchValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.CMS, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 0.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenCentimeterandInchValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.CMS, 5.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.INCH, 2.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void Given2inchAnd2inch_whenAdded_shouldReturn4inches()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement( Unit.INCH,2.0), new QuantityMeasurement( Unit.INCH,2.0));
            Assert.AreEqual(4.0, result);
        }

        [Test]
        public void Given1FeetAnd1Feet_whenAdded_shouldReturn24inches()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.FEET, 1.0), new QuantityMeasurement(Unit.FEET, 1.0));
            Assert.AreEqual(24.0, result);
        }

        [Test]
        public void Given1FeetAnd2Inch_whenAdded_shouldReturn14inches()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.FEET, 1.0), new QuantityMeasurement(Unit.INCH, 2.0));
            Assert.AreEqual(14.0, result);
        }

        [Test]
        public void Givenfeetandinchesvalues_whenAdded_shouldReturnCorrectResult()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.INCH, 2.0), new QuantityMeasurement(Unit.CMS, 2.5));
            Assert.AreEqual(3.0, result);
        }

        [Test]
        public void Givenfeetandyardvalues_whenAdded_shouldReturnCorrectResult()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.FEET, 1.0), new QuantityMeasurement(Unit.YARD, 1.5));
            Assert.AreEqual(66.0, result);
        }

        [Test]
        public void GivenlitreandgallonValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.LITRE, 3.78);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.GALLON, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenlitreandmillilitreValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.ML, 1000.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.LITRE, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenlitreandmillilitreValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.ML, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.LITRE, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivenlitreandgallonValues_WhenNotEqual_shouldReturnNotEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.GALLON, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.LITRE, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivenLitreandmillilitreValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.ML, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.LITRE, 0.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenLitreandGallonValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.ML, 0.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.LITRE, 0.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void Givenlitreandgallonvalues_whenAdded_shouldReturnCorrectResult()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.GALLON, 1.0), new QuantityMeasurement(Unit.LITRE, 3.78));
            Assert.AreEqual(8.0, result);
        }

        [Test]
        public void Givenlitreandmillilitrevalues_whenAdded_shouldReturnCorrectResult()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.LITRE, 1.0), new QuantityMeasurement(Unit.ML, 1000.0));
            Assert.AreEqual(2.0, result);
        }

        [Test]
        public void GivenKilogramandgramValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.KG, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.GRAMS, 1000.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenkilogramsandtonneValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.KG, 1000.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.TONNE, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

        [Test]
        public void GivenGramsandTonnevalues_whenAdded_shouldReturnCorrectResult()
        {
            double result = quantityMeasurement.Add(new QuantityMeasurement(Unit.TONNE, 1.0), new QuantityMeasurement(Unit.GRAMS, 1000.0));
            Assert.AreEqual(1001.0, result);
        }

        [Test]
        public void GivenfahrenheitandCelsiusValues_WhenNOTEqual_shouldReturnNOTEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.FAHRENHEIT, 1.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.CELSIUS, 1.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsFalse(check);
        }

        [Test]
        public void GivenfahrenheitandCelsiusValues_WhenEqual_shouldReturnEqual()
        {
            QuantityMeasurement quantityMeasurement1 = new QuantityMeasurement(Unit.FAHRENHEIT, 212.0);
            QuantityMeasurement quantityMeasurement2 = new QuantityMeasurement(Unit.CELSIUS, 100.0);
            bool check = quantityMeasurement.Conversion(quantityMeasurement1, quantityMeasurement2);
            Assert.IsTrue(check);
        }

    }

}