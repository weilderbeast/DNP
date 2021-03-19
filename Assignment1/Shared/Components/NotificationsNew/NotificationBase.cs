using System;
using Assignment1.Data.NotificationService;
using Assignment1.Data.NotificationService.NotificationModel;
using Microsoft.AspNetCore.Components;

namespace Assignment1.Shared.Components.NotificationsNew
{
    public class NotificationBase: ComponentBase, IDisposable
    {
        [Inject] private NotificationManager NotificationManager { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsVisible { get; set; }
        public string CssClass { get; set; }

        protected override void OnInitialized()
        {
            NotificationManager.OnShow += ShowNotification;
            NotificationManager.OnHide += HideNotification;
        }

        private void HideNotification()
        {
            IsVisible = false;
            StateHasChanged();
            Console.WriteLine("called hide on notification base");
        }

        private void ShowNotification(string arg1, string arg2, NotificationType arg3)
        {
            MakeNotification(arg1, arg2, arg3);
            IsVisible = true;
            StateHasChanged();
        }

        private void MakeNotification(string s, string s1, NotificationType arg3)
        {
            Title = s;
            Content = s1;
            switch (arg3)
            {
                case NotificationType.Error:
                    CssClass = "#fc3503";
                    break;
                case NotificationType.Info:
                    CssClass = "#00bfff";
                    break;
                case NotificationType.Success:
                    CssClass = "#00ff0d";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(arg3), arg3, "how did u get this error");
            }
        }

        public void Dispose()
        {
            NotificationManager.OnShow -= ShowNotification;
            Console.WriteLine("called dispose in notification base");
        }
    }
}