using System;

namespace EDIConsoleSlackNotifications.Notifications
{
    public interface INotificationService
    {
        bool Send(NotificationParams notificationData);
    }

    public class NotificationParams
    {
        public string Name { get; set; }
        public string Body { get; set; }
    }
}