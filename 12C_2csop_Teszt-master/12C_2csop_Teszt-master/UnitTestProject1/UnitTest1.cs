using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using atvaltOOP;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
            Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void isDecimal_True()
        {
            string szoveg = "21";
            bool vartEredm = true,
                 kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        public void isDecimal_False()
        {
            string szoveg = "12";
            bool vartEredm = false,
                 kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
