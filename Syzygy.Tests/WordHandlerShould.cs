using System;
using Syzygy.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Syzygy.Tests
{
    [TestClass]
    public class WordHandlerShould
    {
        [TestMethod]
        public void ReturnTrue_GivenMatchingStrings()
        {
            var stringList = new List<string>()
            {
                "On",
                "No"
            };
            var wordHandler = new WordHandler();
            var expected = true;
            var actual = wordHandler.CompareWords(stringList[0],
                                                    stringList);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalse_GivenOneString()
        {
            var stringList = new List<string>()
            {
                "On"
            };
            var wordHandler = new WordHandler();
            var expected = false;
            var actual = wordHandler.CompareWords(stringList[0],
                                                    stringList);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalse_GivenNoMatchingStrings()
        {
            var stringList = new List<string>()
            {
                "On",
                "To",
                "At"
            };
            var wordHandler = new WordHandler();
            var expected = false;
            var actual = wordHandler.CompareWords(stringList[0],
                                                    stringList);
            Assert.AreEqual(expected, actual);

        }


    }
}
