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
            Assert.AreEqual(true, Program.One(0,0));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, Program.Two(0, 0));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Program.Three(-1, -1));
        }
    }
}
