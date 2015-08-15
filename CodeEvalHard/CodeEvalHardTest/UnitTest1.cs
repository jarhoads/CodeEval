using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeEvalHard;

namespace CodeEvalHardTest
{
    [TestClass]
    public class CodeEvalHardTests
    {
        [TestMethod]
        public void LongestCommonSubsequenceTest()
        {
            var input1 = "XMJYAUZ;MZJAWXU";
            var expected = "MJAU";

            LCS longestSequence = new LCS(input1);
            Assert.AreEqual(expected, longestSequence.LongestCommonSequence,"sequence no correct");
        }
    }
}
