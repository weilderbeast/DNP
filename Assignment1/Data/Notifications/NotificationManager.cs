using System;
using System.Threading.Tasks;
using Assignment1.Data.Notifications.NotificationModel;

namespace Assignment1.Data.Notifications
{
    public class NotificationManager
    {
        public event Action<Notification> OnShow;
        public event Action OnHide;

        public async Task Show(string title, string content, NotificationType type)
        {
            OnShow?.Invoke(new Notification()
            {
                Title = title,
                Content = content,
                Type = type
            });
            await Task.Delay(5000);
            try
            {
                OnHide?.Invoke();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

        }

    }
}