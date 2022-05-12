using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        BlockOfFlats build = new BlockOfFlats(5,100,"kamen'");

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("kamen'", build.GetMaterial());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(100, build.GetDebtForElectricity());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(5, build.NumberOfFlats);
        }
    }
}
