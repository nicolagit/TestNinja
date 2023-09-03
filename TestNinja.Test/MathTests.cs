using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    public class Math_Tests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_RetursTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result.Equals(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
            
        }

        [Test]
        public void Max_ArgumentAreEquale_ReturnTheSameArgument()
        {
            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}