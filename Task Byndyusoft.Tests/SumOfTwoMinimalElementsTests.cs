using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Byndyusoft;
using System.Linq;

namespace Task_Byndyusoft.Tests
{
    [TestClass]
    public class SumOfTwoMinimalElementsTests
    {
        [TestMethod]
        public void Sum_0PlusMinus10_Minus10Returned()
        {
            int expected = -10;
         
            var res = Program.SumOfTwoMinimalElements(new int[] { 4, 0, 3, 19, 492, -10, 1 });
          
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_1Element_ItselfReturned()
        {
            int expected = -10;
           
            var res = Program.SumOfTwoMinimalElements(new int[] { -10 });
           
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_0Elements_0Returned()
        {
            int expected = 0;
            
            var res = Program.SumOfTwoMinimalElements(new int[] { });
            
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Sum_100MillionsElements()
        {
            int[] arr = Enumerable.Range(0, 100000000).ToArray();
            int expected = 1;
            
            var res = Program.SumOfTwoMinimalElements(arr);
            
            Assert.AreEqual(expected, res);
        }
    }
}
