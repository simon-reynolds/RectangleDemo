using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using RectangleDemoFs;

namespace RectangleDemoTests
{
    [TestFixture]
    public class RectangleDemoFsTests
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
