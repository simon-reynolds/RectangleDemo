using System;
using NUnit;
using NUnit.Framework;

using RectangleDemoCs;

namespace RectangleDemoTests
{
    [TestFixture]
    public class RectangleDemoCsTests
    {
        [Test]
        public void CanConstructRectangle()
        {
            var rectangle = new Rectangle(10, 10);

            Assert.IsTrue(rectangle.IsSquare());
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ThrowsException_WhenLengthIsZero()
        {
            var rectangle = new Rectangle(0, 10);
        }
    }
}
