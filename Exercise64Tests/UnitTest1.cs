using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise64;

namespace Exercise64Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsInt_CanParseToInt_True()
        {
            //Arrange
            var input = "17";

            //Act
            var result = Program.IsInt(input);

            //Assert
            var expected = true;

            Assert.AreEqual(expected as object, result);

        }

        [TestMethod]
        public void IsInt_CannotParseToInt_False()
        {
            //Arrange
            var input = "hello";

            //Act
            var result = Program.IsInt(input);

            //Assert
            var expected = false;

            Assert.AreEqual(expected as object, result);

        }
    }
}
