using System;

namespace EDIConsoleSlackNotifications.Notifications
{
    public class SlackNotificationService : INotificationService
    {
        readonly ISlackAPI _api;
        public SlackNotificationService(ISlackAPI api)
        {
            _api = api;
        }
        public bool Send(NotificationParams notificationData)
        {
            _api.PostMessage(notificationData.Name, notificationData.Body);

            // temporarily return true while we implement the API properly.
            return true;
        }
    }

    public interface ISlackAPI
    {
        void PostMessage(string name, string body);
    }

    public class SlackAPI : ISlackAPI
    {
        public void PostMessage(string name, string body)
        {
            throw new NotImplementedException();
        }
    }
}