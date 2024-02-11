using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoIntegers_ReturnsSum()
        {
            int result = Operations.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        // Add more tests to cover edge cases if necessary
    }
}
