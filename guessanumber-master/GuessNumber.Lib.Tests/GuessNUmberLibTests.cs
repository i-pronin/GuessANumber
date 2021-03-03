using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessNumber.Lib.Tests
{
    [TestClass]
    public class GuessNumberLibTests
    {
        [DataTestMethod]
        [DataRow (100,100, true)]
        [DataRow(2, 5, false)]
        [DataRow(0, 5, false)]

        public void CheckNumberTest_ShouldReturnTrueIfGuessed(int userNumber, int secretNumber, bool expected)
        {
            var actual = Game.CheckNumber(userNumber, secretNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
