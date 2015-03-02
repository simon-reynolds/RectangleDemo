namespace RectangleDemoTestsFs

open NUnit.Framework
open RectangleDemoCs

[<TestFixture>]
type RectangleDemoCsTests() = 
    
    [<Test>]
    let CanConstructRectangle() =
        let rectangle = Rectangle(10m, 10m)
        Assert.IsTrue(rectangle.IsSquare())


    [<Test; ExpectedException("ArgumentOutOfRangeException")>]
    let ``A rectangle cannot have a length of zero. Expect an exception``() =
        Rectangle(0m, 10m)


    [<Test>]
    let ``A rectangle of length 10 and width 5 should have an area of 50 and perimeter of 30``() = 
        let rectangle = Rectangle(10m, 5m)

        Assert.That(rectangle.Area, Is.EqualTo(50m))
        Assert.That(rectangle.Perimeter, Is.EqualTo(30m))
        