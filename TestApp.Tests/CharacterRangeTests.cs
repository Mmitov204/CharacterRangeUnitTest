using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
       // Arrange
            char a = 'a';
            char b = 'b';

            // Act
            string result = CharacterRange.GetRange(a, b);

            // Assert
            Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char b = 'b';
        char a = 'a';

        // Act
        string result = CharacterRange.GetRange(b, a);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'a';
        char c = 'c';

        // Act
        string result = CharacterRange.GetRange(a, c);

        // Assert
        Assert.AreEqual("b", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
       // Arrange
         char d = 'd';
        char g = 'g';

        // Act
        string result = CharacterRange.GetRange(d, g);

        // Assert
        Assert.AreEqual("e f", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        //Arrange
        char x = 'x';
        char z = 'z';
        //Act
        string result = CharacterRange.GetRange(x , z);
        //Assert
        Assert.AreEqual("y", result);
    }
}
