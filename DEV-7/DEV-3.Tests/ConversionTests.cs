using System;
//using System.CodeDom;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DEV_3.Tests
{
    [TestFixture]
    public class ConversionTests
    {
        [TestCase("153", "2", "10011001")]
        [TestCase("153", "3", "12200")]
        [TestCase("153", "4", "2121")]
        [TestCase("153", "5", "1103")]
        [TestCase("153", "6", "413")]
        [TestCase("153", "7", "306")]
        [TestCase("153", "8", "231")]
        [TestCase("153", "9", "180")]
        [TestCase("153", "11", "12A")]
        [TestCase("153", "12", "109")]
        [TestCase("153", "13", "BA")]
        [TestCase("153", "14", "AD")]
        [TestCase("153", "15", "A3")]
        [TestCase("153", "16", "99")]
        [TestCase("153", "17", "90")]
        [TestCase("153", "18", "89")]
        [TestCase("153", "19", "81")]
        [TestCase("153", "20", "7D")]
        public void CorrectnessOfCalculation(string acceptedNumber, string acceptedBase, string expectedResult)
        {
            TransferFromDecimalNumberSystemToAnother tr = new TransferFromDecimalNumberSystemToAnother();
            string actual = tr.ToNumberSystem(acceptedNumber, acceptedBase);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("-1", "18")]
        [TestCase("153", "")]
        [TestCase("", "15")]
        [TestCase("2", "21")]
        [TestCase("aa", "2")]
        [TestCase("153", "aa")]
        public void ArgumentChecking(string acceptedNumber, string acceptedBase)
        {
            TransferFromDecimalNumberSystemToAnother tr = new TransferFromDecimalNumberSystemToAnother();
            Assert.Throws<Exception>(() => tr.ToNumberSystem(acceptedNumber, acceptedBase));
        }
    }
}