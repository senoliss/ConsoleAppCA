using ConsoleAppCA3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetTextLength_LeadWhiteSpaceText_ReturnLength()
        {
            // Arrange
            string fakeName = " Hello ";
            // int expected = 7;
            int expected = 5;

            // Act
            int actual = Program.GetTextLength(fakeName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}