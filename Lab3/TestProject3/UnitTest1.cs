using Microsoft.VisualStudio.TestTools.UnitTesting;
using t3;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, DateService.duration(1,1,1,1,1,1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, DateService.convert_to_days(1, 1, 1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, DateService.week_number(1, 1));
        }
    }
}
