using System.Collections.Generic;
using Assignment1.Shared.Components.Notifications;

namespace Assignment1.Data.Notifications
{
    public interface INotificationManager
    {
        public void AddNotification(Notification notification);
        public List<Notification> GetNotifications();
        public void Subscribe(NotificationArea notificationArea);
        public Notification GetLastNotification();
        public void Remove(Notification notification);
    }
}