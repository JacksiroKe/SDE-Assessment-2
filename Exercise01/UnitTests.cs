using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace Exercise01
{
    [TestClass]
    public class UnitTests
    {
        string numberInWords = "";
        string expectedWords = "";

        /// <summary>
        /// Tests if it returns a eighteen million from 18000000
        /// </summary>
        [TestMethod]
        public void Test18000000ToWords()
        {
            expectedWords = "eighteen million";
            numberInWords = Exercise01.ToWords(18000000);
            Assert.AreEqual(expectedWords, numberInWords.Trim());
        }

        /// <summary>
        /// Tests if it returns 8456002032011000007 as a string correctly
        /// </summary>
        [TestMethod]
        public void Test8456002032011000007ToWords()
        {
            var input = "8456002032011000007";
            expectedWords = "eight quintillion four hundred and fifty six quadrillion two trillion thirty two billion eleven million seven";
            BigInteger.TryParse(input, out BigInteger bigInteger);
            numberInWords = bigInteger.ToWords();
            Assert.AreEqual(expectedWords, numberInWords.Trim());
        }

    }
}