using System.Security.Principal;
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
        //[Ignore("Because I wanted to!")]
        public void Add_WhenCalled_RetursTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
            //Assert.That(_math, Is.Not.Null);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}