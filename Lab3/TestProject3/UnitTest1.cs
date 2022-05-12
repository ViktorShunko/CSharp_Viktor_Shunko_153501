using Microsoft.VisualStudio.TestTools.UnitTesting;
using t3;
using System;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime current = DateTime.Today;
            int year = current.Year;
            int month = current.Month;
            int day = current.Day;

            Assert.AreEqual(738259, DateService.duration(1,1,1,year,month,day));
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
