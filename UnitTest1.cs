using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Laba_2;

namespace UnitTestMTD_Laba_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var figure = new Rectangle(30, 40);
            var result = figure.Clone();
            var expected = new Rectangle(30, 40);
            Assert.AreEqual(expected._width, result._width);
            Assert.AreEqual(expected._height, result._height);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var figur = new Circle(30);
            var result = figur.Clone();
            var expected = new Circle(30);
            Assert.AreEqual(expected._radius, result._radius);
        }
    }
}