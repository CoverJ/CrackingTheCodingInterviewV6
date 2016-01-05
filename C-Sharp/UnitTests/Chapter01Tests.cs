using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter01;

namespace UnitTests
{
    /// <summary>
    /// Summary description for Chapter01Tests
    /// </summary>
    [TestClass]
    public class Chapter01Tests
    {
        [TestMethod]
        public void Q01_1()
        {
            // Arrange
            var test = new Chapter01.Q01_1();
            string s1 = "abcdefghijklmnopqrstuvwxyz";   // true
            string s2 = "aa";                           // false
            string s3 = "abcdefghijklmnopqrstuvwxyza";  // false
            // Act
            bool u1 = test.IsUnique(s1);
            bool u2 = test.IsUnique(s2);
            bool u3 = test.IsUnique(s3);
            bool ru1 = test.IsUniqueNoExtraDataStructures(s1);
            bool ru2 = test.IsUniqueNoExtraDataStructures(s2);
            bool ru3 = test.IsUniqueNoExtraDataStructures(s3);
            // Assert
            Assert.IsTrue(u1);
            Assert.IsFalse(u2);
            Assert.IsFalse(u3);
            Assert.IsTrue(ru1);
            Assert.IsFalse(ru2);
            Assert.IsFalse(ru3);
        }

        [TestMethod]
        public void Q01_2()
        {
            var test = new Chapter01.Q01_2();
            string matchingString1 = "abcd1234";    // matching
            string matchingString2 = "1432dcab";    // matching
            string nonMatchingString = "zxcvbn";    // non-matching


        }
    }
}
