using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_USerIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsUser_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            var user = new User{ IsAdmin = false };
            reservation.MadeBy = user;

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_NotAdminNorUser_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            // Assert
            Assert.IsFalse(result);
        }
    }
}
