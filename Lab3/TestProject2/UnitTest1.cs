using Microsoft.VisualStudio.TestTools.UnitTesting;
using t2;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Class1.X(0, 1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-2.2538428352724087, Class1.Y(1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Class1.Z_is_less_than_1(0));
        }
    }
}
