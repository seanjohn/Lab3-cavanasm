using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), 5000);
            Assert.IsNotNull(target);
        }
        [Test()]
        public void TestThatFlightHasCorrectMiles()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), 5000);
            Assert.AreEqual(5000, target.Miles);
        }
        
        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDay()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), 5000);
            Assert.AreEqual(220, target.getBasePrice());
        }
        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDays()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 19), 5000);
            Assert.AreEqual(240, target.getBasePrice());
        }
        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDays()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 27), 5000);
            Assert.AreEqual(400, target.getBasePrice());
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsBadDates()
        {
            var target = new Flight(new DateTime(2011, 3, 18), new DateTime(2011, 3, 17), 5000);
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsNegMiles()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), -5000);
        }
        [Test()]
        public void TestTathFlightsAreEqual()
        {
            var target = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), 5000);
            var target2 = new Flight(new DateTime(2011, 3, 17), new DateTime(2011, 3, 18), 5000);
            Assert.True(target.Equals( target2));
        }
	}
}
