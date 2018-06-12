using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundays
{
    [TestFixture]
    public class LastSundaysTest
    {
        [Test]
        public void GetLastSunday_GivenJanuary2013_ShouldReturnLastSundayOfJanuary()
        {
            //Arrange
            var year = 2013;
            var expexcted = "2013-01-27";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.First(),expexcted);
        }
        [Test]
        public void GetLastSunday_GivenJanuary2017_ShouldReturnLastSundayOfJanuary()
        {
            //Arrange
            var year = 2017;
            var expexcted = "2017-01-29";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.First(),expexcted);
        }
        [Test]
        public void GetLastSunday_GivenMarch2019_ShouldReturnLastSundayOfMarch()
        {
            //Arrange
            var year = 2019;
            var expexcted = "2019-03-31";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.ElementAt(2),expexcted);
        }
        [Test]
        public void GetLastSunday_GivenJanuary2020_ShouldReturnLastSundayOfJanuary()
        {
            //Arrange
            var year = 2020;
            var expexcted = "2020-01-26";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.First(),expexcted);
        }
        [Test]
        public void GetLastSunday_GivenFebruary2020AsALeapYear_ShouldReturnLastSundayOfFebruary()
        {
            //Arrange
            var year = 2020;
            var expexcted = "2020-02-23";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.ElementAt(1), expexcted);
        }
        [Test]
        public void GetLastSunday_GivenFebruary2032AsALeapYear_ShouldReturnLastSundayOfFebruary()
        {
            //Arrange
            var year = 2032;
            var expexcted = "2032-02-29";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.ElementAt(1), expexcted);
        }
        [Test]
        public void GetLastSunday_GivenJune2018_ShouldReturnLastSundayOfJune()
        {
            //Arrange
            var year = 2018;
            var expexcted = "2018-06-24";

            var sut = new LastSunday();

            //Act
            var actual = sut.GetLastSunday(year);

            //Assert
            Assert.AreEqual(actual.ElementAt(5), expexcted);
        }
    }
}
