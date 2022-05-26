using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_task_Byndyusoft;
using System.Linq;

namespace Task_Byndyusoft.Tests
{
    [TestClass]
    public class SumOfTwoMinimalElementsTests
    {
        [TestMethod]
        public void Sum_0PlusMinus10_Minus10Returned()
        {
            // arrange
            int expected = -10;
            // act
            var res = Program.SumOfTwoMinimalElements(new int[] { 4, 0, 3, 19, 492, -10, 1 });
            // assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_1Element_ItselfReturned()
        {
            // arrange
            int expected = -10;
            // act
            var res = Program.SumOfTwoMinimalElements(new int[] { -10 });
            // assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_0Elements_0Returned()
        {
            // arrange
            int expected = 0;
            // act
            var res = Program.SumOfTwoMinimalElements(new int[] { });
            // assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_100MillionsElements()
        {
            // arrange
            int[] arr = Enumerable.Range(0, 100000000).ToArray();
            int expected = 1;
            // act
            var res = Program.SumOfTwoMinimalElements(arr);
            // assert
            Assert.AreEqual(expected, res);
        }
    }
}
