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

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var math = new Math();

            var result = math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var math = new Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
            
        }

        [Test]
        public void Max_ArgumentAreEquale_ReturnTheSameArgument()
        {
            var math = new Math();

            var result = math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}