using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
            => Assert.AreEqual(true, true);

        [TestMethod]
        public void EmptyBrackets()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));

        [TestMethod]
        public void EmptyString()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));

        [TestMethod]
        public void LeftBracket()
            => Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));

        [TestMethod]
        public void RightBracket()
            => Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));

        [TestMethod]
        public void BackwardsBrackets()
            => Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));

        [TestMethod]
        public void BracketedString() 
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test]"));

        [TestMethod]
        public void BracketedStringWithTextToLeft()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[test]"));

        [TestMethod]
        public void BracketedStringWithTextToRight()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test]abc"));

        [TestMethod]
        public void BracketedStringWithTextToLeftAndRight()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[test]def"));

        [TestMethod]
        public void TwoBracketsWithTextBothSides()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[test][test2]def"));

        [TestMethod]
        public void NestedBrackets()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[test[test2]]"));

        [TestMethod]
        public void EmptyNestedBracket()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[test[]test2]def"));

        [TestMethod]
        public void TwoBrackets()
            => Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("abc[test][test2]def"));
    }
}
