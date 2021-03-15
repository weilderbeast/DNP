using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1.Shared.Components.Notification;

namespace Assignment1.Data.Notifications{
    public class NotificationManager : INotificationManager
    {
        private List<Notification> _notifications;
        private List<NotificationArea> _subscribers;
        
        public NotificationManager()
        {
            _subscribers = new List<NotificationArea>();
            _notifications = new List<Notification>();
        }
        
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
            foreach (var subscriber in _subscribers)
            {
                subscriber?.ReactToNotification();
            }
        }
        
        public List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void Subscribe(NotificationArea notificationArea)
        {
            _subscribers.Add(notificationArea);   
        }

        public Notification GetLastNotification()
        {
            return _notifications[_notifications.Count];
        }

        public void Remove(string title)
        {
            _notifications.Find(notification => notification.Title.Equals(title));
        }
    }
}