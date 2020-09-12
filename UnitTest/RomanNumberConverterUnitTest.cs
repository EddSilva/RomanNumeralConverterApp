using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;

namespace UnitTest
{
    [TestClass]
    public class RomanNumberConverterUnitTest
    {
        [TestMethod]
        public void ONE_YELDS_I()
        {
            string result = 1.ToRoman();

            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void FIVE_YELDS_V()
        {
            string result = 5.ToRoman();

            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TEN_YELDS_X()
        {
            string result = 10.ToRoman();

            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void FIFTY_YELDS_L()
        {
            string result = 50.ToRoman();

            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void ONE_HUNDRED_YELDS_C()
        {
            string result = 100.ToRoman();

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void FIVE_HUNDRED_YELDS_D()
        {
            string result = 500.ToRoman();

            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void ONE_THOUSAND_YELDS_M()
        {
            string result = 1000.ToRoman();

            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void FOUR_YELDS_IV()
        {
            string result = 4.ToRoman();

            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void FORTY_YELDS_XL()
        {
            string result = 40.ToRoman();

            Assert.AreEqual("XL", result);
        }

        [TestMethod]
        public void NINETY_YELDS_XC()
        {
            string result = 90.ToRoman();

            Assert.AreEqual("XC", result);
        }

        [TestMethod]
        public void NINEHUNDRED_YELDS_CM()
        {
            string result = 900.ToRoman();

            Assert.AreEqual("CM", result);
        }

        [TestMethod]
        public void FIFTEEN_YELDS_XV()
        {
            string result = 15.ToRoman();

            Assert.AreEqual("XV", result);
        }

        [TestMethod]
        public void SEVEN_HUNDRED_FORTY_NINE_YIELDS_DCCXLIX()
        {
            string result = 749.ToRoman();

            Assert.AreEqual("DCCXLIX", result);
        }

        [TestMethod]
        public void ONE_THOUSAND_SIX_HUNDRED_THIRTY_TWO_YELDS_MDCXXXII()
        {
            string result = 1632.ToRoman();

            Assert.AreEqual("MDCXXXII", result);
        }

        [TestMethod]
        public void ONE_THOUSAND_NINE_HUNDRED_FORTY_FOUR_YELDS_MCMXLIV()
        {
            string result = 1944.ToRoman();

            Assert.AreEqual("MCMXLIV", result);
        }


        [TestMethod]
        public void ONE_THOUSAND_FOUR_HUNDRED_NINETY_FOUR_YELDS_MCDXCIV()
        {
            string result = 1494.ToRoman();

            Assert.AreEqual("MCDXCIV", result);
        }


        [TestMethod]
        public void FOUR_HUNDRED_NINETY_FOUR_YELDS_CDXCIV()
        {
            string result = 494.ToRoman();

            Assert.AreEqual("CDXCIV", result);
        }

        [TestMethod]
        public void ONE_THOUSAND_NINE_HUNDRED_SIXTY_EIGHT_YELDS_MCMLXVIII()
        {
            string result = 1968.ToRoman();

            Assert.AreEqual("MCMLXVIII", result);
        }

        [TestMethod]
        public void TWO_THOUSAND_SIX_YELDS_MMVI()
        {
            string result = 2006.ToRoman();

            Assert.AreEqual("MMVI", result);
        }


        [TestMethod]
        public void ONE_THOUSAND_NINE_HUNDRED_NINETY_SIX_YELDS_MCMXCVI()
        {
            string result = 1996.ToRoman();

            Assert.AreEqual("MCMXCVI", result);
        }

        [TestMethod]
        public void TWO_THOUSAND_YELDS_MM()
        {
            string result = 2000.ToRoman();

            Assert.AreEqual("MM", result);
        }
    }
}
