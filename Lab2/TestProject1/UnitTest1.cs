using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Program.Bb(300));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, Program.Cc(111));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Program.b_is_bigger(300, 200));
        }
    }
}
