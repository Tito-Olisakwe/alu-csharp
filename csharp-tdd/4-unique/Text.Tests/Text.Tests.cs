using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_WithNoUniqueChar_ReturnsMinusOne()
        {
            string input = "aabbcc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_WithOneUniqueCharAtStart_ReturnsZero()
        {
            string input = "abcdde";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_WithOneUniqueCharAtEnd_ReturnsIndex()
        {
            string input = "aabbccd";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void UniqueChar_WithMultipleUniqueChars_ReturnsFirstUniqueIndex()
        {
            string input = "abcde";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_WithEmptyString_ReturnsMinusOne()
        {
            string input = "";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_WithAllRepeatingChars_ReturnsMinusOne()
        {
            string input = "aabb";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_WithSingleChar_ReturnsZero()
        {
            string input = "z";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);
        }
    }
}
