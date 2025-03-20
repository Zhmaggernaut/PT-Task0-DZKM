using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task0.Tests
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void ProcessData_WithValidInput_ReturnsExpectedResult()
        {
            var businessLogic = new BusinessLogic();
            string input = "test input";
            string result = businessLogic.ProcessData(input);
            Assert.IsTrue(result.Contains(input));
            Assert.IsTrue(result.Contains("sample data"));
        }
    }
}