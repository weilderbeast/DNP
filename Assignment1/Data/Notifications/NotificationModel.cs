using System;
using Microsoft.AspNetCore.Components;

namespace Assignment1.Data.Notifications
{
    public class NotificationModel
    {
        
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public NotificationType Severity { get; set; }

        private string _color = "lightblue";

        public NotificationModel()
        {
            switch (Severity)
            {
                case NotificationType.Error:
                    _color = "";
                    _color = "#FD4D4D";
                    break;
                case NotificationType.Info:
                    _color = "";
                    _color = "#add8e6";
                    break;
                case NotificationType.Success:
                    _color = "";
                    _color = "#32CD32";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void Remove(){
            //NotificationManager.Remove(this);
        }

    }
}