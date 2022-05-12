using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Tarif tarif = new Tarif();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(100, tarif.Get_price());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("My ATS", ATS.ats.GetName());
        }
        [TestMethod]
        public void TestMethod3()
        {
            tarif.Up_price();
            Assert.AreEqual(110, tarif.Get_price());
        }
    }
}
