using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KolkoiKrzyzyk;
using Kolko_krzyzyk;

namespace KolkoiKrzyzyk
{
    /// <summary>
    /// Test
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Metoda testowa
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            bool czy_ok = helper.ver_login("%");
            Assert.IsFalse(czy_ok);

            czy_ok = helper.ver_login("");
            Assert.IsFalse(czy_ok);


            czy_ok = helper.ver_login("#");
            Assert.IsTrue(czy_ok);

        }
        /// <summary>
        /// Metoda testowa
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            bool czy_ok = helper.ver_haslo("%");
            Assert.IsFalse(czy_ok);

            czy_ok = helper.ver_haslo("");
            Assert.IsFalse(czy_ok);


            czy_ok = helper.ver_haslo("#");
            Assert.IsTrue(czy_ok);

            czy_ok = helper.ver_haslo("!");
            Assert.IsTrue(czy_ok);
        }
    }
}
