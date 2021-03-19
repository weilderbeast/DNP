using System;
using System.Timers;
using Assignment1.Data.NotificationService.NotificationModel;

namespace Assignment1.Data.NotificationService
{
    public class NotificationManager : IDisposable
    {
        public event Action<string, string, NotificationType> OnShow;
        public event Action OnHide;
        private Timer Countdown;

        public void Push(NotificationModel.NotificationModel notificationModel)
        {
            OnShow?.Invoke(notificationModel.Title, notificationModel.Content, notificationModel.Type);
            StartCountdown();
        }

        private void StartCountdown()
        {
            Console.WriteLine("called start countdown");
            SetCountdown();
            if (Countdown.Enabled)
            {
                Countdown.Enabled = false;
                Countdown.Enabled = true;
                Console.WriteLine("stopped and started");
            }
            else
            {
                Countdown.Enabled = true;
                Console.WriteLine("started");
            }
        }

        private void SetCountdown()
        {
            Console.WriteLine("called set countdown");
            if (Countdown == null)
            {
                Countdown = new Timer();
                Countdown.Elapsed += HideToast; 
                Countdown.Elapsed += Announce;
                Countdown.Interval = 1000;
                Countdown.AutoReset = false;
                Console.WriteLine("got inside the if");
                Console.WriteLine(Countdown.ToString());
            }
        }

        private void Announce(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("timer ended");
        }

        private void HideToast(object sender, ElapsedEventArgs e)
        {
            OnHide?.Invoke();
            Console.WriteLine("called hide on the manager");
        }

        public void Dispose()
        {
            Countdown?.Dispose();
            Console.WriteLine("called dispose in manager");
        }
    }
}