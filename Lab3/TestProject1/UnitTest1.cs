using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(200, Program.Min(300, 200));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, Program.Z(1,1));
        }
    }
}
