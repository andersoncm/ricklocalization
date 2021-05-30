using RickLocalization.Domain.Interfaces.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Notification
{
    public sealed class Notification : INotification
    {
        public Notification(string title, string reason, ETypeNotification typeNotification)
        {
            Title = title;
            Reason = reason;
            TypeNotification = typeNotification;
        }

        public string Title { get; private set; }
        public string Reason { get; private set; }
        public ETypeNotification TypeNotification { get; set; }

    }
}
