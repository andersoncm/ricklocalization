using RickLocalization.Domain.Interfaces.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickLocalization.Domain.Notification
{

    public class Notifiable : INotifiable
    {
        private readonly List<INotification> _notifications;

        public Notifiable() => _notifications = new List<INotification>();

        public void AddNotification(string name, string message, ETypeNotification typeNotification = ETypeNotification.Error)
        {
            _notifications.Add(new Notification(name, message, typeNotification));
        }

        public void AddNotification(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<INotification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<INotification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<INotification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(INotifiable item)
        {
            AddNotifications(item.GetNotifications());
        }

        public void AddNotifications(params INotifiable[] items)
        {
            foreach (var item in items)
                AddNotifications(item);
        }

        public IList<INotification> GetNotifications() => _notifications;

        public IList<INotification> GetErrors() => _notifications.Where(tb => tb.TypeNotification == ETypeNotification.Error).ToList();

        public bool Valid() => !_notifications.Any(tb => tb.TypeNotification == ETypeNotification.Error);

    }

    public enum ETypeNotification
    {
        Success = 1,
        Information = 2,
        Error = 3
    }
}
