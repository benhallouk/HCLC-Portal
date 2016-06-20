using System.Linq;
using FluentAssertions;
using Hackney.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hackney.Tests.Domains.Models
{
    public class ApplicationUserTests
    {
        private object notification;

        [TestMethod]
        public void Notify_WhenCalled_ShouldAddTheNotification()
        {
            var user = new ApplicationUser();


            user.Notify(notification);
            user.UserNotifications.Count.Should().Be(1);

            var userNotification = user.UserNotifications.First();
            userNotification.Notification.Should().Be(notification);
            userNotification.User.Should().Be(user);
        }
    }
}
