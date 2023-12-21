using System;
using EvaluationSampleCode;

namespace Evalutation_RomainGILOT_UnitTest;
[TestClass]
public class ReservationTests
{
    [TestMethod]
    public void CanBeCancelledBy_AdminUser_ReturnsTrue()
    {
        var adminUser = new User { IsAdmin = true };
        var reservationMadeByUser = new User();

        var reservation = new Reservation(reservationMadeByUser);

        var result = reservation.CanBeCancelledBy(adminUser);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_User_ReturnsTrue()
    {
        var user = new User();
        var reservation = new Reservation(user);

        var result = reservation.CanBeCancelledBy(user);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_DifferentUser_ReturnsFalse()
    {
        var user1 = new User();
        var user2 = new User();
        var reservation = new Reservation(user1);

        var result = reservation.CanBeCancelledBy(user2);

        Assert.IsFalse(result);
    }
}

