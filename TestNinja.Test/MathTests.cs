using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    public class Math_Tests
    {
        [Test]
        public void Add_WhenCalled_RetursTheSumOfArguments()
        {
            var math = new Math();

            var result = math.Add(1, 2);

            Assert.That(result.Equals(3));
        }
    }
}