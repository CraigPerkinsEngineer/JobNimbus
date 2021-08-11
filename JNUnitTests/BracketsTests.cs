using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobNimbus;

namespace JNUnitTests
{
    [TestClass]
    public class BracketsTests
    {
        [TestMethod]
        public void ValidBrackets_Success_Basic()
        {
            // Arrange
            var input = "{}";

            // Act
            var result = Brackets.doBracketsMatch(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidBrackets_Success_Long()
        {
            // Arrange
            var input = "{{{}}}";

            // Act
            var result = Brackets.doBracketsMatch(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidBrackets_Success_Empty()
        {
            // Arrange
            var input = "";

            // Act
            var result = Brackets.doBracketsMatch(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidBrackets_Fail_Basic()
        {
            // Arrange
            var input = "}{";

            // Act
            var result = Brackets.doBracketsMatch(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidBrackets_Fail_Partial()
        {
            // Arrange
            var input = "{{}";

            // Act
            var result = Brackets.doBracketsMatch(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
