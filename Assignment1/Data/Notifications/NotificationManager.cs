using System;
using System.Collections.Generic;
using Assignment1.Shared.Components.Notifications;

namespace Assignment1.Data.Notifications{
    public class NotificationManager : INotificationManager
    {
        //TODO do a singleton
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
            Notify();
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

        public void Remove(Notification notification)
        {
            _notifications.Remove(notification);
            Notify();
        }

        private void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                Console.WriteLine("Notified "+subscriber);
                subscriber.ReactToNotification();
            }
        }
    }
}