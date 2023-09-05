using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ConsoleAppCA3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("hi");
            GetTextLength_LeadWhiteSpaceText_ReturnLength();
        }
        public static int GetTextLength(string text, bool includeLeadSpace = true)
        {
            if (!includeLeadSpace)
            {
                return text.Trim().Length;
            }
            else
            {
                return text.Length;
            }
        }
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