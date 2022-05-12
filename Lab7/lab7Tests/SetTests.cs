using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Tests
{
    [TestClass()]
    public class SetTests
    {
        [TestMethod()]
        public void unificationTest()
        {
            string strA = "12345";
            string strB = "2468";
            string AB = "1234568";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.unification(A, B);

            Assert.AreEqual(AB, returnStr);


        }

        [TestMethod()]
        public void unificationTest1()
        {
            string strA = "2468";
            string strB = "12345";
            string AB = "2468135";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(7);
            returnStr = C.unification(A, B);

            Assert.AreEqual(AB, returnStr);


        }

        [TestMethod()]
        public void unificationTest2()
        {
            string strA = "12345";
            string strB = "12345";
            string AB = "12345";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.unification(A, B);

            Assert.AreEqual(AB, returnStr);

        }

        [TestMethod()]
        public void intersectionTest()
        {
            string strA = "12345";
            string strB = "2468";
            string AB = "24";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.intersection(A, B);

            Assert.AreEqual(AB, returnStr);
        }

        [TestMethod()]
        public void intersectionTest1()
        {
            string strA = "12345";
            string strB = "qwert";
            string AB = "";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.intersection(A, B);

            Assert.AreEqual(AB, returnStr);
        }

        [TestMethod()]
        public void intersectionTest3()
        {
            string strA = "12345";
            string strB = "12345";
            string AB = "12345";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.intersection(A, B);

            Assert.AreEqual(AB, returnStr);
        }

        [TestMethod()]
        public void withoutTest()
        {
            string strA = "12345";
            string strB = "12345";
            string AB = "";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.without(A, B);

            Assert.AreEqual(AB, returnStr);
        }

        [TestMethod()]
        public void withoutTest1()
        {
            string strA = "12345";
            string strB = "2468";
            string AB = "135";
            string returnStr;

            Set A = (Set)strA;
            Set B = (Set)strB;
            Set C = new Set(3);
            returnStr = C.without(A, B);

            Assert.AreEqual(AB, returnStr);
        }    
    }
}