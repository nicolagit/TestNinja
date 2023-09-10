using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    public class CustomerControllerTest
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomerIdIsNOtZero_ReturnOK()
        {}
    }
}