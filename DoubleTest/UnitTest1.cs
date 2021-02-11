using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoubleTest
{
    [TestClass]
    public class UnitTest1
    {
        private const double delta = 0.01;

        [TestMethod]
        public void TestMethod1()
        {
            double d1 = 23.123456789;
            double dres = d1 * 100;

            Assert.AreEqual(2312.3456789, dres, delta);
        }
    }
}
